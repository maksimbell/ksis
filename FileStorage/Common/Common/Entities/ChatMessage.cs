using Common.Attachments;
using System;
using System.Collections.Generic;

namespace Common.Entities
{
    [Serializable()]
    public class ChatMessage
    {
        public string Text { get; set; } = "";
        public User Sender { get; } = null;
        public DateTime SendingDate { get; set; }
        public string ChatId { get; }
        public List<FileAttachment> Attachments { get; }

        public ChatMessage(User user, string text, string chatId, List<FileAttachment> fileAttachments)
        {
            Sender = user;
            Text = text;
            ChatId = chatId;
            SendingDate = DateTime.Now;
            Attachments = fileAttachments;
        }
    }
}
