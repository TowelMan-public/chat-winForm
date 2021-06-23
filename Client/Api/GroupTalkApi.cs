using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="talkContentText">トークテキスト</param>
        static public void InsertTalk(String outhToken, int talkRoomId, String talkContentText)
        {
            const String URL = ROOT_URL + "/insert";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId,
                TalkContentText = talkContentText
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// グループトークの取得をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="talkIndex"> トークインデクス</param>
        /// <returns>グループトーク</returns>
        static public TalkResponse GetTalk(String outhToken, int talkRoomId, int talkIndex)
        {
            const String URL = ROOT_URL + "/get";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId,
                TalkIndex = talkIndex
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, TalkResponse>(outhToken, URL, dto);
        }

        /// <summary>
        /// グループトークの更新をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="talkIndex"> トークインデクス</param>
        /// <param name="talkContentText">トークテキスト</param>
        static public void UpdateTalk(String outhToken, int talkRoomId, int talkIndex, String talkContentText)
        {
            const String URL = ROOT_URL + "/update";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId,
                TalkIndex = talkIndex,
                TalkContentText = talkContentText
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// グループトークの作成をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="talkIndex"> トークインデクス</param>
        static public void DeleteTalk(String outhToken, int talkRoomId, int talkIndex)
        {
            const String URL = ROOT_URL + "/delete";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId,
                TalkIndex = talkIndex
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
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
