using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace NetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("lilfidgetx@gmail.com");
                mail.To.Add("maksimbell503@gmail.com");
                mail.Subject = "Hello World";
                mail.Body = "<h1>Hello</h1>";
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("C:\\file.zip"));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("lilfidgetx@gmail.com", "rtsgvxxyjwjitasz");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}