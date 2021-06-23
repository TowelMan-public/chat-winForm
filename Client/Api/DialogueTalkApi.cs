﻿using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達ユーザーのID名</param>
        /// <param name="talkContentText">トークテキスト</param>
        static public void InsertTalk(String outhToken, String haveUserIdName, String talkContentText)
        {
            const String URL = ROOT_URL + "/insert";

            var dto = new Dto
            {
                HaveUserIdName = haveUserIdName,
                TalkContentText = talkContentText
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達トークの取得をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達ユーザーのID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        /// <returns>友達トーク</returns>
        static public TalkResponse GetTalk(String outhToken, String haveUserIdName, int talkIndex)
        {
            const String URL = ROOT_URL + "/get";

            var dto = new Dto
            {
                HaveUserIdName = haveUserIdName,
                TalkIndex = talkIndex
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, TalkResponse>(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達トークの更新をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達ユーザーのID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        /// <param name="talkContentText">トークテキスト</param>
        static public void UpdateTalk(String outhToken, String haveUserIdName, int talkIndex, String talkContentText)
        {
            const String URL = ROOT_URL + "/update";

            var dto = new Dto
            {
                HaveUserIdName = haveUserIdName,
                TalkIndex = talkIndex,
                TalkContentText = talkContentText
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達トークの削除をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="haveUserIdName">友達ユーザーのID名</param>
        /// <param name="talkIndex">トークインデックス</param>
        static public void DeleteTalk(String outhToken, String haveUserIdName, int talkIndex)
        {
            const String URL = ROOT_URL + "/delete";

            var dto = new Dto
            {
                HaveUserIdName = haveUserIdName,
                TalkIndex = talkIndex
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
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
