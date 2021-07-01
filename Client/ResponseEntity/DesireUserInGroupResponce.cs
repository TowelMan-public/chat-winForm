using System;

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
