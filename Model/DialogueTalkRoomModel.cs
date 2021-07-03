using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// 友達トークルームのモデルクラス。
    /// </summary>
    public class DialogueTalkRoomModel : TalkRoomModel
    {
        /// <summary>
        /// 友達のユーザーID（UserIdName）
        /// </summary>
        public String HaveUserIdName { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トークルームの名前</param>
        /// <param name="myLastTalkIndex">ユーザーのラストトークインデックス</param>
        /// <param name="haveUserIdName">友達のユーザーID（UserIdName）</param>
        public DialogueTalkRoomModel(String name, int lastTalkIndex, String haveUserIdName, int noticeCount)
            : base(name, lastTalkIndex, noticeCount)
        {
            HaveUserIdName = haveUserIdName;
        }
    }
}
