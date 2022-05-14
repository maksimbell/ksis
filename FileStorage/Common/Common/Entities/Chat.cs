using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Entities
{
    [Serializable()]
    public class Chat
    {
        public string Id { get; }
        public string Name { get; set; }
        public List<User> Members { get; }
        public bool HasUnread { get; set; }
        public List<ChatMessage> Messages { get; }

        public Chat(string name)
        {
            Id = Guid.NewGuid().ToString("N");
            Name = name;
            Members = new List<User>();
            Messages = new List<ChatMessage>();
            HasUnread = true;
        }

        public Chat(User u1, User u2)
        {
            Id = Guid.NewGuid().ToString("N");
            Name = null;
            Members = new List<User> { u1, u2 };
            HasUnread = true;
            Messages = new List<ChatMessage>();
        }

        public void AddMessage(ChatMessage message)
        {
            Messages.Add(message);
        }

        public void AddUser(User user)
        {
            Members.Add(user);
        }

        public void RemoveUser(string id)
        {
            User deleteUser = Members.Single(user => user.Id == id);
            Members.Remove(deleteUser);
        }
    }
}
