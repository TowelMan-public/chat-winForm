using chat_winForm.Client.Api;
using chat_winForm.Model;
using chat_winForm.Registry;
using System.Collections.Generic;

namespace chat_winForm.Service
{
    /// <summary>
    /// トークルームに関する処理を書くところ
    /// </summary>
    static class TalkRoomService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        /// <summary>
        /// 友達トークルームリストを取得する
        /// </summary>
        /// <returns>友達トークルームリスト</returns>
        public static List<TalkRoomModel> GetDialogueTalkRoomModelList()
        {
            List<TalkRoomModel> modelList = new List<TalkRoomModel>();

            List<Client.ResponseEntity.HaveUserResponse> responseList = UserInDialogueApi.GetUserInDiarogueList(userCredentialsProvider.OauthToken);
            foreach (Client.ResponseEntity.HaveUserResponse response in responseList)
            {
                modelList.Add(
                    new DialogueTalkRoomModel(response.HaveUserName, response.MyLastTalkIndex, response.HaveUserIdName,
                    response.TalkLastTalkIndex - response.MyLastTalkIndex));
            }

            return modelList;
        }

        /// <summary>
        /// グループトークルームリストを取得する
        /// </summary>
        /// <returns>グループトークルームリスト</returns>
        public static List<TalkRoomModel> GetGroupTalkRoomModelList()
        {
            List<TalkRoomModel> modelList = new List<TalkRoomModel>();

            List<Client.ResponseEntity.GroupTalkRoomResponse> responseList = GroupApi.GetGroups(userCredentialsProvider.OauthToken);
            foreach (Client.ResponseEntity.GroupTalkRoomResponse response in responseList)
            {
                modelList.Add(
                    new GroupTalkRoomModel(response.GroupName, response.UserLastTalkIndex, response.TalkRoomId,
                    response.GroupLastTalkIndex - response.UserLastTalkIndex));
            }

            return modelList;
        }

        /// <summary>
        /// 友達追加申請者とのトークルームリストの取得
        /// </summary>
        /// <returns>友達追加申請者とのトークルームリスト</returns>
        public static List<TalkRoomModel> GetDesireDialogueTalkRoomModelList()
        {
            List<TalkRoomModel> modelList = new List<TalkRoomModel>();

            List<Client.ResponseEntity.DesireHaveUserResponse> responseList = DesireUserApi.GetDesireUserList(userCredentialsProvider.OauthToken);
            foreach (Client.ResponseEntity.DesireHaveUserResponse response in responseList)
            {
                modelList.Add(
                    new DesireDialogueTalkRoomModel(response.HaveUserName, response.LastTalkIndex, response.HaveUserIdName));
            }

            return modelList;
        }

        /// <summary>
        /// 勧誘されているグループトークルームリストの取得
        /// </summary>
        /// <returns>勧誘されているグループトークルームリスト</returns>
        public static List<TalkRoomModel> GetDesireGroupTalkRoomModelList()
        {
            List<TalkRoomModel> modelList = new List<TalkRoomModel>();

            List<Client.ResponseEntity.DesireUserInGroupResponce> responseList = DesireGroupApi.GetDesireUserList(userCredentialsProvider.OauthToken);
            foreach (Client.ResponseEntity.DesireUserInGroupResponce response in responseList)
            {
                modelList.Add(
                    new DesireGroupTalkRoomModel(response.GroupName, response.LastTalkIndex, response.TalkRoomId));
            }

            return modelList;
        }
    }
}
