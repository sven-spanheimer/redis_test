using System;

namespace Redis.Client.Classes
{
    [Serializable]
    class ChatMessage
    {

        public string Nickname { get; set; }
        public string Message { get; set; }

        public ChatMessage(string message, string nickname)
        {
            Message = message;
            Nickname = nickname;
        }

    }
}
