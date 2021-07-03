using System;

namespace chat_winForm.Model
{
    public class TalkModel
    {
        public int TalkIndex { get; set; }
        public String SenderUserName { get; set; }
        public bool IsMyTake { get; set; }
        public String ContentText { get; set; }
        public String TimeStamp { get; set; }

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
