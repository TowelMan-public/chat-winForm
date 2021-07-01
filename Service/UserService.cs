using chat_winForm.Client.Api;
using System;

namespace chat_winForm.Service
{
    /// <summary>
    /// ユーザーに関する処理を書くところ
    /// </summary>
    static class UserService
    {
        /// <summary>
        /// ログインする（認証用トークンの取得）
        /// </summary>
        /// <param name="userIdName">ユーザーID</param>
        /// <param name="password">パスワード</param>
        /// <returns></returns>
        static public String Login(String userIdName, String password)
        {
            return UserApi.Login(userIdName, password);
        }

        /// <summary>
        /// ユーザーの登録
        /// </summary>
        /// <param name="userIdName">ユーザーID</param>
        /// <param name="userName">ニックネーム</param>
        /// <param name="password">パスワード</param>
        static public void InsertUser(string userIdName, string userName, string password)
        {
            UserApi.InsertUser(userName, userIdName, password);
        }
    }
}
