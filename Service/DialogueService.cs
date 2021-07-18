using chat_winForm.Client.Api;
using chat_winForm.Registry;

namespace chat_winForm.Service
{
    /// <summary>
    /// 友達トークに関する処理を書くところ
    /// </summary>
    static class DialogueService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        /// <summary>
        /// 友達をブロックする
        /// </summary>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        public static void BrockDialogueTalkRoom(string haveUserIdName)
        {
            UserInDialogueApi.DeleteUserInDiarogue(userCredentialsProvider.OauthToken, haveUserIdName);
        }

        /// <summary>
        /// 友達追加申請を断る
        /// </summary>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        public static void BrockDesireDialogueTalkRoom(string haveUserIdName)
        {
            DesireUserApi.DeleteDesireUser(userCredentialsProvider.OauthToken, haveUserIdName);
        }

        /// <summary>
        /// 友達追加申請を受け入れる
        /// </summary>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        public static void AcceptDesireDialogueTalkRoom(string haveUserIdName)
        {
            DesireUserApi.JoinUser(userCredentialsProvider.OauthToken, haveUserIdName);
        }

        /// <summary>
        /// 友達を追加する
        /// </summary>
        /// <param name="userIdName">ユーザーID名</param>
        internal static void AddUserInDialogue(string userIdName)
        {
            UserInDialogueApi.JnsertUserInDiarogue(userCredentialsProvider.OauthToken, userIdName);
        }
    }
}
