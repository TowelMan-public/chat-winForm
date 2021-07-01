using System;

namespace chat_winForm.Client.ResponseEntity
{
    /// <summary>
    /// トークを取得するAPIのレスポンスとして返すエンティティー
    /// </summary>
    class TalkResponse
    {
        public int TalkIndex;
        public String UserIdName;
        public String UserName;
        public String Content;
        public String TimestampString;
    }
}
