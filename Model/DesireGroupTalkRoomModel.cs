using System;

namespace chat_winForm.Model
{
    // <summary>
    /// 招待されているグループトークルームのモデルクラス。
    /// </summary>
    class DesireGroupTalkRoomModel : TalkRoomModel
    {
        /// <summary>
        /// グループトークルームID
        /// </summary>
        public int GroupTalkRoomId { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トークルームの名前</param>
        /// <param name="myLastTalkIndex">ラストトークインデックス</param>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        public DesireGroupTalkRoomModel(String name, int lastTalkIndex, int groupTalkRoomId)
            : base(name, lastTalkIndex, 0)
        {
            GroupTalkRoomId = groupTalkRoomId;
        }
    }
}
