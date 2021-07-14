using chat_winForm.Client.Api;
using chat_winForm.Model;
using chat_winForm.Registry;
using System;
using System.Collections.Generic;

namespace chat_winForm.Service
{
    static class TalkService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        public static void SendDialogueTalk(String haveUserIdName, String contentText)
        {
            DialogueTalkApi.InsertTalk(userCredentialsProvider.OauthToken, haveUserIdName, contentText);
        }

        public static void SendGroupTalk(int groupTalkRoomId, String contentText)
        {
            GroupTalkApi.InsertTalk(userCredentialsProvider.OauthToken, groupTalkRoomId, contentText);
        }

        public static List<TalkModel> GetDialogueTalkList(String haveUserIdName, int startIndex, int mazSize)
        {
            List<TalkModel> talkModelList = new List<TalkModel>();
            List<Client.ResponseEntity.TalkResponse> talkEntityList = DialogueApi.GetDiarogueTalks(userCredentialsProvider.OauthToken, haveUserIdName, mazSize, startIndex);

            foreach (Client.ResponseEntity.TalkResponse talkEntity in talkEntityList)
            {
                talkModelList.Add(
                    new DialogueTalkModel(haveUserIdName, talkEntity.TalkIndex, talkEntity.UserName,
                        talkEntity.UserIdName == userCredentialsProvider.UserIdName, talkEntity.Content, talkEntity.TimestampString));
            }

            return talkModelList;
        }

        public static List<TalkModel> GetGroupTalkList(int GroupTalkRoomId, int startIndex, int mazSize)
        {
            List<TalkModel> talkModelList = new List<TalkModel>();
            List<Client.ResponseEntity.TalkResponse> talkEntityList = GroupApi.GetGroupTalks(userCredentialsProvider.OauthToken, GroupTalkRoomId, startIndex, mazSize);

            foreach (Client.ResponseEntity.TalkResponse talkEntity in talkEntityList)
            {
                talkModelList.Add(
                    new GroupTalkModel(GroupTalkRoomId, talkEntity.TalkIndex, talkEntity.UserName,
                        talkEntity.UserIdName == userCredentialsProvider.UserIdName, talkEntity.Content, talkEntity.TimestampString));
            }

            return talkModelList;
        }
    }
}
