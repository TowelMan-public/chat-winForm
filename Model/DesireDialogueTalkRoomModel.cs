using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// 追加申請が出てる友達トークルームのモデルクラス。
    /// </summary>
    class DesireDialogueTalkRoomModel : TalkRoomModel
    {
        /// <summary>
        /// 友達のユーザーID（UserIdName）
        /// </summary>
        public String HaveUserIdName { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トークルームの名前</param>
        /// <param name="myLastTalkIndex">ラストトークインデックス</param>
        /// <param name="haveUserIdName">友達のユーザーID（UserIdName）</param>
        public DesireDialogueTalkRoomModel(String name, int lastTalkIndex, String haveUserIdName)
            : base(name, lastTalkIndex, 0)
        {
            HaveUserIdName = haveUserIdName;
        }
    }
}
