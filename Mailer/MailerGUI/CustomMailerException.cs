using System.Runtime.Serialization;

namespace MailerGUI
{
    [Serializable]
    internal class CustomMailerException : Exception
    {
        public CustomMailerException(string? message) : base(message){}
    }
}