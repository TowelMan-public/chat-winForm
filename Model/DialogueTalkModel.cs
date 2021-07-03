using System;

namespace chat_winForm.Model
{
    public class DialogueTalkModel : TalkModel
    {
        public String HaveUserIdName { get; set; }

        public DialogueTalkModel(String haveUserIdName, int talkIndex, String senderUserName, bool isMyTake, String contentText, String timeStamp)
            : base(talkIndex, senderUserName, isMyTake, contentText, timeStamp)
        {
            HaveUserIdName = haveUserIdName;
        }
    }
}
