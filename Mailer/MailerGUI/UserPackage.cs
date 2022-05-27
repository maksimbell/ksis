using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailerGUI
{
    public class UserPackage
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public int Port { get; set; }

        public string Server { get; set; }

        public bool Ssl { get; set; }

        public UserPackage(string login, string pswrd, int port, string server, bool ssl)
        {
            this.Login = login;
            this.Password = pswrd;
            this.Port = port;
            this.Ssl = ssl;
            this.Server = server;
        }
    }
}
