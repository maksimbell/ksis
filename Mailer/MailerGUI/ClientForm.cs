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
using System.Net.Mail;

namespace MailerGUI
{
    public partial class ClientForm : Form
    {
        private Mailer mailer;
        private List<CustomMessage> mailMessages;
        private List<Attachment> attachments = new List<Attachment>();
        //private MailMessage message;
        public ClientForm(UserPackage userPackage)
        {
            InitializeComponent();
            mailer = new Mailer(userPackage);
            mailMessages = mailer.LoadMail();
            LoadMailForm();
            lbMail.SelectedIndex = 0;

            this.Text = userPackage.Login;
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(this.Text);
                message.To.Add(rtbToSend.Text);
                message.Subject = rtbSubSend.Text;
                message.Body = rtbMessageSend.Text;
                message.IsBodyHtml = false;
                foreach (Attachment attachment in attachments)
                    message.Attachments.Add(attachment);
                mailer.SendMail(message);

            }catch (CustomSmtpException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Message sent");
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string path = dialog.FileName;
                attachments.Add(new Attachment(path));
                tvAttachments.Nodes.Add(dialog.FileName.Split("\\")[^1]);
            }
        }

        private void tvAttachments_DoubleClick(object sender, EventArgs e)
        {
            attachments.RemoveAt(tvAttachments.SelectedNode.Index);
            tvAttachments.SelectedNode.Remove();
        }

        private void rtbToSend_TextChanged(object sender, EventArgs e)
        {
            if(this.Text == "")
            {
                btnSend.Enabled = false;
            }
            else
            {
                btnSend.Enabled = true;
            }
        }
    }
}
