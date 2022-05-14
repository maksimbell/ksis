using Common.Entities;
using System;

namespace Common.Helpers
{
    public static class ChatHelper
    {
        private const string PART_PRIVATE = " (private)";
        private const string PART_UNREAD = " UNREAD";
        private const string PART_ME = "ME";
        private const string PART_ATTACHMENTS = "(ATTACHMENTS)";
        private const string MESSAGE_FORMAT = "{0}({1}): {2}{3}";
        private const string MEMBER_FORMAT = "{0} (Me)";

        public static string GetChatName(Chat chat, User currentUser)
        {
            string chatName = string.Empty;
            if (chat.Name == null)
            {
                foreach (User member in chat.Members)
                {
                    if (member.Id != currentUser.Id)
                    {
                        chatName += member.Username + PART_PRIVATE;
                    }
                }
            }
            else
            {
                chatName = chat.Name;
            }

            return chat.HasUnread ? chatName += PART_UNREAD : chatName;
        }

        public static string GetDateString(DateTime date)
        {
            return date.ToString();
        }

        public static string GetMessageLine(ChatMessage message, User currentUser)
        {
            string messageLine = string.Format(MESSAGE_FORMAT,
                currentUser.Id == message.Sender.Id ? PART_ME : message.Sender.Username,
                GetDateString(message.SendingDate),
                message.Text, 
                message.Attachments.Count != 0 ? PART_ATTACHMENTS : string.Empty);
            return messageLine;
        }

        public static string GetMemberLine(User member, User currentUser)
        {
            string memberLine = member.Id == currentUser.Id ?
                        string.Format(MEMBER_FORMAT, member.Username) : member.Username;
            return memberLine;
        }
    }
}
