using System;

namespace chat_winForm.Client.ResponseEntity
{
    /// <summary>
    /// グループ加入者リストを取得するAPIのレスポンスとして返すエンティティー
    /// </summary>
    class UserInGroupResponse
    {
        public int talkRoomId;
        public int lastTalkIndex;
        public String userIdName;
        public String userName;
    }
}
