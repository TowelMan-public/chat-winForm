using chat_winForm.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// トークルームリストグループコントロール
    /// </summary>
    public partial class TalkRoomListGroupControl : UserControl
    {
        /// <summary>
        /// トークルームをクリックしたときのイベントハンドラーのセット・取得
        /// </summary>
        public EventHandler TalkRoomClickEventHandler { get; set; }

        private const int TALK_ROOM_HEIGHT = 25;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TalkRoomListGroupControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// トークルームを追加する
        /// </summary>
        /// <param name="name">トークルーム名</param>
        /// <param name="noticeCount">通知数</param>
        /// <param name="model">トークルームのデータが格納されたクラス</param>
        public void AddTalkRoom(String name, int noticeCount, TalkRoomModel model)
        {
            //高さの変更
            int talkRoomControlPointY = Height;
            Height += TALK_ROOM_HEIGHT;

            //TalkRoomControlの作成・設定
            TalkRoomColtrol talkRoomControl = new TalkRoomColtrol
            {
                Location = new Point(0, talkRoomControlPointY),
                Margin = new Padding(0),
                Size = new Size(Width, TALK_ROOM_HEIGHT),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Text = name,
                NoticeCount = noticeCount,
                Model = model
            };
            talkRoomControl.MyClick += TalkRoomClickEventHandler;

            //追加
            Controls.Add(talkRoomControl);
        }

        /// <summary>
        /// このコントロール内を全てリセットする
        /// </summary>
        public void Reset()
        {
            Controls.Clear();
            Height = 0;
        }
    }
}
