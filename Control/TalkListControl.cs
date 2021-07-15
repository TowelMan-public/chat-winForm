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
        public EventHandler TalkControlClick { get; set; }

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
            foreach (TalkModel model in modelList)
            {
                NewestTalkIndex = model.TalkIndex;
                TalkControl talkControl = new TalkControl
                {
                    Width = Width,
                    Model = model,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                talkControl.TalkClickEventHandler += TalkControlClick;

                Point location = new Point(0);

                if (OldestTalkIndex == -1)
                {
                    location.Y = LoadOlderTalkButtom.Height + TALK_UP_AND_BOTTOM_MERGIN;
                    OldestTalkIndex = model.TalkIndex;
                    oldestTalkControl = talkControl;
                }
                else
                {
                    location.Y = newestTalkControl.Location.Y + newestTalkControl.Height + TALK_UP_AND_BOTTOM_MERGIN;
                }

                talkControl.Location = location;
                Controls.Add(talkControl);
                newestTalkControl = talkControl;
            }

            if (newestTalkControl == null)
            {
                LoadNewerTalkButtom.Location = new Point
                {
                    X = 0,
                    Y = LoadOlderTalkButtom.Location.Y + LoadOlderTalkButtom.Height
                };
            }
            else
            {
                LoadNewerTalkButtom.Location = new Point
                {
                    X = 0,
                    Y = newestTalkControl.Location.Y + newestTalkControl.Size.Height + TALK_UP_AND_BOTTOM_MERGIN
                };
            }

            Height = LoadNewerTalkButtom.Location.Y + LoadNewerTalkButtom.Height;
        }

        public void AddOlderTalkList(List<TalkModel> modelList)
        {
            if (modelList.Count <= 0)
            {
                return;
            }

            LoadOlderTalkButtom.Visible = false;

            modelList.Reverse();
            foreach (TalkModel model in modelList)
            {
                OldestTalkIndex = model.TalkIndex;
                TalkControl talkControl = new TalkControl
                {
                    Width = Width,
                    Model = model,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                talkControl.TalkClickEventHandler += TalkControlClick;

                Point location = new Point(0);

                if (oldestTalkControl == null)
                {
                    location.Y = MORE_LOAD_BUTTON_HEIGHT - talkControl.Height;
                    NewestTalkIndex = model.TalkIndex;
                    newestTalkControl = talkControl;
                }
                else
                {
                    location.Y = oldestTalkControl.Location.Y - talkControl.Height - TALK_UP_AND_BOTTOM_MERGIN;
                }

                talkControl.Location = location;
                Controls.Add(talkControl);
                oldestTalkControl = talkControl;
            }

            LoadOlderTalkButtom.Location = new Point
            {
                X = 0,
                Y = oldestTalkControl.Location.Y - TALK_UP_AND_BOTTOM_MERGIN - LoadOlderTalkButtom.Height
            };

            int addLocationY = -LoadOlderTalkButtom.Location.Y;
            foreach (object control in Controls)
            {
                Point location = (control as System.Windows.Forms.Control).Location;
                location.Y += addLocationY;
                (control as System.Windows.Forms.Control).Location = location;
            }

            LoadOlderTalkButtom.Visible = true;
            Height = LoadNewerTalkButtom.Location.Y + LoadNewerTalkButtom.Height;
        }

        public void AddNewerTalkList(List<TalkModel> modelList)
        {
            foreach (TalkModel model in modelList)
            {
                NewestTalkIndex = model.TalkIndex;
                TalkControl talkControl = new TalkControl
                {
                    Width = Width,
                    Model = model,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                talkControl.TalkClickEventHandler += TalkControlClick;

                Point location = new Point(0);

                if (OldestTalkIndex == -1)
                {
                    location.Y = LoadOlderTalkButtom.Height + TALK_UP_AND_BOTTOM_MERGIN;
                    OldestTalkIndex = model.TalkIndex;
                    oldestTalkControl = talkControl;
                }
                else
                {
                    location.Y = newestTalkControl.Location.Y + newestTalkControl.Height + TALK_UP_AND_BOTTOM_MERGIN;
                }

                talkControl.Location = location;
                Controls.Add(talkControl);
                newestTalkControl = talkControl;
            }

            if (newestTalkControl == null)
            {
                LoadNewerTalkButtom.Location = new Point
                {
                    X = 0,
                    Y = LoadOlderTalkButtom.Location.Y + LoadOlderTalkButtom.Height
                };
            }
            else
            {
                LoadNewerTalkButtom.Location = new Point
                {
                    X = 0,
                    Y = newestTalkControl.Location.Y + newestTalkControl.Size.Height + TALK_UP_AND_BOTTOM_MERGIN
                };
            }

            Height = LoadNewerTalkButtom.Location.Y + LoadNewerTalkButtom.Height;
        }

        public void ResetTalkList()
        {
            foreach(var control in Controls)
            {
                if (!(control is Button))
                    Controls.Remove(control as System.Windows.Forms.Control);
            }
        }
    }
}
