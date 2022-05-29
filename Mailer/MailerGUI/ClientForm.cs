using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;

namespace MailerGUI
{
    public partial class ClientForm : Form
    {
        private Mailer mailer;
        private List<MailMessage> mailMessages;
        public ClientForm(UserPackage userPackage)
        {
            InitializeComponent();
            mailer = new Mailer(userPackage);
            mailMessages = mailer.LoadMail();
            LoadMailForm();
        }

        private void LoadMailForm()
        {
            for (int i = 0; i < mailMessages.Count; i++)
            {
                string mailString = mailMessages[i].Sender[0].Name;
                lbMail.Items.Add(mailString);
                
            }
            /*for(int i = 0; i < mailMessages.Count; i++)
            {
                gridMail.Rows.Add(1);
                gridMail.Rows[i].Cells[0].Value = mailMessages[i].Sender;
                if (mailMessages[i].Subject != null)
                {
                    gridMail.Rows[i].Cells[1].Value = mailMessages[i].Subject;
                }
                else
                {
                    gridMail.Rows[i].Cells[1].Value = "";
                }

                gridMail.Rows[i].Cells[2].Value = mailMessages[i].Date;
            }*/
        }

        public void SetImapClient(UserPackage userPackage)
        {
            //client = new ImapClient(); 
            /*using (client = new ImapClient())
            {
                client.Connect(userPackage.Server, userPackage.Port, userPackage.Ssl);

                client.Authenticate(userPackage.Login, userPackage.Password);

                var inbox = client.Inbox;
                client.Inbox.Open(FolderAccess.ReadOnly);
                var uids = client.Inbox.Search(SearchQuery.All);

                for (int i = 0; i < 10; i++)
                {
                    gridMail.Rows.Add(1);
                    var message = client.Inbox.GetMessage(uids.Count - i - 1);
                    gridMail.Rows[i].Cells[0].Value = message.From[0].ToString();
                    if (message.Subject != null)
                    {
                        gridMail.Rows[i].Cells[1].Value = message.Subject.ToString();
                    }
                    else
                    {
                        gridMail.Rows[i].Cells[1].Value = "";
                    }

                    gridMail.Rows[i].Cells[2].Value = message.Date.ToString().Substring(0, 10);
                }

            }*/
        }

        private void MailClient_Load(object sender, EventArgs e)
        {

        }

        private void MailClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            //LoginForm.ActiveForm.Show();
        }

        private void tabMail_Click(object sender, EventArgs e)
        {

        }

        private void gridMail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridMail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
