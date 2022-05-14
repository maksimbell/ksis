using Common.Messages.Base;
using Common.ObjectSerializer;
using System;
using System.Net;
using System.Net.Sockets;

namespace Common.Connections
{
    public class UdpConnection : SocketConnection
    {
        public UdpConnection(Socket socket, EndPoint endPoint, bool isLocal) : base(socket, endPoint)
        {
            if (isLocal)
            {
                Socket.Bind(EndPoint);
            }
        }

        public override BaseMessage ReceiveMessage()
        {
            byte[] msgBytes = new byte[maxMessageSizeBytes];
            EndPoint socketEndPoint = EndPoint;
            Socket.ReceiveFrom(msgBytes, ref socketEndPoint);
            return BinarySerializer.Deserialize<BaseMessage>(msgBytes);
        }

        public override void SendMessage(BaseMessage message)
        {
            Console.WriteLine(message.Type);
            Socket.SendTo(BinarySerializer.Serialize(message), EndPoint);
        }
    }
}
