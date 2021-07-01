using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// グループ加入してほしい申請に関するAPIを呼び出すクラス
    /// </summary>
    class DesireGroupApi
    {
        static readonly RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/desire/group";

        /// <summary>
        /// グループに加入してほしい申請リストの取得
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <returns>グループに加入してほしい申請リスト</returns>
        static public List<DesireUserInGroupResponce> GetDesireUserList(String oauthToken)
        {
            const String URL = ROOT_URL + "/gets";

            Dto dto = new Dto();

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<DesireUserInGroupResponce>>(oauthToken, URL, dto);
        }

        /// <summary>
        /// グループに加入してほしい申請を取得する
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルーム</param>
        /// <returns>グループに加入してほしい申請</returns>
        static public DesireUserInGroupResponce GetDesireUser(String oauthToken, int talkRoomId)
        {
            const String URL = ROOT_URL + "/get";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, DesireUserInGroupResponce>(oauthToken, URL, dto);
        }

        /// <summary>
        /// グループ加入してほしい申請を断る
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルーム</param>
        static public void DeleteDesireGroup(String oauthToken, int talkRoomId)
        {
            const String URL = ROOT_URL + "/delete";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// グループ加入してほしい申請を受ける
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルーム</param>
        static public void JoinGroup(String oauthToken, int talkRoomId)
        {
            const String URL = ROOT_URL + "/join";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// 友達追加申請に関するAPIのパラメターを送るためのDtoクラス
        /// </summary>
        public class Dto
        {
            public int TalkRoomId { get; set; }
        }
    }
}
