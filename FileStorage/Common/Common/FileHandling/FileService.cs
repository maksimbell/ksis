using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.FileHandling
{
    public static class FileService
    {
        public static byte[] ConvertToByteArray(Stream stream)
        {
            byte[] buffer;
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                buffer = ms.ToArray();
            }
            return buffer;
        }

        public static void WriteBytesToResponseBody(byte[] bytes, HttpListenerResponse response)
        {
            response.ContentLength64 = bytes.Length;
            Stream output = response.OutputStream;
            output.Write(bytes, 0, bytes.Length);
            output.Close();
        }

        public static void WriteBytesByPath(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

        public static async Task<byte[]> ReadContentAsBytesAsync(HttpContent content)
        {
            var stream = await content.ReadAsStreamAsync();
            return ConvertToByteArray(stream);
        }
    }
}
