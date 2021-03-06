using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// 友達トークに関するAPIを呼び出すクラス
    /// </summary>
    class DialogueApi
    {
        static readonly RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/diarogue";

        /// <summary>
        /// 友達トークリストの取得をするAPI
        /// </summary>
        /// <param name="OauthToken">認証用トークン認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        /// <param name="maxSize">最大取得件数</param>
        /// <param name="startIndex">取得開始トークインデックス</param>
        /// <returns>友達トークリスト</returns>
        public static List<TalkResponse> GetDiarogueTalks(String OauthToken, String userIdName, int maxSize, int startIndex)
        {
            const String URL = ROOT_URL + "/gets/talks";

            Dto dto = new Dto
            {
                UserIdName = userIdName,
                MaxSize = maxSize,
                StartIndex = startIndex
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<TalkResponse>>(OauthToken, URL, dto);
        }

        /// <summary>
        /// 友達トークに関するAPIのパラメターを送るためのDtoクラス
        /// </summary>
        public class Dto
        {
            public String UserIdName { get; set; }
            public int MaxSize { get; set; }
            public int StartIndex { get; set; }
        }
    }
}
