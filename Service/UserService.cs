﻿using chat_winForm.Client.Api;
using chat_winForm.Registry;
using System;

namespace chat_winForm.Service
{
    /// <summary>
    /// ユーザーに関する処理を書くところ
    /// </summary>
    static class UserService
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        /// <summary>
        /// ログインする（認証用トークンの取得）
        /// </summary>
        /// <param name="userIdName">ユーザーID</param>
        /// <param name="password">パスワード</param>
        /// <returns></returns>
        public static String Login(String userIdName, String password)
        {
            return UserApi.Login(userIdName, password);
        }

        public static void Exit()
        {
            UserApi.DeleteUser(userCredentialsProvider.OauthToken);
        }

        /// <summary>
        /// ユーザーの登録
        /// </summary>
        /// <param name="userIdName">ユーザーID</param>
        /// <param name="userName">ニックネーム</param>
        /// <param name="password">パスワード</param>
        public static void InsertUser(string userIdName, string userName, string password)
        {
            UserApi.InsertUser(userName, userIdName, password);
        }

        public static void UpdateUserName(string userName)
        {
            UserApi.UpdateUserName(userCredentialsProvider.OauthToken, userName);
        }

        public static String GetMyUserName()
        {
            return UserApi.GetUser(userCredentialsProvider.OauthToken, userCredentialsProvider.UserIdName).UserName;
        }

        public static void UpdateUserIdName(string userIdName)
        {
            UserApi.UpdateUserIdName(userCredentialsProvider.OauthToken, userIdName);
        }

        public static void UpdatePassword(string password)
        {
            UserApi.UpdatePassword(userCredentialsProvider.OauthToken, password);
        }
    }
}
