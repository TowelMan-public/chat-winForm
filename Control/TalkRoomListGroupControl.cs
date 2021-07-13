using chat_winForm.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class TalkRoomListGroupControl : UserControl
    {
        public EventHandler TalkRoomClickEventHandler { get; set; }

        private const int TALK_ROOM_HEIGHT = 25;

        public TalkRoomListGroupControl()
        {
            InitializeComponent();
        }

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
            talkRoomControl.Click += TalkRoomClickEventHandler;

            //追加
            Controls.Add(talkRoomControl);

        }

        private void TalkRoomListGroupControl_Load(object sender, EventArgs e)
        {

        }
    }
}
