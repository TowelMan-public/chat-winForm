using chat_winForm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class TalkListInTalkRoomControl : UserControl
    {
        public delegate List<TalkModel> LoadTalkList(int startIndex, int maxSize);

        public int NewestTalkIndex
        {
            get => BodyControl.NewestTalkIndex;
        }

        public UserControl SubContentControl
        {
            get => subContentControl;
            set
            {
                if (subContentControl != null)
                {
                    Controls.Remove(subContentControl);
                    subContentControl.Dispose();
                }

                subContentControl = value;
                subContentControl.Visible = false;
                Controls.Add(subContentControl);
                SubContentControl.Width = Width;
                SubContentControl.Location = new Point
                {
                    X = 0,
                    Y = SwitchButton.Height
                };
                SubContentControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                SubContentControl.BringToFront();
            }
        }

        public TalkRoomModel Model { get; set; }
        public LoadTalkList TalkListLoader { get; set; }
        public EventHandler TalkClickEventHandler
        {
            get => BodyControl.TalkControlClick;
            set => BodyControl.TalkControlClick = value;
        }

        private UserControl subContentControl;

        public TalkListInTalkRoomControl()
        {
            InitializeComponent();
        }

        private async void TalkListInTalkRoomControl_Load(object sender, EventArgs e)
        {
            TalkRoomListPanel.Controls.Remove(SpinnerBox);
            Controls.Add(SpinnerBox);
            SpinnerBox.BringToFront();

            StartSpinnerMode();

            SwitchButton.Text = Model.Name;
            List<TalkModel> talkModelList = await Task.Run(() => TalkListLoader(Model.LastTalkIndex - 25, 50));
            BodyControl.ShowTalkList(talkModelList);
            BodyControl.LoadNewerTalkButtonClick += BodyControl_LoadNewerTalkButtonClick;
            BodyControl.LoadOlderTalkButtonClick += BodyControl_LoadOlderTalkButtonClick;

            FinishSpinnerMode();
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            if (SubContentControl != null)
            {
                SubContentControl.Visible ^= true;
            }
        }

        private void StartSpinnerMode()
        {
            SpinnerBox.Visible = true;
            UseWaitCursor = true;
        }

        private void FinishSpinnerMode()
        {
            SpinnerBox.Visible = false;
            UseWaitCursor = false;
        }

        private async void BodyControl_LoadNewerTalkButtonClick(object sender, EventArgs e)
        {
            StartSpinnerMode();

            int startIndex = BodyControl.NewestTalkIndex + 1;
            List<TalkModel> talkModelList = await Task.Run(() => TalkListLoader(startIndex, 25));
            BodyControl.AddNewerTalkList(talkModelList);

            FinishSpinnerMode();
        }

        private async void BodyControl_LoadOlderTalkButtonClick(object sender, EventArgs e)
        {
            StartSpinnerMode();

            int startIndex = BodyControl.OldestTalkIndex - 25;
            List<TalkModel> talkModelList = await Task.Run(() => TalkListLoader(startIndex, 25));
            BodyControl.AddOlderTalkList(talkModelList);

            FinishSpinnerMode();
        }

        public async void UpdateTalkList()
        {
            StartSpinnerMode();

            int startIndex = BodyControl.NewestTalkIndex + 1;
            List<TalkModel> talkModelList = await Task.Run(() => TalkListLoader(startIndex, 25));
            BodyControl.AddNewerTalkList(talkModelList);

            FinishSpinnerMode();
        }
    }
}
