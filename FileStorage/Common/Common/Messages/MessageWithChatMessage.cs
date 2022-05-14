using Common.Entities;
using Common.Messages.Base;
using System;

namespace Common.Messages
{
    [Serializable()]
    public class MessageWithChatMessage : BaseMessage
    {
        public ChatMessage Message { get; }
        public MessageWithChatMessage(MessageTypes type, ChatMessage message) : base(type)
        {
            Message = message;
        }
    }
}
