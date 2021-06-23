using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <param name="outhToken">認証用トークン</param>
        /// <returns>友達リスト</returns>
        static public List<HaveUserResponse> GetUserInDiarogueList(String outhToken)
        {
            const String URL = ROOT_URL + "/gets";

            var dto = new Dto();

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<HaveUserResponse>>(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達を取得する
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        /// <returns></returns>
        static public HaveUserResponse GetUserInDiarogue(String outhToken, String haveUserIdName)
        {
            const String URL = ROOT_URL + "/get";

            var dto = new Dto
            {
                UserIdName = haveUserIdName
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, HaveUserResponse>(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達追加をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        static public void JnsertUserInDiarogue(String outhToken, String haveUserIdName)
        {
            const String URL = ROOT_URL + "/insert";

            var dto = new Dto
            {
                UserIdName = haveUserIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達を削除する
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        static public void DeleteUserInDiarogue(String outhToken, String haveUserIdName)
        {
            const String URL = ROOT_URL + "/delete";

            var dto = new Dto
            {
                UserIdName = haveUserIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
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
