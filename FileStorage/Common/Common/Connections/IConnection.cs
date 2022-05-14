using Common.Messages.Base;

namespace Common.Connections
{
    public interface IConnection
    {
        void SendMessage(BaseMessage message);
        BaseMessage ReceiveMessage();
    }
}
