using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <param name="outhToken">認証用トークン</param>
        /// <returns>友達追加申請リスト</returns>
        static public List<DesireHaveUserResponse> GetDesireUserList(String outhToken)
        {
            const String URL = ROOT_URL + "/gets";

            var dto = new Dto();

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<DesireHaveUserResponse>>(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を取得するAPi
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        /// <returns>友達追加申請</returns>
        static public DesireHaveUserResponse GetDesireUser(String outhToken, String userIdName)
        {
            const String URL = ROOT_URL + "/get";

            var dto = new Dto
            {
                UserIdName = userIdName
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, DesireHaveUserResponse>(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を断るAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void DeleteDesireUser(String outhToken, String userIdName)
        {
            const String URL = ROOT_URL + "/insert";

            var dto = new Dto
            {
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請を受けるAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void JoinUser(String outhToken, String userIdName)
        {
            const String URL = ROOT_URL + "/join";

            var dto = new Dto
            {
                UserIdName = userIdName
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
