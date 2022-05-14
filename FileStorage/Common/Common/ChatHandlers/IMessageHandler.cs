using Common.Messages.Base;

namespace Common.ChatHandlers
{
    public interface IMessageHandler
    {
        void HandleMessages(object obj);
        void HandleParticularMessage(BaseMessage message);
    }
}
