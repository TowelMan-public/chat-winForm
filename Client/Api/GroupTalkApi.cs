using chat_winForm.Client.ResponseEntity;
using System;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// グループトーク単体に関するAPIを呼び出すクラス
    /// </summary>
    class GroupTalkApi
    {
        readonly static RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/group/talk";

        /// <summary>
        /// グループトークの作成をするAPI
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="talkContentText">トークテキスト</param>
        static public void InsertTalk(String oauthToken, int talkRoomId, String talkContentText)
        {
            const String URL = ROOT_URL + "/insert";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId,
                TalkContentText = talkContentText
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// グループトークの取得をするAPI
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="talkIndex"> トークインデクス</param>
        /// <returns>グループトーク</returns>
        static public TalkResponse GetTalk(String oauthToken, int talkRoomId, int talkIndex)
        {
            const String URL = ROOT_URL + "/get";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId,
                TalkIndex = talkIndex
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, TalkResponse>(oauthToken, URL, dto);
        }

        /// <summary>
        /// グループトークの更新をするAPI
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="talkIndex"> トークインデクス</param>
        /// <param name="talkContentText">トークテキスト</param>
        static public void UpdateTalk(String oauthToken, int talkRoomId, int talkIndex, String talkContentText)
        {
            const String URL = ROOT_URL + "/update";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId,
                TalkIndex = talkIndex,
                TalkContentText = talkContentText
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// グループトークの作成をするAPI
        /// </summary>
        /// <param name="oauthToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="talkIndex"> トークインデクス</param>
        static public void DeleteTalk(String oauthToken, int talkRoomId, int talkIndex)
        {
            const String URL = ROOT_URL + "/delete";

            Dto dto = new Dto
            {
                TalkRoomId = talkRoomId,
                TalkIndex = talkIndex
            };

            s_RestTemplate.PostHttpMethodWhenLogined(oauthToken, URL, dto);
        }

        /// <summary>
        /// グループトーク単体に関するAPIのパラメターを送るためのDtoクラス
        /// </summary>
        public class Dto
        {
            public int TalkRoomId { get; set; }
            public String TalkContentText { get; set; }
            public int TalkIndex { get; set; }
        }
    }
}
