using System;

namespace chat_winForm.Model
{
    /// <summary>
    /// トークルームのモデルクラス。
    /// 実際にはこのクラスを継承したものを使う。
    /// このクラスからのインスタンスの生成不可能です。
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


        public int NoticeCount { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">トークルームの名前</param>
        /// <param name="myLastTalkIndex">ラストトークインデックス</param>
        public TalkRoomModel(String name, int lastTalkIndex, int noticeCount)
        {
            Name = name;
            LastTalkIndex = lastTalkIndex;
            NoticeCount = noticeCount;
        }
    }
}
