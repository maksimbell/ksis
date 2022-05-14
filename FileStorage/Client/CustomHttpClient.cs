using Common.FileHandling;
using Common.Helpers;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    public class CustomHttpClient
    {
        private const string DEFAULT_API_URL = "http://localhost:9333/files/{0}";
        private readonly string apiUrl = null;
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly HttpRequestHelper requestHelper = new HttpRequestHelper();
        private static CustomHttpClient client = null;

        private CustomHttpClient(string externalApiUrl = DEFAULT_API_URL)
        {
            apiUrl = externalApiUrl;
        }

        public static CustomHttpClient GetInstance()
        {
            if (client == null)
            {
                client = new CustomHttpClient();
            }
            return client;
        }

        public async Task<HttpResponseMessage> PostAsync(ClientUploadedFile file, string operationName = "")
        {
            requestHelper.LoadFile(file.Data);
            requestHelper.AddHeader("Name", file.FullName);

            return await httpClient.PostAsync(string.Format(apiUrl, operationName), requestHelper.RequestContent);
        }

        public async Task<HttpResponseMessage> PostAsync(string resourceId)
        {
            string query = string.Format(apiUrl, resourceId);
            //Console.WriteLine(query);

            return await httpClient.PostAsync(query, requestHelper.RequestContent);
        }

        public async Task<HttpResponseMessage> GetAsync(string resourceId)
        {
            HttpResponseMessage response = await httpClient.GetAsync(string.Format(apiUrl, resourceId));
            return response;
        }

        public async Task<HttpResponseMessage> HeadAsync(string resourceId)
        {
            HttpResponseMessage response = await httpClient.SendAsync(
                    new HttpRequestMessage(HttpMethod.Head, string.Format(apiUrl, resourceId)));
            return response;
        }

        public async Task<HttpResponseMessage> DeleteAsync(string resourceId)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(string.Format(apiUrl, resourceId));
            return response;
        }

        public async Task<HttpResponseMessage> PutAsync(ClientUploadedFile file, string resourceId)
        {
            requestHelper.LoadFile(file.Data);
            requestHelper.AddHeader("Name", file.FullName);

            HttpResponseMessage response = await httpClient.PutAsync(string.Format(apiUrl, resourceId), requestHelper.RequestContent);
            return response;
        }

        public async Task<HttpResponseMessage> PatchAsync(string resourceId, string name)
        {
            requestHelper.LoadFile(Array.Empty<byte>());
            requestHelper.AddHeader("Name", name);

            HttpResponseMessage response = await httpClient.PatchAsync(string.Format(apiUrl, resourceId), requestHelper.RequestContent);
            return response;
        }
    }
}
