using Common.Messages.Base;
using System.Net;
using System.Net.Sockets;

namespace Common.Connections
{
    public abstract class SocketConnection : IConnection
    {
        protected const int maxMessageSizeBytes = 10000;
        protected Socket Socket { get; private set; }
        protected EndPoint EndPoint { get; private set; }
        public SocketConnection(Socket socket, EndPoint endPoint)
        {
            Socket = socket;
            EndPoint = endPoint;
        }
        public abstract BaseMessage ReceiveMessage();
        public abstract void SendMessage(BaseMessage message);
        public void Close()
        {
            if (Socket != null)
            {
                Socket.Shutdown(SocketShutdown.Both);
                Socket.Close();
                Socket = null;
            }
        }
    }
}
