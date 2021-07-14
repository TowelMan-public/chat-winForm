using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// グループ加入者に関するAPIを呼び出すクラス
    /// </summary>
    class UserInGroupApi
    {
        static readonly RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/group/user";

        /// <summary>
        /// グループにユーザーを加入させるAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void InsertUserInGroup(String OauthToken, int talkRoomId, String userIdName)
        {
            const String URL = ROOT_URL + "/insert";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId,
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// グループ加入者リストの取得するAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <returns>グループ加入者リスト</returns>
        static public List<UserInGroupResponse> GetUsersInGroup(String OauthToken, int talkRoomId)
        {
            const String URL = ROOT_URL + "/gets";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<UserInGroupResponse>>(OauthToken, URL, dto);
        }

        /// <summary>
        /// グループ加入者をグループから抜けさせる
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="userIdName">ユーザーID名</param>
        static public void DeleteUserInGroup(String OauthToken, int talkRoomId, String userIdName)
        {
            const String URL = ROOT_URL + "/delete";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId,
                UserIdName = userIdName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// グループから抜ける
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        static public void ExitGroup(String OauthToken, int talkRoomId)
        {
            const String URL = ROOT_URL + "/exit";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
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
