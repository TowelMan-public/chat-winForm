using chat_winForm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class TalkListControl : UserControl
    {
        const int MORE_LOAD_BUTTON_HEIGHT = 25;
        const int TALK_UP_AND_BOTTOM_MERGIN = 5;

        public EventHandler TalkClick { get; set; }
        public event EventHandler LoadOlderTalkButtonClick
        {
            add => LoadOlderTalkButtom.Click += value;
            remove => LoadOlderTalkButtom.Click -= value;
        }
        public event EventHandler LoadNewerTalkButtonClick
        {
            add => LoadNewerTalkButtom.Click += value;
            remove => LoadNewerTalkButtom.Click -= value;
        }
        public EventHandler TalkControlClick{ get;set; }

        public int OldestTalkIndex { get; set; } = -1;
        public int NewestTalkIndex { get; set; } = -1;

        private TalkControl newestTalkControl;
        private TalkControl oldestTalkControl;

        public TalkListControl()
        {
            InitializeComponent();
        }

        private void TalkListControl_Load(object sender, EventArgs e)
        {
        }

        public void ShowTalkList(List<TalkModel> modelList)
        {
            LoadNewerTalkButtom.Visible = false;

            foreach(var model in modelList)
            {
                NewestTalkIndex = model.TalkIndex;
                var talkControl = new TalkControl
                {
                    Width = this.Width,
                    Model = model,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                talkControl.TalkClickEventHandler += TalkControlClick;

                var location = new Point(0);

                if (OldestTalkIndex == -1)
                {
                    location.Y = MORE_LOAD_BUTTON_HEIGHT + TALK_UP_AND_BOTTOM_MERGIN;
                    OldestTalkIndex = model.TalkIndex;
                    oldestTalkControl = talkControl;
                }
                else
                    location.Y = newestTalkControl.Location.Y + newestTalkControl.Height + TALK_UP_AND_BOTTOM_MERGIN;

                talkControl.Location = location;
                Controls.Add(talkControl);
                newestTalkControl = talkControl;
            }

            LoadNewerTalkButtom.Location = new Point
            {
                X = 0,
                Y = newestTalkControl.Location.Y + newestTalkControl.Size.Height + TALK_UP_AND_BOTTOM_MERGIN
            };
            LoadNewerTalkButtom.Visible = true;
        }

        public void AddOlderTalkList(List<TalkModel> modelList)
        {
            LoadOlderTalkButtom.Visible = false;

            modelList.Reverse();
            foreach (var model in modelList)
            {
                OldestTalkIndex = model.TalkIndex;
                var talkControl = new TalkControl
                {
                    Width = this.Width,
                    Model = model,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                talkControl.TalkClickEventHandler += TalkControlClick;

                var location = new Point(0);

                if (oldestTalkControl == null)
                {
                    location.Y = MORE_LOAD_BUTTON_HEIGHT - talkControl.Height;
                    NewestTalkIndex = model.TalkIndex;
                    newestTalkControl = talkControl;
                }
                else
                    location.Y = oldestTalkControl.Location.Y - oldestTalkControl.Height - TALK_UP_AND_BOTTOM_MERGIN;

                talkControl.Location = location;
                Controls.Add(talkControl);
                oldestTalkControl = talkControl;
            }

            LoadOlderTalkButtom.Location = new Point
            {
                X = 0,
                Y = oldestTalkControl.Location.Y - TALK_UP_AND_BOTTOM_MERGIN
            };
            LoadOlderTalkButtom.Visible = true;
        }

        public void AddNewerTalkList(List<TalkModel> modelList)
        {
            LoadNewerTalkButtom.Visible = false;

            foreach (var model in modelList)
            {
                NewestTalkIndex = model.TalkIndex;
                var talkControl = new TalkControl
                {
                    Width = this.Width,
                    Model = model,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                talkControl.TalkClickEventHandler += TalkControlClick;

                var location = new Point(0);

                if (OldestTalkIndex == -1)
                {
                    location.Y = MORE_LOAD_BUTTON_HEIGHT + TALK_UP_AND_BOTTOM_MERGIN;
                    OldestTalkIndex = model.TalkIndex;
                    oldestTalkControl = talkControl;
                }
                else
                    location.Y = newestTalkControl.Location.Y + newestTalkControl.Height + TALK_UP_AND_BOTTOM_MERGIN;

                talkControl.Location = location;
                Controls.Add(talkControl);
                newestTalkControl = talkControl;
            }

            LoadNewerTalkButtom.Location = new Point
            {
                X = 0,
                Y = newestTalkControl.Location.Y + newestTalkControl.Size.Height + TALK_UP_AND_BOTTOM_MERGIN
            };
            LoadNewerTalkButtom.Visible = true;
        }
    }
}
