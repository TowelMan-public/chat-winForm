using System;

namespace chat_winForm.Model
{
    public class GroupTalkModel : TalkModel
    {
        public int GroupTalkRoomId { get; set; }

        public GroupTalkModel(int groupTalkRoomId, int talkIndex, String senderUserName, bool isMyTake, String contentText, String timeStamp)
            : base(talkIndex, senderUserName, isMyTake, contentText, timeStamp)
        {
            GroupTalkRoomId = groupTalkRoomId;
        }
    }
}
