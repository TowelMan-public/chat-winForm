using chat_winForm.Client.ResponseEntity;
using System;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// ユーザー情報に関するAPIを呼び出すクラス
    /// </summary>
    static class UserApi
    {
        static readonly RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/user";

        /// <summary>
        /// ログインをするためのAPI
        /// </summary>
        /// <param name="userIdName">ユーザーID名</param>
        /// <param name="password">パスワード</param>
        /// <returns>認証用トークン</returns>
        public static String Login(String userIdName, String password)
        {
            const String URL = ROOT_URL + "/login";

            Dto dto = new Dto
            {
                UserIdName = userIdName,
                Password = password
            };

            return s_RestTemplate.PostHttpMethodForLogin(URL, dto);
        }

        /// <summary>
        /// ユーザー登録をするAPI
        /// </summary>
        /// <param name="userName">ユーザー名（ニックネーム）</param>
        /// <param name="userIdName">ユーザーID名</param>
        /// <param name="password">パスワード</param>
        public static void InsertUser(String userName, String userIdName, String password)
        {
            const String URL = ROOT_URL + "/insert";

            Dto dto = new Dto
            {
                UserName = userName,
                UserIdName = userIdName,
                Password = password
            };

            s_RestTemplate.PostHttpMethod(URL, dto);
        }

        /// <summary>
        /// ユーザー情報を取得する
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        /// <returns>ユーザー情報</returns>
        public static UserEntity GetUser(String OauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/get";

            Dto dto = new Dto
            {
                UserIdName = userIdName
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, UserEntity>(OauthToken, URL, dto);
        }

        /// <summary>
        /// ユーザーID名を変更する
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        public static void UpdateUserIdName(String OauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/update/id-name";

            Dto dto = new Dto
            {
                UserIdName = userIdName,
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// ユーザー名の変更
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="userName">ユーザー名</param>
        public static void UpdateUserName(String OauthToken, String userName)
        {
            const String URL = ROOT_URL + "/update/name";

            Dto dto = new Dto
            {
                UserName = userName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// パスワードの更新
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="password">パスワード</param>
        public static void UpdatePassword(String OauthToken, String password)
        {
            const String URL = ROOT_URL + "/update/password";

            Dto dto = new Dto
            {
                Password = password
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// 退会
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        public static void DeleteUser(String OauthToken)
        {
            const String URL = ROOT_URL + "/delete";

            Dto dto = new Dto();

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// ユーザー情報に関するapiのパラメターを送るためのDtoクラス
        /// </summary>
        public class Dto
        {
            public String UserName;
            public String UserIdName;
            public String Password;
        }
    }
}
