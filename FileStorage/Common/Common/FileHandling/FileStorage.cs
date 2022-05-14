using System.Collections.Generic;

namespace Common.FileHandling
{
    public class FileStorage
    {
        public Dictionary<string, FileEntity> Files { get; private set; } = new Dictionary<string, FileEntity>();

        public void AddFile(FileEntity fileEntity)
        {
            Files.Add(fileEntity.Id, fileEntity);
        }

        public bool HasFile(string fileId)
        {
            return Files.ContainsKey(fileId);
        }

        public FileEntity GetFile(string fileId)
        {
            return Files[fileId];
        }

        public void DeleteFile(string fileId)
        {
            Files.Remove(fileId);
        }
    }
}
