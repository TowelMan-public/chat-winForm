using chat_winForm.Client.Api;
using chat_winForm.Model;
using chat_winForm.Registry;
using System;
using System.Collections.Generic;

namespace chat_winForm.Service
{
    static class GroupService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        static public void BrockGroupTalkRoom(int groupTalkRoomId)
        {
            UserInGroupApi.ExitGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);
        }

        static public void BrockDesireGroupTalkRoom(int groupTalkRoomId)
        {
            DesireGroupApi.DeleteDesireGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);
        }

        static public void AcceptDesireGroupTalkRoom(int groupTalkRoomId)
        {
            DesireGroupApi.JoinGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);
        }

        static public List<UserInGroupModel> GetUserInGroupList(int groupTalkRoomId)
        {
            var modelLost = new List<UserInGroupModel> ();
            var entityList = UserInGroupApi.GetUsersInGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);

            foreach(var entity in entityList)
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

        static public void DeleteUserInGroup(int groupTalkRoomId, string userIdName)
        {
            UserInGroupApi.DeleteUserInGroup(userCredentialsProvider.OauthToken, groupTalkRoomId, userIdName);
        }

        static public void DeleteGroup(int groupTalkRoomId)
        {
            GroupApi.DeleteGroup(userCredentialsProvider.OauthToken, groupTalkRoomId);
        }

        static public void UpdateGroupName(int groupTalkRoomId, string groupName)
        {
            GroupApi.UpdateGroupName(userCredentialsProvider.OauthToken, groupTalkRoomId, groupName);
        }

        static public void InvitationUserInGroup(int groupTalkRoomId, string userIdName)
        {
            UserInGroupApi.InsertUserInGroup(userCredentialsProvider.OauthToken, groupTalkRoomId, userIdName);
        }
    }
}
