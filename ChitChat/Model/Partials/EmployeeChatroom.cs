using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChitChat.Model
{
    public partial class  EmployeeChatroom
    {
       public string LastChatMessage
        {
            get
            {
                int g = 0;
                int k = 0;
                string result = "";
                var message = Chatroom.ChatMessage.ToList();
                foreach(var m in message)
                {
                    g++;
                }
                foreach(var m in message)
                {
                    k++;
                    if (k == g)
                        result = m.Message;
                }
                return result;
            }
        }
    }
}
