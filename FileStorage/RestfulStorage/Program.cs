namespace RESTfulFileService
{
    class Program
    {
        static void Main(string[] args)
        {
            FileServer fileServer = new FileServer();
            fileServer.Start();
        }
    }
}
