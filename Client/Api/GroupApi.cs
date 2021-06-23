using chat_winForm.Client.ResponseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_winForm.Client.Api
{
    /// <summary>
    /// グループに関するAPIを呼び出すクラス
    /// </summary>
    class GroupApi
    {
        static RestTemplate s_RestTemplate = RestTemplate.GetInstance();

        const String ROOT_URL = ApiUrlRootConfing.ROOT_URL + "/group";

        /// <summary>
        /// グループ情報を取得するAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <returns>グループ情報</returns>
        static public GroupTalkRoomResponse GetGroup(String outhToken, int talkRoomId)
        {
            const String URL = ROOT_URL + "/get";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, GroupTalkRoomResponse>(outhToken, URL, dto);
        }

        /// <summary>
        /// 加入してるグループリストの取得をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <returns>加入してるグループリストの取得</returns>
        static public List<GroupTalkRoomResponse> GetGroups(String outhToken)
        {
            const String URL = ROOT_URL + "/gets";

            var dto = new Dto();

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<GroupTalkRoomResponse>>(outhToken, URL, dto);
        }

        /// <summary>
        /// グループトークリストの取得をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="startIndex">最初のトークインデックス</param>
        /// <param name="maxSize">最大件数</param>
        /// <returns>グループトークリスト</returns>
        static public List<TalkResponse> GetGroupTalks(String outhToken, int talkRoomId, int startIndex, int maxSize)
        {
            const String URL = ROOT_URL + "/gets/talks";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId,
                StartIndex = startIndex,
                MaxSize = maxSize
            };

            return s_RestTemplate.GetHttpMethodWhenLogined<Dto, List<TalkResponse>>(outhToken, URL, dto);
        }

        /// <summary>
        /// グループ名の更新をするAPI
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomId">グループトークルームID</param>
        /// <param name="groupName">グループ名</param>
        static public void UpdateGroupName(String outhToken, int talkRoomId, String groupName)
        {
            const String URL = ROOT_URL + "/update/name";

            var dto = new Dto
            {
                TalkRoomId = talkRoomId,
                GroupName = groupName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// グループの削除
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="talkRoomid">グループトークルームID</param>
        static public void DeleteGroup(String outhToken, int talkRoomid)
        {
            const String URL = ROOT_URL + "/delete";

            var dto = new Dto
            {
                TalkRoomId = talkRoomid
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// グループの作成
        /// </summary>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="groupName">グループ名</param>
        static public void InsertGroup(String outhToken, String groupName)
        {
            const String URL = ROOT_URL + "/insert";

            var dto = new Dto
            {
                GroupName = groupName
            };

            s_RestTemplate.PostHttpMethodWhenLogined(outhToken, URL, dto);
        }

        /// <summary>
        /// 友達トークに関するAPIのパラメターを送るためのDtoクラス
        /// </summary>
        public class Dto
        {
            public int TalkRoomId { get; set; }
            public String GroupName { get; set; }
            public int MaxSize { get; set; }
            public int StartIndex { get; set; }
        }
    }
}
