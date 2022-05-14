using System;

namespace Common.FileHandling
{
    public class FileEntity
    {
        private const string STORED_FILE_FORMAT = "{0}+{1}";

        public string Id { get; private set; }
        public string UserDefinedName { get; set; }
        //public string Name {
        //    get => string.Format(STORED_FILE_FORMAT, UserDefinedName, Id);
        //}
        public byte[] Data { get; private set; }
        public int Size { get => Data.Length; }

        public FileEntity(string userDefinedName, byte[] fileData)
        {
            Id = Guid.NewGuid().ToString("N");
            Data = fileData;
            UserDefinedName = userDefinedName;
        }
    }
}
