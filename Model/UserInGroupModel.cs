using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// グループ加入者のモデルクラス。
    /// </summary>
    class UserInGroupModel
    {
        /// <summary>
        /// グループトークルームID
        /// </summary>
        public int GropuTalkRoomId { get; set; }

        /// <summary>
        /// ユーザーID名
        /// </summary>
        public String UserIdName { get; set; }

        /// <summary>
        /// ユーザー名
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// このトークが自分のものであるか否か。
        /// 自分のものであればtrue、そうでなければfalse
        /// </summary>
        public bool isMe { get; set; }
    }
}
