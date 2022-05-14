using System;
using System.Net;
using System.Threading;

namespace RESTfulFileService
{
    public class FileServer
    {
        private const string MSG_SERVICE_STARTUP = "File server has started...";
        private const string MSG_ERROR_FILE_SERVICE = "[FILE SERVICE ERROR]: {0}";
        private const string MAIN_URL = "http://localhost:9333/files/";

        private readonly HttpListener listener;
        private readonly ResourceRequestHandler restService = new ResourceRequestHandler();

        public FileServer()
        {
            listener = new HttpListener();
            listener.Prefixes.Add(MAIN_URL);
        }

        public void Start()
        {
            listener.Start();
            Console.WriteLine(MSG_SERVICE_STARTUP);
            Listen();
        }

        private void Listen()
        {
            while (true)
            {
                try
                {
                    HttpListenerContext context = listener.GetContext();
                    ThreadPool.QueueUserWorkItem(HandleRequest, context);
                }
                catch (Exception e)
                {
                    Console.WriteLine(MSG_ERROR_FILE_SERVICE, e.Message);
                }
            }
        }

        private void HandleRequest(object requestContext)
        {
            var ctx = (HttpListenerContext)requestContext;
            restService.Perform(ctx);
        }
    }
}
