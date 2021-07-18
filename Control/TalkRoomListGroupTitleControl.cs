using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// トークルームリストの見出しのコントロール
    /// </summary>
    public partial class TalkRoomListGroupTitleControl : UserControl
    {
        /// <summary>
        /// このコントロールがクリックされたときのイベント。
        /// わざわざ作ってあるのはこのコントロールの子コントロールにも同じイベントを登録するため
        /// </summary>
        public event EventHandler MyClick
        {
            add
            {
                Click += value;
                TalkRoomLabel.Click += value;
                NoticeCountColtrol.Click += value;
                OpenOrCloseLabel.Click += value;
            }
            remove
            {
                Click -= value;
                TalkRoomLabel.Click -= value;
                NoticeCountColtrol.Click -= value;
                OpenOrCloseLabel.Click -= value;
            }
        }

        /// <summary>
        /// トークルームリストの見出しの文字列のセット・取得
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
        /// この見出しに対応する1つのトークルームリストグループの合計通知数のセット・取得
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
                if (value <= 0)
                {
                    NoticeCountColtrol.Visible = false;
                }
                else
                {
                    NoticeCountColtrol.Visible = true;
                }
            }
        }

        /// <summary>
        /// この見出しに対応するトークルームリストグループが表示されているかどうかのセット・取得
        /// trueなら表示されている、falseなら表示されていない表示されていない
        /// </summary>
        public bool IsOpend
        {
            get
            {
                return OpenOrCloseLabel.Text == "△";
            }
            set
            {
                if (value)
                {
                    OpenOrCloseLabel.Text = "△";
                }
                else
                {
                    OpenOrCloseLabel.Text = "▽";
                }
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TalkRoomListGroupTitleControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// このコントロールが読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void TalkRoomControl_Load(object sender, EventArgs e)
        {
            IsOpend = true;
            OpenOrCloseLabel.Visible = true;
        }
    }
}
