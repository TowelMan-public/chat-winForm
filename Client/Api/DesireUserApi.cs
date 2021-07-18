using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// 友達追加申請に関するAPIを呼び出すクラス
    /// </summary>
    class DesireUserApi
    {
        static readonly RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/desire/user";

        /// <summary>
        /// 友達追加申請リストを取得するAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <returns>友達追加申請リスト</returns>
        public static List<DesireHaveUserResponse> GetDesireUserList(String OauthToken)
        {
            const String URL = ROOT_URL + "/gets";

            Dto dto = new Dto();

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<DesireHaveUserResponse>>(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を取得するAPi
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        /// <returns>友達追加申請</returns>
        public static DesireHaveUserResponse GetDesireUser(String OauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/get";

            Dto dto = new Dto
            {
                UserIdName = userIdName
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, DesireHaveUserResponse>(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を断るAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        public static void DeleteDesireUser(String OauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/delete";

            Dto dto = new Dto
            {
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を受けるAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        public static void JoinUser(String OauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/join";

            Dto dto = new Dto
            {
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請に関するAPIのパラメターを送るためのDtoクラス
        /// </summary>
        public class Dto
        {
            public String UserIdName { get; set; }
        }
    }
}
