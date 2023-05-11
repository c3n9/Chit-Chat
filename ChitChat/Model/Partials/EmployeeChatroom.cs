using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChitChat.Model
{
    public partial class Chatroom
    {
        public string LastChatMessage
        {
            get
            {
                var message = this.ChatMessage.LastOrDefault();
                if (message == null)
                {
                    return string.Empty;
                }
                return message.Message;
            }
        }
    }
}
