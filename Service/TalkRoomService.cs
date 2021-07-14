using chat_winForm.Client.Api;
using chat_winForm.Model;
using chat_winForm.Registry;
using System.Collections.Generic;

namespace chat_winForm.Service
{
    static class TalkRoomService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        static public List<TalkRoomModel> GetDialogueTalkRoomModelList()
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

        static public List<TalkRoomModel> GetGroupTalkRoomModelList()
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

        static public List<TalkRoomModel> GetDesireDialogueTalkRoomModelList()
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

        static public List<TalkRoomModel> GetDesireGroupTalkRoomModelList()
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
