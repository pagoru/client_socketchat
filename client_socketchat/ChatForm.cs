using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_socketchat
{
    public partial class ChatForm : Form
    {
        public SocketHelper SocketHelper { get; set; }

        public ChatForm(SocketHelper socketHelper)
        {
            SocketHelper = socketHelper;
            InitializeComponent();
            chatList.SelectedIndex = 0;

            UsernameLabel.Text = socketHelper.Username;
        }

        private void ChatListMenu_Add_Click(object sender, EventArgs e)
        {
            string roomname = Microsoft.VisualBasic.Interaction
                .InputBox("Añadir nueva sala de chat", "Añadir sala", "Nombre de la sala", 0, 0);

            if(roomname.Length == 0)
            {
                return;
            }
            chatList.Items.Add(roomname);
        }

        private void ChatListMenu_Delete_Click(object sender, EventArgs e)
        {
            if (chatList.SelectedIndex == 0)
            {
                return;
            }
            chatList.Items.RemoveAt(chatList.SelectedIndex);

        }

        private int _oldChat { get; set; } = 0;
        private void chatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chatList.SelectedIndex == -1)
            {
                return;
            }
            if(_oldChat == chatList.SelectedIndex)
            {
                return;
            }
            _oldChat = chatList.SelectedIndex;
            SelectChatroom(chatList.Items[chatList.SelectedIndex].ToString());
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SocketHelper.EndConnection();
            Program.LoginForm.Close();
        }

        public async void SelectChatroom(string roomname)
        {
            messageList.Items.Clear();
            await SocketHelper.ChangeRoom(roomname);
        }

        public void AddMessage(string message)
        {
            messageList.Items.Add(message);
            messageList.TopIndex = messageList.Items.Count - 1;
        }

        public void ClearChatMessages()
        {
            messageList.Items.Clear();
        }

        private async void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                await SocketHelper.SendChatMessage(textBox.Text);
                textBox.Text = null;
            }
        }
    }
}
