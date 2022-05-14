using Common.Attachments;
using Common.Entities;
using Common.FileHandling;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;

namespace Common.Helpers
{
    public static class FileHelper
    {
        private const string ARCHIVE_EXTENSION = "zip";
        private const string DOT = ".";
        private const string BACKSLASH = "\\";

        public static string GetFileName(string absolutePath)
        {
            int indice = absolutePath.LastIndexOf(BACKSLASH);
            return absolutePath.Substring(indice + 1, absolutePath.Length - indice - 1);
        }

        public static string GetBareName(string fullName)
        {
            int indice = fullName.LastIndexOf(DOT);
            return indice == 0 ? string.Empty :
                indice != -1 ? fullName.Substring(0, indice) : fullName;
        }

        public static string GetExtension(string fullName)
        {
            int indice = fullName.LastIndexOf(DOT);
            return indice != -1 ? fullName.Substring(indice + 1) : string.Empty;
        }

        public static List<FileAttachment> GetAsFileAttachments(List<ClientUploadedFile> uploadedFiles)
        {
            List<FileAttachment> fileAttachments = new List<FileAttachment>();
            uploadedFiles.ForEach(uploadedFile => fileAttachments.Add(new FileAttachment(uploadedFile.ResourceId)));
            return fileAttachments;
        }

        public static bool HasAllowedExtension(string filePath)
        {
            bool isAllowed = true;

            if (GetExtension(filePath) == ARCHIVE_EXTENSION)
            {
                using (ZipArchive archive = ZipFile.OpenRead(filePath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        foreach (string extension in Settings.GetInstance().DisallowedExtensions)
                        {
                            if (entry.FullName.EndsWith(extension))
                            {
                                isAllowed = false;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (string extension in Settings.GetInstance().DisallowedExtensions)
                {
                    if (filePath.EndsWith(extension))
                    {
                        isAllowed = false;
                        break;
                    }
                }
            }
            return isAllowed;
        }

        public static bool AttachmentSizeExceeded(ClientUploadedFile file)
        {
            double maxSize = Settings.GetInstance().MaxFileSizeMB;
            return file.Size > maxSize;
        }

        public static bool AttachmentListSizeExceeded(List<ClientUploadedFile> files)
        {
            double maxTotalSize = Settings.GetInstance().MaxTotalFileSizeMB;
            double totalFileSize = files.Sum(file => file.Size);
            return totalFileSize > maxTotalSize;
        }
    }
}
