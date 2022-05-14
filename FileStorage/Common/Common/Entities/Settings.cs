using System.Collections.Generic;

namespace Common.Entities
{
    public class Settings
    {
        private const int defaultMaxFileSizeMB = 18;
        private const int defaultMaxTotalFileSizeMB = 50;
        public List<string> DisallowedExtensions { get; } = new List<string>() { ".exe", ".bat", ".cmd", ".apk", ".msi" };
        public int MaxFileSizeMB { get; }
        public int MaxTotalFileSizeMB { get; }
        private static Settings settings = null;

        private Settings(int maxFileSizeMB = defaultMaxFileSizeMB, int maxTotalFileSizeMB = defaultMaxTotalFileSizeMB)
        {
            MaxFileSizeMB = maxFileSizeMB;
            MaxTotalFileSizeMB = maxTotalFileSizeMB;
        }

        public static Settings GetInstance()
        {
            if (settings == null)
            {
                settings = new Settings();
            }
            return settings;
        }
    }
}
