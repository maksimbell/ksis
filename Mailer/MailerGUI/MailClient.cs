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
        private Pop3Client client = null;

        public MailClient()
        {
            InitializeComponent();
            //CreateMailClient(login, pswrd);
        }
        public void CreateMailClient(string login, string pswrd)
        {
            var client = new Pop3Client();
            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate("piotr@mailtrap.io", "My_password_here");

            var count = client.GetMessageCount();
            OpenPop.Mime.Message message = client.GetMessage(count);
            Console.WriteLine(message.Headers.Subject);

        }
    }
}
