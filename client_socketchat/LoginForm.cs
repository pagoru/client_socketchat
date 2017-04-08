using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_socketchat
{
    public partial class LoginForm : Form
    {
        private SocketHelper socketHelper = new SocketHelper();

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Login();
        }

        private async void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                await Login();
            }
        }

        private async Task<int> Login()
        {
            socketHelper.Username = Username.Text;

            if (await socketHelper.Connect())
            {
                await socketHelper.Login();
                Program.ChatForm = new ChatForm(socketHelper);
                this.Hide();
                Program.ChatForm.Show();
                return 1;
            }
            MessageBox.Show("El servidor no esta obert!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 2;
        }
    }
}
