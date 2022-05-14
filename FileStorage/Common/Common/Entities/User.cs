using System;
using System.Collections.Generic;

namespace Common.Entities
{
    [Serializable()]
    public class User
    {
        public string Id { get; }
        public string Ip { get; }
        public string Username { get; set; }
        public List<string> ChatIds { get; }

        public User(string username, string ip)
        {
            Id = Guid.NewGuid().ToString("N");
            Username = username;
            Ip = ip;
            ChatIds = new List<string>();
        }

        public void AddChatId(string chatId)
        {
            ChatIds.Add(chatId);
        }
    }
}
