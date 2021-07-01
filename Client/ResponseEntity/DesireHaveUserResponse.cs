using System;

namespace chat_winForm.Client.ResponseEntity
{
    /// <summary>
    /// 友達追加申請リストを取得するAPIのレスポンスとして返すエンティティー
    /// </summary>
    class DesireHaveUserResponse
    {
        public String HaveUserIdName { get; set; }
        public String HaveUserName { get; set; }
        public int TalkRoomId { get; set; }
        public int LastTalkIndex { get; set; }
    }
}
