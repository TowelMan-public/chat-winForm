using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// 友達トークに関するAPIを呼び出すクラス
    /// </summary>
    class DialogueApi
    {
        static RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/diarogue";

        /// <summary>
        /// 友達トークリストの取得をするAPI
        /// </summary>
        /// <param name="oauthToken">認証用トークン認証用トークン</param>
        /// <param name="userIdName">ユーザーID名</param>
        /// <param name="maxSize">最大取得件数</param>
        /// <param name="startIndex">取得開始トークインデックス</param>
        /// <returns>友達トークリスト</returns>
        static public List<TalkResponse> GetDiarogueTalks(String oauthToken, String userIdName, int maxSize, int startIndex)
        {
            const String URL = ROOT_URL + "/gets/talks";

            var dto = new Dto
            {
                UserIdName = userIdName,
                MaxSize = maxSize,
                StartIndex = startIndex
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<TalkResponse>>(oauthToken, URL, dto);
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
