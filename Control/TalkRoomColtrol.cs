using chat_winForm.Model;
using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// トークルーム単体を表すコントロール
    /// </summary>
    public partial class TalkRoomColtrol : UserControl
    {
        /// <summary>
        /// このコントロールに保持されるデータセットのセット・取得
        /// </summary>
        public TalkRoomModel Model { get; set; }

        /// <summary>
        /// トークルームをクリックしたときのクリックイベント
        /// </summary>
        public event EventHandler MyClick
        {
            add
            {
                Click += value;
                TalkRoomLabel.Click += value;
                NoticeCountColtrol.Click += value;
            }
            remove
            {
                Click -= value;
                TalkRoomLabel.Click -= value;
                NoticeCountColtrol.Click -= value;
            }
        }

        /// <summary>
        /// トークルーム名のセット・取得
        /// </summary>
        public new String Text
        {
            get
            {
                return TalkRoomLabel.Text;
            }
            set
            {
                TalkRoomLabel.Text = value;
            }
        }

        /// <summary>
        /// 通知数のセット・取得
        /// </summary>
        public int NoticeCount
        {
            get
            {
                if (int.TryParse(NoticeCountColtrol.Text, out int value))
                {
                    return value;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                NoticeCountColtrol.Text = value.ToString();
                if (value > 0)
                {
                    NoticeCountColtrol.Visible = true;
                }
                else
                {
                    NoticeCountColtrol.Visible = false;
                }
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TalkRoomColtrol()
        {
            InitializeComponent();
        }
    }
}
