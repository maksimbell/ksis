using Common.Connections;
using Common.Messages.Base;

namespace Common.Entities
{
    public class Client
    {
        public string UserId { get; private set; }
        private TcpConnection Connection { get; }

        public Client(TcpConnection сonnection)
        {
            Connection = сonnection;
        }

        public void SendMessage(BaseMessage message)
        {
            Connection.SendMessage(message);
        }

        public BaseMessage ReceiveMessage()
        {
            return Connection.ReceiveMessage();
        }

        public void InitializeUser(string userId)
        {
            UserId = userId;
        }

        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
