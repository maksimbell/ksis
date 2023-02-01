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
using System.Net;

namespace MailerGUI
{
    public class Mailer
    {
        private ImapClient Imap { get; set; }

        private SmtpClient Smtp { get; set; }

        private UserPackage UserPackage { get; set; }

        private const string SMTP_URL = "smtp.";
        private const string IMAP_URL = "imap.";
        public Mailer(UserPackage userPackage)
        {
            UserPackage = userPackage; 

            Imap = new ImapClient();
            Imap.Connect(IMAP_URL + UserPackage.Server, UserPackage.Port, UserPackage.Ssl);
            Imap.Authenticate(UserPackage.Login, UserPackage.Password);

            Smtp = new SmtpClient(SMTP_URL + UserPackage.Server, 587);
            Smtp.Credentials = new NetworkCredential(UserPackage.Login, UserPackage.Password);
            Smtp.EnableSsl = UserPackage.Ssl;
        }
        public List<CustomMessage> LoadMail()
        {
            var inbox = Imap.Inbox;
            Imap.Inbox.Open(FolderAccess.ReadOnly);
            var uids = Imap.Inbox.Search(SearchQuery.All);

            List<CustomMessage> mail = new List<CustomMessage>();

            for (int i = 0; i < 10; i++)
            {
                var message = Imap.Inbox.GetMessage(uids.Count - i - 1);
                List<MimeEntity> attachments = new List<MimeEntity>();

                foreach (var attachment in message.Attachments)
                {
                    attachments.Add(attachment);
                }
                mail.Add(new CustomMessage(
                    message.Subject,
                    (TextPart)message.BodyParts.OfType<TextPart>().FirstOrDefault(),
                    message.Date,
                    message.From,
                    message.To,
                    attachments)
                   );
            }
            return mail;
        }

        public void SendMail(MailMessage mailMessage)
        {
            try
            {
                Smtp.Send(mailMessage);
            }catch (Exception ex)
            {
                throw new CustomMailerException("Fail");
            }
        }
    }
}
