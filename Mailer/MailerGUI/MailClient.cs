using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Pop3;
using OpenPop.Mime;


namespace MailerGUI
{
    public partial class MailClient : Form
    {
        private Pop3Client client;

        public MailClient(UserPackage userPackage)
        {
            InitializeComponent();
            CreateMailClient(userPackage);
        }
        public void CreateMailClient(UserPackage userPackage)
        {
            var client = new Pop3Client();
            client.Connect(userPackage.Server, userPackage.Port, userPackage.Ssl);
            client.Authenticate(userPackage.Login, userPackage.Password);

            var count = client.GetMessageCount();
            OpenPop.Mime.Message message = client.GetMessage(count);
            Console.WriteLine(message.Headers.Subject);
        }

        private void MailClient_Load(object sender, EventArgs e)
        {

        }

        private void MailClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            //LoginForm.ActiveForm.Show();
        }
    }
}
