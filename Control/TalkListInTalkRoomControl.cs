using chat_winForm.Model;
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
    public partial class TalkListInTalkRoomControl : UserControl
    {
        public delegate List<TalkModel> LoadTalkList(int startIndex, int maxSize);

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
            StartSpinnerMode();

            SwitchButton.Text = Model.Name;
            var talkModelList = await Task.Run(() => TalkListLoader(Model.LastTalkIndex - 25, 50));
            BodyControl.ShowTalkList(talkModelList);

            FinishSpinnerMode();
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            if (SubContentControl != null)
            {
                SubContentControl.Visible ^= true;
                SubContentControl.BringToFront();
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

            var startIndex = BodyControl.NewestTalkIndex + 1;
            var talkModelList = await Task.Run(() => TalkListLoader(startIndex, 25));
            BodyControl.AddNewerTalkList(talkModelList);

            FinishSpinnerMode();
        }

        private async void BodyControl_LoadOlderTalkButtonClick(object sender, EventArgs e)
        {
            StartSpinnerMode();

            var startIndex = BodyControl.OldestTalkIndex - 25;
            var talkModelList = await Task.Run(() => TalkListLoader(startIndex, 25));
            BodyControl.AddOlderTalkList(talkModelList);

            FinishSpinnerMode();
        }
    }
}
