using System;

namespace RESTfulFileService.ResponseExceptions
{
    public class MethodNotImplementedException : Exception
    {
        private const string MSG_DEFAULT = "Method not implemented";
        public MethodNotImplementedException(string status = MSG_DEFAULT) : base(status) { }
    }
}
