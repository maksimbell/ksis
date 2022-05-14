using Common.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Common.Storage
{
    public class ServerStorage
    {
        private const string GLOBAL_CHAT_NAME = "Global Chat";
     
        private readonly ChatsStorage Chats = new ChatsStorage();
        private readonly UserStorage Users = new UserStorage();

        public ServerStorage()
        {
            Chats.AddNew(new Chat(GLOBAL_CHAT_NAME));
        }

        public void AddUserToGlobalChat(User user)
        {
            Chat globalChat = Chats.FindByName(GLOBAL_CHAT_NAME);
            globalChat.AddUser(user);
            Users.AddNew(user);
            user.AddChatId(globalChat.Id);
        }

        public Chat GetGlobalChat()
        {
            return Chats.FindByName(GLOBAL_CHAT_NAME);
        }

        public List<string> GetAllUsersIds()
        {
            Chat globalChat = Chats.FindByName(GLOBAL_CHAT_NAME);
            return globalChat.Members.Select(member => member.Id).ToList();
        }

        public List<string> GetChatUserIds(Chat chat)
        {
            Chat globalChat = Chats.GetById(chat.Id);
            return globalChat.Members.Select(member => member.Id).ToList();
        }

        public Chat AddChatMessage(ChatMessage message)
        {
            Chat updatedChat = Chats.GetById(message.ChatId);
            updatedChat.Messages.Add(message);
            return updatedChat;
        }

        public Chat CreateNewChat(Chat chat)
        {
            List<string> chatUserIds = chat.Members.Select(member => member.Id).ToList();
            chatUserIds.ForEach(userId => { User u = Users.GetById(userId); u.AddChatId(chat.Id); });
            chat.Name = chat.Members[0].Username + " + " + chat.Members[1].Username;
            Chats.SetById(chat.Id, chat);
            return Chats.GetById(chat.Id);
        }

        public List<Chat> GetAllChatsOfUser(string id)
        {
            return Chats.GetAllChatsOfUser(id);
        }

        public void RemoveUserFromAllChats(string id)
        {
            Chats.RemoveUserFromAllChats(id);
            Users.RemoveById(id);
        }

        public Chat GetChatById(string id)
        {
            return Chats.GetById(id);
        }

        public User GetUserById(string id)
        {
            return Users.GetById(id);
        }
    }
}
