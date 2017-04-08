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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            foreach(var message in textBox.Text.Split('\n'))
            {
                //AddMessage($"{SocketHelper.Username}: {message}");
                await SocketHelper.SendChatMessage(message);
            }
            textBox.Text = null;
            textBox.Focus();
        }

        private void ChatListMenu_Add_Click(object sender, EventArgs e)
        {

        }

        private void ChatListMenu_Delete_Click(object sender, EventArgs e)
        {

        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SocketHelper.EndConnection();
            Program.LoginForm.Close();
        }

        public void AddMessage(string message)
        {
            messageList.Items.Add(message);
        }

        public void ClearChatMessages()
        {
            messageList.Items.Clear();
        }
    }
}
