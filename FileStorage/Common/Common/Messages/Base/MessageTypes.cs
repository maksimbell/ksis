using System;

namespace Common.Messages.Base
{
    [Serializable()]
    public enum MessageTypes
    {
        USER_SIGN_IN,
        USER_LOG_OUT,
        USER_MESSAGE,
        USER_UPDATED_CHAT,
        USER_UPDATE_ALL_CHATS,
        USER_CREATE_CHAT,
        USER_UPDATE_CHAT_LIST,

        UDP_CLIENT_INFO,
        UDP_SERVER_INFO,
    }
}
