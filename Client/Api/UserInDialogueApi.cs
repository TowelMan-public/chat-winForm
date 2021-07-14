using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// ユーザーが持っている友達に関するAPIを呼び出すクラス
    /// </summary>
    class UserInDialogueApi
    {
        readonly static RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/diarogue/user";

        /// <summary>
        /// 友達リストの取得をするAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <returns>友達リスト</returns>
        static public List<HaveUserResponse> GetUserInDiarogueList(String OauthToken)
        {
            const String URL = ROOT_URL + "/gets";

            Dto dto = new Dto();

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<HaveUserResponse>>(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達を取得する
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        /// <returns></returns>
        static public HaveUserResponse GetUserInDiarogue(String OauthToken, String haveUserIdName)
        {
            const String URL = ROOT_URL + "/get";

            Dto dto = new Dto
            {
                UserIdName = haveUserIdName
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, HaveUserResponse>(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加をするAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        static public void JnsertUserInDiarogue(String OauthToken, String haveUserIdName)
        {
            const String URL = ROOT_URL + "/insert";

            Dto dto = new Dto
            {
                UserIdName = haveUserIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達を削除する
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        static public void DeleteUserInDiarogue(String OauthToken, String haveUserIdName)
        {
            const String URL = ROOT_URL + "/delete";

            Dto dto = new Dto
            {
                UserIdName = haveUserIdName
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
