using Common.Entities;
using Common.Messages.Base;
using System;

namespace Common.Messages
{
    [Serializable()]
    public class MessageWithUser : BaseMessage
    {
        public User User { get; }
        public MessageWithUser(MessageTypes type, User user) : base(type)
        {
            User = user;
        }
    }
}
