using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Common.Helpers
{
    public class HttpRequestHelper
    {
        public const string DEFAULT_NOT_FOUND_HEADER_VALUE = "(no such name)";
        public const string MSG_NO_HEADERS_SPECIFIED = "No headers specified for the request";

        public HttpContent RequestContent { get; private set; } = null;

        public void LoadFile(byte[] fileBytes)
        {
            Stream contentStream = new MemoryStream(fileBytes);
            RequestContent = new StreamContent(contentStream);
        }

        public void AddHeader(string key, string value)
        {
            RequestContent.Headers.Add(key, value);
        }

        public static string GetHeaderByKey(NameValueCollection headers, string key)
        {
            string[] values = headers.GetValues(key);
            if (values != null)
            {
                return values[0];
            }
            else
            {
                throw new Exception(MSG_NO_HEADERS_SPECIFIED);
            }
        }

        public static string GetHeaderByKey(HttpHeaders headers, string key)
        {
            string value = DEFAULT_NOT_FOUND_HEADER_VALUE;
            if (headers.TryGetValues(key, out IEnumerable<string> values))
            {
                value = values.First();
            }
            return value;
        }
    }
}
