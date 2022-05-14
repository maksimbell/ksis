using Common.Connections;
using Common.Entities;
using Common.Messages.Base;

namespace Common.ChatHandlers
{
    public abstract class CustomTcpClient : IMessageHandler
    {
        public int Port { get; private set; }
        protected TcpConnection Connection { get; set; }

        public CustomTcpClient(int port)
        {
            Port = port;
        }

        public abstract void Connect();
        public abstract void Close();
        public abstract void Listen();
        public abstract void HandleMessages(object obj);
        public abstract void HandleParticularMessage(BaseMessage message);
        public abstract void HandleParticularMessage(Client client, BaseMessage message);
    }
}
