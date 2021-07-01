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
        readonly static RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/desire/user";

        /// <summary>
        /// 友達追加申請リストを取得するAPI
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <returns>友達追加申請リスト</returns>
        static public List<DesireHaveUserResponse> GetDesireUserList(String oauthToken)
        {
            const String URL = ROOT_URL + "/gets";

            Dto dto = new Dto();

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<DesireHaveUserResponse>>(oauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を取得するAPi
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        /// <returns>友達追加申請</returns>
        static public DesireHaveUserResponse GetDesireUser(String oauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/get";

            Dto dto = new Dto
            {
                UserIdName = userIdName
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, DesireHaveUserResponse>(oauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を断るAPI
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void DeleteDesireUser(String oauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/insert";

            Dto dto = new Dto
            {
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を受けるAPI
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void JoinUser(String oauthToken, String userIdName)
        {
            const String URL = ROOT_URL + "/join";

            Dto dto = new Dto
            {
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
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
