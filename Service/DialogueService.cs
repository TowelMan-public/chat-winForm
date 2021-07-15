using chat_winForm.Client.Api;
using chat_winForm.Registry;
using System;

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

        internal static void AddUserInDialogue(string userIdName)
        {
            UserInDialogueApi.JnsertUserInDiarogue(userCredentialsProvider.OauthToken, userIdName);
        }
    }
}
