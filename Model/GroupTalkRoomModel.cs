using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// グループトークルームのモデルクラス。
    /// </summary>
    public class GroupTalkRoomModel : TalkRoomModel
    {
        /// <summary>
        /// グループトークルームID
        /// </summary>
        public int GroupTalkRoomId { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トークルームの名前</param>
        /// <param name="myLastTalkIndex">ユーザーのラストトークインデックス</param>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        public GroupTalkRoomModel(String name, int lastTalkIndex, int groupTalkRoomId, int noticeCount)
            : base(name, lastTalkIndex, noticeCount)
        {
            GroupTalkRoomId = groupTalkRoomId;
        }
    }
}
