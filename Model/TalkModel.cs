using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// トークのモデルクラス。
    /// 実際には継承して使う
    /// </summary>
    public class TalkModel
    {
        /// <summary>
        /// トークインデックス
        /// </summary>
        public int TalkIndex { get; set; }

        /// <summary>
        /// 送信者のユーザー名
        /// </summary>
        public String SenderUserName { get; set; }

        /// <summary>
        /// 自分のトークかそうでないか。自分のトークならtrue、違えばfalse
        /// </summary>
        public bool IsMyTake { get; set; }

        /// <summary>
        /// トークの内容
        /// </summary>
        public String ContentText { get; set; }

        /// <summary>
        /// トークが送信された日時
        /// </summary>
        public String TimeStamp { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="talkIndex">トークインデックス</param>
        /// <param name="senderUserName">トークの送信者のユーザー名</param>
        /// <param name="isMyTake">トークの送信者が自分であるかそうでないか</param>
        /// <param name="contentText">トークの内容</param>
        /// <param name="timeStamp">トークが送信された日時</param>
        public TalkModel(int talkIndex, String senderUserName, bool isMyTake, String contentText, String timeStamp)
        {
            TalkIndex = talkIndex;
            SenderUserName = senderUserName;
            IsMyTake = isMyTake;
            ContentText = contentText;
            TimeStamp = timeStamp;
        }
    }
}
