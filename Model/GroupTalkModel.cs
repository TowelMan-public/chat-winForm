using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// グループトークのモデルクラス
    /// </summary>
    public class GroupTalkModel : TalkModel
    {
        /// <summary>
        /// グループトークルームID
        /// </summary>
        public int GroupTalkRoomId { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        /// <param name="talkIndex">トークインデックス</param>
        /// <param name="senderUserName">送信者のユーザー名</param>
        /// <param name="isMyTake">自分のトークかそうでないか</param>
        /// <param name="contentText">トークの内容</param>
        /// <param name="timeStamp">トークが送信された日時</param>
        public GroupTalkModel(int groupTalkRoomId, int talkIndex, String senderUserName, bool isMyTake, String contentText, String timeStamp)
            : base(talkIndex, senderUserName, isMyTake, contentText, timeStamp)
        {
            GroupTalkRoomId = groupTalkRoomId;
        }
    }
}
