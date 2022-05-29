using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using MailKit;
using MailKit.Search;
using MimeKit;

namespace MailerGUI
{
    public class Mailer
    {
        private ImapClient Imap { get; set; }

        private SmtpClient Smtp { get; set; }

        public Mailer(UserPackage userPackage)
        {
            Imap = new ImapClient();
            Imap.Connect(userPackage.Server, userPackage.Port, userPackage.Ssl);
            Imap.Authenticate(userPackage.Login, userPackage.Password);

            Smtp = new SmtpClient();
        }
        public List<MailMessage> LoadMail()
        {
            var inbox = Imap.Inbox;
            Imap.Inbox.Open(FolderAccess.ReadOnly);
            var uids = Imap.Inbox.Search(SearchQuery.All);

            List<MailMessage> mail = new List<MailMessage>();

            for (int i = 0; i < 20; i++)
            {
                var message = Imap.Inbox.GetMessage(uids.Count - i - 1);
                mail.Add(new MailMessage(
                    message.Subject,
                    message.HtmlBody,
                    message.Date,
                    message.From)
                   );

                /*gridMail.Rows.Add(1);
                var message = Imap.Inbox.GetMessage(uids.Count - i - 1);
                gridMail.Rows[i].Cells[0].Value = message.From[0].ToString();
                if (message.Subject != null)
                {
                    gridMail.Rows[i].Cells[1].Value = message.Subject.ToString();
                }
                else
                {
                    gridMail.Rows[i].Cells[1].Value = "";
                }

                gridMail.Rows[i].Cells[2].Value = message.Date.ToString().Substring(0, 10);*/
            }
            return mail;
        }
    }
}
