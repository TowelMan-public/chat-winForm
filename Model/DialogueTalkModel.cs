using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// 友達トーク
    /// </summary>
    public class DialogueTalkModel : TalkModel
    {
        /// <summary>
        /// 友達のユーザーID名
        /// </summary>
        public String HaveUserIdName { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="HaveUserIdName">友達のユーザーID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        /// <param name="senderUserName">送信者のユーザー名</param>
        /// <param name="isMyTake">自分のトークかそうでないか</param>
        /// <param name="contentText">トークの内容</param>
        /// <param name="timeStamp">トークが送信された日時</param>
        public DialogueTalkModel(String haveUserIdName, int talkIndex, String senderUserName, bool isMyTake, String contentText, String timeStamp)
            : base(talkIndex, senderUserName, isMyTake, contentText, timeStamp)
        {
            HaveUserIdName = haveUserIdName;
        }
    }
}
