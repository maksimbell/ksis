using Common.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Common.Storage
{
    public class ChatsStorage : KeyValueStorage<Chat>
    {
        public ChatsStorage()
        {
            items = new Dictionary<string, Chat>();
        }

        public Chat AddNew(Chat chat)
        {
            items.Add(chat.Id, chat);
            return chat;
        }

        public List<Chat> GetAllChatsOfUser(string userId)
        {
            List<Chat> list = new List<Chat>();
            foreach (KeyValuePair<string, Chat> chat in items)
            {
                List<string> chatMembersIds = chat.Value.Members.Select(member => member.Id).ToList();
                if (chatMembersIds.Contains(userId))
                {
                    list.Add(chat.Value);
                }
            }
            return list;
        }

        public void RemoveUserFromAllChats(string userId)
        {
            foreach (KeyValuePair<string, Chat> chat in items)
            {
                List<string> chatMembersIds = chat.Value.Members.Select(member => member.Id).ToList();
                if (chatMembersIds.Contains(userId))
                {
                    chat.Value.RemoveUser(userId);
                }
            }
        }
        public void UnreadAllChats()
        {
            foreach (KeyValuePair<string, Chat> chat in items)
            {
                chat.Value.HasUnread = true;
            }
        }
        public override Chat FindByName(string name)
        {
            return items.FirstOrDefault(item => item.Value.Name == name).Value;
        }

        public void UpdateOnlyReceived(List<Chat> chats)
        {
            foreach (Chat chat in chats)
            {
                items.Remove(chat.Id);
                items.Add(chat.Id, chat);
            }
        }
    }
}
