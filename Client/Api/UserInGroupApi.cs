using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// グループ加入者に関するAPIを呼び出すクラス
    /// </summary>
    class UserInGroupApi
    {
        static RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/group/user";

        /// <summary>
        /// グループにユーザーを加入させるAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void InsertUserInGroup(String outhToken, int talkRoomId, String userIdName)
        {
            const String URL = ROOT_URL + "/insert";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId,
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// グループ加入者リストの取得するAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <returns>グループ加入者リスト</returns>
        static public List<UserInGroupResponse> GetUsersInGroup(String outhToken, int talkRoomId)
        {
            const String URL = ROOT_URL + "/gets";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<UserInGroupResponse>>(outhToken, URL, dto);
        }

        /// <summary>
        /// グループ加入者をグループから抜けさせる
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void DeleteUserInGroup(String outhToken, int talkRoomId, String userIdName)
        {
            const String URL = ROOT_URL + "/delete";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId,
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// グループから抜ける
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        static public void ExitGroup(String outhToken, int talkRoomId)
        {
            const String URL = ROOT_URL + "/exit";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// グループ加入者に関するAPIのパラメターを送るためのDtoクラス
        /// </summary>
        public class Dto
        {
            public int TalkRoomId { get; set; }
            public String UserIdName { get; set; }
        }
    }
}
