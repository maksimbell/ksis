using System.Runtime.Serialization;

namespace MailerGUI
{
    [Serializable]
    internal class CustomSmtpException : Exception
    {
        public CustomSmtpException(string? message) : base(message){}
    }
}