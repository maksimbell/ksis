using Common.Helpers;

namespace Common.FileHandling
{
    public class ClientUploadedFile
    {
        private const string FILENAME_FORMAT = "{0}.{1}";
        private const double MB_FACTOR = 1.0 / 1048576;
        private const string FILE_UPLOADED_FORMAT = "{0}.{1} - {2}";
        private const string FILE_UPLOAD_SUCCESS = "uploaded";
        private const string FILE_UPLOAD_IN_PROCESS = "...";

        public string Name { get; set; }
        public string Extension { get; }
        public string FullName { get => string.Format(FILENAME_FORMAT, Name, Extension); }
        public bool Uploaded { get; set; }
        public string ResourceId { get; set; } = null;
        public byte[] Data { get; set; } = null;
        public double Size { get => Data.Length * MB_FACTOR; }

        public ClientUploadedFile(string fullName)
        {
            Name = FileHelper.GetBareName(fullName);
            Extension = FileHelper.GetExtension(fullName);
            Uploaded = false;
        }

        public ClientUploadedFile(ClientUploadedFile f)
        {
            Name = f.Name;
            Extension = f.Extension;
            Uploaded = f.Uploaded;
        }

        public override string ToString()
        {
            return string.Format(FILE_UPLOADED_FORMAT, Name, Extension,
                Uploaded ? FILE_UPLOAD_SUCCESS : FILE_UPLOAD_IN_PROCESS);
        }
    }
}
