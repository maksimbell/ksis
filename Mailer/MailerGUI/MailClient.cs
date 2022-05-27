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

namespace MailerGUI
{
    public partial class MailClient : Form
    {
        private ImapClient client;

        public MailClient(UserPackage userPackage)
        {
            InitializeComponent();
            SetImapClient(userPackage);
        }
        public void SetImapClient(UserPackage userPackage)
        {
            /*var client = new ImapClient();
            client.Connect(userPackage.Server, userPackage.Port, true);
            client.Authenticate(userPackage.Login, userPackage.Password);*/

            using (client = new ImapClient())
            {
                client.Connect(userPackage.Server, userPackage.Port, userPackage.Ssl);

                client.Authenticate(userPackage.Login, userPackage.Password);

                var inbox = client.Inbox;
                client.Inbox.Open(FolderAccess.ReadOnly);
                var uids = client.Inbox.Search(SearchQuery.Seen);

                //get all the messages from the specified folder
                for (int i = 0; i < 20; i++)
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

            }
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
