using chat_winForm.Client.Api;
using chat_winForm.Registry;

namespace chat_winForm.Service
{
    static class DialogueService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        static public void BrockDialogueTalkRoom(string haveUserIdName)
        {
            UserInDialogueApi.DeleteUserInDiarogue(userCredentialsProvider.OauthToken, haveUserIdName);
        }

        static public void BrockDesireDialogueTalkRoom(string haveUserIdName)
        {
            DesireUserApi.DeleteDesireUser(userCredentialsProvider.OauthToken, haveUserIdName);
        }

        static public void AcceptDesireDialogueTalkRoom(string haveUserIdName)
        {
            DesireUserApi.JoinUser(userCredentialsProvider.OauthToken, haveUserIdName);
        }
    }
}
