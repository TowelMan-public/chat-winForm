using chat_winForm.Client.Api;
using chat_winForm.Model;
using chat_winForm.Registry;
using System.Collections.Generic;

namespace chat_winForm.Service
{
    /// <summary>
    /// グループトークルームに関する処理を書くところ
    /// </summary>
    static class GroupService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        /// <summary>
        /// グループから脱退する
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        public static void BrockGroupTalkRoom(int groupTalkRoomId)
        {
            UserInGroupApi.ExitGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);
        }


        /// <summary>
        /// グループからの勧誘を断る
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        public static void BrockDesireGroupTalkRoom(int groupTalkRoomId)
        {
            DesireGroupApi.DeleteDesireGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);
        }

        /// <summary>
        /// グループを作成する
        /// </summary>
        /// <param name="groupName">グループ名</param>
        public static void MakeGroup(string groupName)
        {
            GroupApi.InsertGroup(userCredentialsProvider.OauthToken, groupName);
        }

        /// <summary>
        /// グループからの勧誘を受け入れる
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        public static void AcceptDesireGroupTalkRoom(int groupTalkRoomId)
        {
            DesireGroupApi.JoinGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);
        }

        /// <summary>
        /// グループ加入者リストを取得する
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        /// <returns>グループ加入者リスト</returns>
        public static List<UserInGroupModel> GetUserInGroupList(int groupTalkRoomId)
        {
            List<UserInGroupModel> modelLost = new List<UserInGroupModel>();
            List<Client.ResponseEntity.UserInGroupResponse> entityList = UserInGroupApi.GetUsersInGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);

            foreach (Client.ResponseEntity.UserInGroupResponse entity in entityList)
            {
                modelLost.Add(
                    new UserInGroupModel
                    {
                        GropuTalkRoomId = groupTalkRoomId,
                        UserIdName = entity.userIdName,
                        UserName = entity.userName,
                        isMe = userCredentialsProvider.UserIdName == entity.userIdName
                    });
            }

            return modelLost;
        }


        /// <summary>
        /// グループに加入しているユーザーを脱退させる
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        /// <param name="userIdName">ユーザーID名</param>
        public static void DeleteUserInGroup(int groupTalkRoomId, string userIdName)
        {
            UserInGroupApi.DeleteUserInGroup(userCredentialsProvider.OauthToken, groupTalkRoomId, userIdName);
        }

        /// <summary>
        /// グループを削除する
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        public static void DeleteGroup(int groupTalkRoomId)
        {
            GroupApi.DeleteGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);
        }

        /// <summary>
        /// グループ名を更新する
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        /// <param name="groupName">グループ名</param>
        public static void UpdateGroupName(int groupTalkRoomId, string groupName)
        {
            GroupApi.UpdateGroupName(userCredentialsProvider.OauthToken, groupTalkRoomId, groupName);
        }

        /// <summary>
        /// グループにユーザーを勧誘する
        /// </summary>
        /// <param name="groupTalkRoomId">グループトークルームID</param>
        /// <param name="userIdName">ユーザーID名</param>
        public static void InvitationUserInGroup(int groupTalkRoomId, string userIdName)
        {
            UserInGroupApi.InsertUserInGroup(userCredentialsProvider.OauthToken, groupTalkRoomId, userIdName);
        }
    }
}
