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
            lbMail.SelectedIndex = 0;
        }

        private void LoadMailForm()
        {
            for (int i = 0; i < mailMessages.Count; i++)
            {
                string mailString = mailMessages[i].Sender[0].Name + "  |  " + 
                    mailMessages[i].Subject.PadRight(15, ' ').Substring(0, 15) + "...  |  " +
                    mailMessages[i].Date.ToString().Substring(0,10);
                lbMail.Items.Add(mailString);
                
            }
        }

        private void MailClient_Load(object sender, EventArgs e)
        {
            //lbMail.ItemHeight = 100;
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

        private void lbMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMessageContent(lbMail.SelectedIndex);
        }

        private void LoadMessageContent(int index)
        {
            rtbSubject.Text = mailMessages[index].Subject;
            lblSenderOrg.Text = mailMessages[index].Sender[0].Name;
            lblDate.Text = mailMessages[index].Date.ToString().Substring(0, 10);
            rtbContent.Text = mailMessages[index].Body.Text;
        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblSenderOrg_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
