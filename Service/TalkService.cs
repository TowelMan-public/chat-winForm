using chat_winForm.Client.Api;
using chat_winForm.Model;
using chat_winForm.Registry;
using System;
using System.Collections.Generic;

namespace chat_winForm.Service
{
    /// <summary>
    /// トークに関する処理を書くところろ
    /// </summary>
    static class TalkService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        /// <summary>
        /// 友達トークを送る
        /// </summary>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        /// <param name="contentText">トークの内容</param>
        public static void SendDialogueTalk(String haveUserIdName, String contentText)
        {
            DialogueTalkApi.InsertTalk(userCredentialsProvider.OauthToken, haveUserIdName, contentText);
        }

        /// <summary>
        /// グループトークを送る
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        /// <param name="contentText">トークの内容</param>
        public static void SendGroupTalk(int groupTalkRoomId, String contentText)
        {
            GroupTalkApi.InsertTalk(userCredentialsProvider.OauthToken, groupTalkRoomId, contentText);
        }

        /// <summary>
        /// 友達トークリストの取得
        /// </summary>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        /// <param name="startIndex">取得を開始するトークインデックス</param>
        /// <param name="mazSize">最大取得件数</param>
        /// <returns>友達トークリスト</returns>
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

        /// <summary>
        /// グループトークリストの取得
        /// </summary>
        /// <param name="GroupTalkRoomId">グループトークルームID</param>
        /// <param name="startIndex">取得を開始するトークインデックス</param>
        /// <param name="mazSize">最大取得件数</param>
        /// <returns></returns>
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

        /// <summary>
        /// 友達トークの削除
        /// </summary>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        public static void DeleteDialogueTalk(string haveUserIdName, int talkIndex)
        {
            DialogueTalkApi.DeleteTalk(userCredentialsProvider.OauthToken, haveUserIdName, talkIndex);
        }

        /// <summary>
        /// グループトークの削除
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        /// <param name="talkIndex">トークインデックス</param>
        public static void DeleteGroupTalk(int groupTalkRoomId, int talkIndex)
        {
            GroupTalkApi.DeleteTalk(userCredentialsProvider.OauthToken, groupTalkRoomId, talkIndex);
        }

        /// <summary>
        /// グループトークの更新
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        /// <param name="talkIndex">トークインデックス</param>
        /// <param name="contentText">トークの内容</param>
        public static void UpdateGroupTalk(int groupTalkRoomId, int talkIndex, string contentText)
        {
            GroupTalkApi.UpdateTalk(userCredentialsProvider.OauthToken, groupTalkRoomId, talkIndex, contentText);
        }

        /// <summary>
        /// 友達トークの更新
        /// </summary>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        /// <param name="contentText">トークの内容</param>
        public static void UpdateDialogueTalk(string haveUserIdName, int talkIndex, string contentText)
        {
            DialogueTalkApi.UpdateTalk(userCredentialsProvider.OauthToken, haveUserIdName, talkIndex, contentText);
        }
    }
}
