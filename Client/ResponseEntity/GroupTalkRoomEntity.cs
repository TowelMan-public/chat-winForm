using System;

namespace chat_winForm.Client.ResponseEntity
{
    /// <summary>
    /// グループトークルームを取得するAPIのエンティティー
    /// </summary>
    class GroupTalkRoomEntity
    {
        public int TalkRoomId { get; set; }
        public String GroupName { get; set; }
        public int LastTalkIndex { get; set; }
        public Boolean IsEnabled { get; set; }
    }
}
