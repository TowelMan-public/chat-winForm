using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class TalkRoomListGroupTitleControl : UserControl
    {
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

        public TalkRoomListGroupTitleControl()
        {
            InitializeComponent();
        }

        private void TalkRoomControl_Load(object sender, EventArgs e)
        {
            IsOpend = false;
        }
    }
}
