using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailerGUI
{
    public class MailMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTimeOffset Date { get; set; }
        public InternetAddressList Sender { get; set; }

        public MailMessage(string sub, string body, DateTimeOffset date, InternetAddressList sender)
        {
            this.Subject = sub;
            this.Body = body;
            this.Date = date;
            this.Sender = sender;
        }
    }
}
