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
        private SocketHelper socketHelper;

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
            ToggleBlockInterface();
            if (Username.Text.Length < 4)
            {
                MessageBox.Show("El nom d'usuari es molt curt!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToggleBlockInterface();
                return -1;
            }

            int port = 0;
            try
            {
                port = int.Parse(textPort.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El port ha de ser un número!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToggleBlockInterface();
                return -2;
            }

            socketHelper = new SocketHelper
            {
                Username = Username.Text,
                ServerIp = textIp.Text,
                ServerPort = port
            };

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
            ToggleBlockInterface();
            return 2;
        }

        private void ToggleBlockInterface()
        {
            textPort.Enabled = !textPort.Enabled;
            textIp.Enabled = !textIp.Enabled;
            Username.Enabled = !Username.Enabled;
            button1.Enabled = !button1.Enabled;
        }
    }
}
