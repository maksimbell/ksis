using Common.Entities;
using Common.Messages.Base;
using System;
using System.Collections.Generic;

namespace Common.Messages
{
    [Serializable()]
    public class MessageWithChatList : BaseMessage
    {
        public List<Chat> Chats { get; }
        public MessageWithChatList(MessageTypes type, List<Chat> chatList) : base(type)
        {
            Chats = chatList;
        }
    }
}
