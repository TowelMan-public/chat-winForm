using chat_winForm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;

namespace chat_winForm.Control
{
    public partial class TalkInnerControl : UserControl
    {
        private const int TIME_STAMP_HEIGHT = 15;
        private const int YOUR_TALK_LABEL_LOCATION_Y = 20;

        public TalkModel Model
        {
            get => model;
            set
            {
                model = value;
                PaintAll();
            }
        }

        public event EventHandler TalkClickEventHandler
        {
            add => ContentTectLabel.Click += value;
            remove => ContentTectLabel.Click -= value;
        }

        private static Color MY_TAKL_COLOR = Color.FromArgb(128,255,128);
        private static Color YOUR_TAKL_COLOR = Color.Gray;

        private TalkModel model;

        public TalkInnerControl()
        {
            InitializeComponent();
        }

        private void TalkControl_Load(object sender, EventArgs e)
        {
        }

        private void PaintAll()
        {
            //プロパティーが足りない
            if (Model == null)
                return;

            TimeStampLabel.Text = Model.TimeStamp;

            ContentTectLabel.Text = Model.ContentText;
            ContentTectLabel.MaximumSize = new Size(Width, 0);

            if (Model.IsMyTake)
            {
                SenderLabel.Visible = false;
                Height = ContentTectLabel.Height + TIME_STAMP_HEIGHT;

                var widths = new List<int> { ContentTectLabel.Width, TimeStampLabel.Width };
                Width = widths.Max();

                ContentTectLabel.ForeColor = Color.Black;
                PeintImae(MY_TAKL_COLOR);
            }
            else
            {
                SenderLabel.Visible = true;
                SenderLabel.Text = Model.SenderUserName;
                Height = ContentTectLabel.Height + YOUR_TALK_LABEL_LOCATION_Y + TIME_STAMP_HEIGHT;

                var widths =  new List<int>{ ContentTectLabel.Width, SenderLabel.Width, TimeStampLabel.Width};
                Width = widths.Max();

                ContentTectLabel.ForeColor = Color.White;
                PeintImae(YOUR_TAKL_COLOR);
            }
            
        }

        //四角形の形を作る
        public GraphicsPath GetRoundRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            // 左上の角丸
            path.AddArc(rect.Left, rect.Top,
                radius * 2, radius * 2,
                180, 90);
            // 上の線
            path.AddLine(rect.Left + radius, rect.Top,
                rect.Right - radius, rect.Top);
            // 右上の角丸
            path.AddArc(rect.Right - radius * 2, rect.Top,
                radius * 2, radius * 2,
                270, 90);
            // 右の線
            path.AddLine(rect.Right, rect.Top + radius,
                rect.Right, rect.Bottom - radius);
            // 右下の角丸
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2,
                radius * 2, radius * 2,
                0, 90);
            // 下の線
            path.AddLine(rect.Right - radius, rect.Bottom,
                rect.Left + radius, rect.Bottom);
            // 左下の角丸
            path.AddArc(rect.Left, rect.Bottom - radius * 2,
                radius * 2, radius * 2,
                90, 90);
            // 左の線
            path.AddLine(rect.Left, rect.Bottom - radius,
                rect.Left, rect.Top + radius);

            path.CloseFigure();

            return path;
        }

        //四角形を描画する
        private void PeintImae(Color fillColor)
        {
            Rectangle rect = new Rectangle(0, Model.IsMyTake ? 0 : YOUR_TALK_LABEL_LOCATION_Y,
                Width, Height);
            GraphicsPath path = GetRoundRect(rect, 10);

            Graphics graphics = Graphics.FromImage(BackgroundImage);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            graphics.FillPath(new SolidBrush(fillColor), path);
        }

        private void TalkControl_SizeChanged(object sender, EventArgs e)
        {
            if (sender != this)
            {
                PaintAll();
            }
        }
    }
}
