using System;

namespace chat_winForm.Client.ResponseEntity
{
    /// <summary>
    /// 友達リストを取得するAPIのレスポンスとして返すエンティティー
    /// </summary>
    class HaveUserResponse
    {
        public String HaveUserIdName { get; set; }
        public String HaveUserName { get; set; }
        public int TalkRoomId { get; set; }
        public int TalkLastTalkIndex { get; set; }
        public int MyLastTalkIndex { get; set; }
    }
}
