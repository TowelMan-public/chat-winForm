using chat_winForm.Client.Api;
using chat_winForm.Model;
using chat_winForm.Registry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_winForm.Service
{
    static class TalkRoomService
    {
        private static UserCredentialsProvider userCredentialsProvider;

        static public List<TalkRoomModel> GetDialogueTalkRoomModelList()
        {
            var modelList = new List<TalkRoomModel>();

            var responseList = UserInDialogueApi.GetUserInDiarogueList(userCredentialsProvider.oauthToken);
            foreach(var response in responseList)
            {
                modelList.Add(
                    new DialogueTalkRoomModel(response.HaveUserName, response.MyLastTalkIndex, response.HaveUserIdName,
                    response.TalkLastTalkIndex - response.MyLastTalkIndex));
            }

            return modelList;
        }

        static public List<TalkRoomModel> GetGroupTalkRoomModelList()
        {
            var modelList = new List<TalkRoomModel>();

            var responseList = GroupApi.GetGroups(userCredentialsProvider.oauthToken);
            foreach (var response in responseList)
            {
                modelList.Add(
                    new GroupTalkRoomModel(response.GroupName, response.UserLastTalkIndex, response.TalkRoomId,
                    response.GroupLastTalkIndex - response.UserLastTalkIndex));
            }

            return modelList;
        }

        static public List<TalkRoomModel> GetDesireDialogueTalkRoomModelList()
        {
            var modelList = new List<TalkRoomModel>();

            var responseList = DesireUserApi.GetDesireUserList(userCredentialsProvider.oauthToken);
            foreach (var response in responseList)
            {
                modelList.Add(
                    new DesireDialogueTalkRoomModel(response.HaveUserName, response.LastTalkIndex, response.HaveUserIdName));
            }

            return modelList;
        }

        static public List<TalkRoomModel> GetDesireGroupTalkRoomModelList()
        {
            var modelList = new List<TalkRoomModel>();

            var responseList = DesireGroupApi.GetDesireUserList(userCredentialsProvider.oauthToken);
            foreach (var response in responseList)
            {
                modelList.Add(
                    new DesireGroupTalkRoomModel(response.GroupName, response.LastTalkIndex, response.TalkRoomId));
            }

            return modelList;
        }
    }
}
