using Common.Entities;
using Common.Messages.Base;
using System;

namespace Common.Messages
{
    [Serializable()]
    public class MessageWithChat : BaseMessage
    {
        public Chat Chat { get; }
        public MessageWithChat(MessageTypes type, Chat chat) : base(type)
        {
            Chat = chat;
        }
    }
}
