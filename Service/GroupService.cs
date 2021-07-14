using chat_winForm.Client.Api;
using chat_winForm.Registry;

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
    }
}
