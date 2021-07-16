using chat_winForm.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class TalkControl : UserControl
    {
        private const int TALK_WIDTH_ONE_MERGIN = 130;
        private bool AlreadyAdaptWide;

        public TalkModel Model
        {
            get => Inner.Model;
            set
            {
                Inner.Model = value;
                AdaptWide();
            }
        }

        public event EventHandler TalkClickEventHandler
        {
            add => Inner.TalkClickEventHandler += value;
            remove => Inner.TalkClickEventHandler -= value;
        }

        private int oldWidth = -1;

        public TalkControl()
        {
            InitializeComponent();
            AlreadyAdaptWide = false;
        }

        private void AdaptWide()
        {
            Inner.Width = Width - TALK_WIDTH_ONE_MERGIN;
            Inner.PaintAll();

            if (Model.IsMyTake)
            {
                Inner.Location = new Point(Width - Inner.Width, 0);
            }
            else
            {
                Inner.Location = new Point(0, 0);
            }

            Height = Inner.Height;
            AlreadyAdaptWide = true;
        }

        private void TalkControl_SizeChanged(object sender, EventArgs e)
        {
            if (AlreadyAdaptWide && oldWidth != Width)
            {
                AdaptWide();
                oldWidth = Width;
            }
        }

        private void TalkControl_Load(object sender, EventArgs e)
        {

        }
    }
}
