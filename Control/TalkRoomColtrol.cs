using chat_winForm.Model;
using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class TalkRoomColtrol : UserControl
    {
        public TalkRoomModel Model { get; set; }

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
                    return value;
                else
                    return -1;
            }
            set
            {
                NoticeCountColtrol.Text = value.ToString();
                if (value > 0)
                    NoticeCountColtrol.Visible = true;
                else
                    NoticeCountColtrol.Visible = false;
            }
        }

        public TalkRoomColtrol()
        {
            InitializeComponent();
        }

        private void TalkRoomColtrol_Load(object sender, EventArgs e)
        {
        }
    }
}
