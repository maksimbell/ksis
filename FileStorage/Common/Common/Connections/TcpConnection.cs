using Common.Messages.Base;
using Common.ObjectSerializer;
using System;
using System.Net;
using System.Net.Sockets;

namespace Common.Connections
{
    public class TcpConnection : SocketConnection
    {
        private const string MSG_SERVER_LISTENING = "Server is listening...";
        private const string MSG_WAITING_FOR_CONNECTION = "Waiting for next connection on: {0}";
        private const string MSG_CLIENT_SOCKET_ACCEPTED = "Accepted new client socket!";
        private const int MAX_QUEUE_SIZE = 10;

        public TcpConnection(Socket socket, EndPoint endPoint, bool isLocal) : base(socket, endPoint)
        {
            if (isLocal)
            {
                Socket.Bind(EndPoint);
            }
        }
        public TcpConnection(Socket Socket) : base(Socket, null) { }

        public void EstablishConnection()
        {
            Socket.Listen(MAX_QUEUE_SIZE);
            Console.WriteLine(MSG_SERVER_LISTENING);
        }

        public void Connect()
        {
            Socket.Connect(EndPoint);
        }

        public override void SendMessage(BaseMessage message)
        {
            byte[] cmdBytes = new byte[maxMessageSizeBytes];
            cmdBytes = BinarySerializer.Serialize(message);
            Socket.Send(cmdBytes);
        }

        public override BaseMessage ReceiveMessage()
        {
            byte[] cmdBytes = new byte[maxMessageSizeBytes];
            Socket.Receive(cmdBytes);
            return BinarySerializer.Deserialize<BaseMessage>(cmdBytes);
        }

        public TcpConnection AcceptNewClientConnection()
        {
            Console.WriteLine(MSG_WAITING_FOR_CONNECTION, EndPoint);
            Socket clientHandler = Socket.Accept();
            Console.WriteLine(MSG_CLIENT_SOCKET_ACCEPTED);

            return new TcpConnection(clientHandler);
        }
    }
}
