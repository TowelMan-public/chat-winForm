using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_winForm.Client.ResponseEntity
{
    /// <summary>
    /// グループ加入申請リストを取得するAPIのレスポンスとして返すエンティティー
    /// </summary>
    class DesireUserInGroupResponce
    {
        public int TalkRoomId { get; set; }
        public int LastTalkIndex { get; set; }
        public String GroupName { get; set; }
    }
}
