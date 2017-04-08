using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_socketchat
{
    static class Program
    {
        public static LoginForm LoginForm { get; private set; }
        public static ChatForm ChatForm { get; set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm = new LoginForm();
            Application.Run(LoginForm);
        }
    }
}
