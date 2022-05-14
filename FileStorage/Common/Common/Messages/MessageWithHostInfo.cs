using Common.Messages.Base;
using System;

namespace Common.Messages
{
    [Serializable()]
    public class MessageWithHostInfo : BaseMessage
    {
        public string Ip { get; }
        public int Port { get; }
        public MessageWithHostInfo(MessageTypes type, string ip, int port) : base(type)
        {
            Ip = ip;
            Port = port;
        }
    }
}
