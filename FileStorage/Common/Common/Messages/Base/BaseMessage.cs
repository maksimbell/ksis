using System;

namespace Common.Messages.Base
{
    [Serializable()]
    public abstract class BaseMessage
    {
        public MessageTypes Type { get; }
        protected BaseMessage(MessageTypes type)
        {
            Type = type;
        }
    }
}
