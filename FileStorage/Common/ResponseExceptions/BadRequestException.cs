using System;

namespace RESTfulFileService.ResponseExceptions
{
    public class BadRequestException : Exception
    {
        private const string MSG_DEFAULT = "Bad request";
        public BadRequestException(string status = MSG_DEFAULT) : base(status) { }
    }
}
