using Common.Connections;
using Common.Messages.Base;
using System.Threading;

namespace Common.ChatHandlers
{
    public abstract class CustomUdpClient : IMessageHandler
    {
        protected int SendPort { get; private set; }
        protected int ReceivePort { get; private set; }
        protected UdpConnection SendingConnection { get; set; }
        protected UdpConnection ListeningConnection { get; set; }
        protected Thread ListenUdpThread { get; set; }

        public CustomUdpClient(int SendPort, int ReceivePort)
        {
            this.SendPort = SendPort;
            this.ReceivePort = ReceivePort;
        }

        public void Listen()
        {
            ListenUdpThread = new Thread(new ParameterizedThreadStart(HandleMessages));
            ListenUdpThread.Start();
        }

        public void Close()
        {
            ListeningConnection.Close();
            SendingConnection.Close();
            ListenUdpThread.Abort();
            ListenUdpThread.Join();
        }
        public abstract void HandleMessages(object obj);
        public abstract void HandleParticularMessage(BaseMessage message);
    }
}
