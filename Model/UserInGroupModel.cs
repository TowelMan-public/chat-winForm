using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_winForm.Model
{
    class UserInGroupModel
    {
        public int GropuTalkRoomId { get; set; }
        public String UserIdName { get; set; }
        public String UserName { get; set; }
        public bool isMe { get; set;}
    }
}
