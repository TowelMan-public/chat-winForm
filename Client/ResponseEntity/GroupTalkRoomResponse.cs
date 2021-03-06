using System;

namespace chat_winForm.Client.ResponseEntity
{
    /// <summary>
    /// グループを取得するAPIのレスポンスとして返すエンティティー
    /// </summary>
    class GroupTalkRoomResponse
    {
        public int TalkRoomId { get; set; }
        public String GroupName { get; set; }
        public int GroupLastTalkIndex { get; set; }
        public int UserLastTalkIndex { get; set; }
    }
}
