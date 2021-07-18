using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// トークルームのモデルクラス。
    /// 実際にはこのクラスを継承したものを使う。
    /// </summary>
    public class TalkRoomModel
    {
        /// <summary>
        /// トークルームの名前
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// ラストトークインデックス
        /// ユーザー側にもラストトークインデックスがある場合はユーザー側のラストトークインデックス
        /// </summary>
        public int LastTalkIndex { get; set; }

        /// <summary>
        /// 通知数
        /// </summary>
        public int NoticeCount { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トークルームの名前</param>
        /// <param name="lastTalkIndex">ラストトークインデックス</param>
        /// <param name="noticeCount">通知数</param>
        public TalkRoomModel(String name, int lastTalkIndex, int noticeCount)
        {
            Name = name;
            LastTalkIndex = lastTalkIndex;
            NoticeCount = noticeCount;
        }
    }
}
