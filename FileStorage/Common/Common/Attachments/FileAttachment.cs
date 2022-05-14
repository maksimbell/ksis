using System;

namespace Common.Attachments
{
    [Serializable()]
    public class FileAttachment
    {
        public string Id { get; }

        public FileAttachment(string fileAttachmentId)
        {
            Id = fileAttachmentId;
        }
    }
}
