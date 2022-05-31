using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailerGUI
{
    public class CustomMessage
    {
        public string Subject { get; set; }
        public TextPart Body { get; set; }
        public DateTimeOffset Date { get; set; }
        public InternetAddressList Sender { get; set; }
        public InternetAddressList Recipient { get; set; }

        public CustomMessage(string sub, TextPart body, DateTimeOffset date, 
            InternetAddressList sender, InternetAddressList recipient)
        {
            this.Subject = sub;
            this.Body = body;
            this.Date = date;
            this.Sender = sender;
            this.Recipient = recipient;
        }
    }
}
