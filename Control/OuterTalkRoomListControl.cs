using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class OuterTalkRoomListControl : UserControl
    {
        private const int THIS_TITLE_HEIGHT = 32;

        public EventHandler DialigueTalkRoomClickEventHandler { get; set; }
        public EventHandler GroupTalkRoomClickEventHandler { get; set; }
        public EventHandler DesireDialogueTalkRoomClickEventHandler { get; set; }
        public EventHandler DesireGroupTalkRoomClickEventHandler { get; set; }

        private TalkRoomListControl Body;

        public OuterTalkRoomListControl()
        {
            InitializeComponent();
        }

        private void OuterTalkRoomListControl_Load(object sender, EventArgs e)
        {
            Body = CreateTalkRoomListControl();
            Controls.Add(Body);
        }

        public void UpdateContents()
        {
            Controls.Remove(Body);
            Body = CreateTalkRoomListControl();
            Controls.Add(Body);
        }

        private TalkRoomListControl CreateTalkRoomListControl()
        {
            return new TalkRoomListControl
            {
                Margin = new Padding(0),
                Location = new Point(5, THIS_TITLE_HEIGHT + 1),
                Size = new Size(Width - 10, Height - THIS_TITLE_HEIGHT),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                DialigueTalkRoomClickEventHandler = DialigueTalkRoomClickEventHandler,
                GroupTalkRoomClickEventHandler = GroupTalkRoomClickEventHandler,
                DesireDialogueTalkRoomClickEventHandler = DesireDialogueTalkRoomClickEventHandler,
                DesireGroupTalkRoomClickEventHandler = DesireGroupTalkRoomClickEventHandler
            };
        }
    }
}
