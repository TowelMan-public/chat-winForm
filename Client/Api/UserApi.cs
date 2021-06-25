using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// ユーザー情報に関するAPIを呼び出すクラス
    /// </summary>
    static class UserApi
    {
        static RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/user";

        /// <summary>
        /// ログインをするためのAPI
        /// </summary>
        /// <param name="userIdName">ユーザーID名</param>
        /// <param name="password">パスワード</param>
        /// <returns>認証用トークン</returns>
        static public String Login(String userIdName, String password)
        {
            const String URL = ROOT_URL + "/login";

            var dto = new Dto
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
        static public void InsertUser(String userName, String userIdName, String password)
        {
            const String URL = ROOT_URL + "/insert";

            var dto = new Dto
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
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        /// <returns>ユーザー情報</returns>
        static public UserEntity GetUser(String oauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/get";

            var dto = new Dto
            {
                UserIdName = userIdName
            };

            return  s_RestTemplate.GetHttpMethodWhenLogined<Dto,UserEntity>(oauthToken, URL, dto);
        }

        /// <summary>
        /// ユーザーID名を変更する
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void UpdateUserIdName(String oauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/update/id-name";

            var dto = new Dto
            {
                UserIdName = userIdName,
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// ユーザー名の変更
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="userName">ユーザー名</param>
        static public void UpdateUserName(String oauthToken, String userName)
        {
            const String URL = ROOT_URL + "/update/name";

            var dto = new Dto
            {
                UserName = userName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// パスワードの更新
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="password">パスワード</param>
        static public void UpdatePassword(String oauthToken, String password)
        {
            const String URL = ROOT_URL + "/update/password";

            var dto = new Dto
            {
                Password = password
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// 退会
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        static public void DeleteUser(String oauthToken)
        {
            const String URL = ROOT_URL + "/delete";

            var dto = new Dto();

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
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
