using chat_winForm.Client.ResponseEntity;
using System;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// 友達トーク単体に関するAPIを呼び出すクラス
    /// </summary>
    class DialogueTalkApi
    {
        readonly static RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/dialogue/talk";

        /// <summary>
        /// 友達トークの作成をするAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達ユーザーのID名</param>
        /// <param name="talkContentText">トークテキスト</param>
        static public void InsertTalk(String OauthToken, String haveUserIdName, String talkContentText)
        {
            const String URL = ROOT_URL + "/insert";

            Dto dto = new Dto
            {
                HaveUserIdName = haveUserIdName,
                TalkContentText = talkContentText
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達トークの取得をするAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達ユーザーのID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        /// <returns>友達トーク</returns>
        static public TalkResponse GetTalk(String OauthToken, String haveUserIdName, int talkIndex)
        {
            const String URL = ROOT_URL + "/get";

            Dto dto = new Dto
            {
                HaveUserIdName = haveUserIdName,
                TalkIndex = talkIndex
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, TalkResponse>(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達トークの更新をするAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達ユーザーのID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        /// <param name="talkContentText">トークテキスト</param>
        static public void UpdateTalk(String OauthToken, String haveUserIdName, int talkIndex, String talkContentText)
        {
            const String URL = ROOT_URL + "/update";

            Dto dto = new Dto
            {
                HaveUserIdName = haveUserIdName,
                TalkIndex = talkIndex,
                TalkContentText = talkContentText
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達トークの削除をするAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達ユーザーのID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        static public void DeleteTalk(String OauthToken, String haveUserIdName, int talkIndex)
        {
            const String URL = ROOT_URL + "/delete";

            Dto dto = new Dto
            {
                HaveUserIdName = haveUserIdName,
                TalkIndex = talkIndex
            };

            s_RestTemplate.PostHttpMethodWhenLogined(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達トーク単体に関するAPIのパラメターを送るためのDtoクラス
        /// </summary>
        public class Dto
        {
            public String HaveUserIdName { get; set; }
            public String TalkContentText { get; set; }
            public int TalkIndex { get; set; }
        }
    }

}
