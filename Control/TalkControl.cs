using chat_winForm.Model;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class TalkControl : UserControl
    {
        private const int TIME_STAMP_HEIGHT = 15;
        private const int YOUR_TALK_LABEL_LOCATION_Y = 20;

        public TalkModel Model
        {
            get => Model;
            set
            {
                Model = value;
                PaintAll();
            }
        }

        public Color ImageColor
        {
            get => ImageColor;
            set
            {
                ImageColor = value;
                PaintAll();
            }
        }

        public TalkControl()
        {
            InitializeComponent();
        }

        private void TalkControl_Load(object sender, EventArgs e)
        {
            PaintAll();
        }

        private void PaintAll()
        {
            //プロパティーが足りない
            if (Model == null || ImageColor == null)
            {
                return;
            }

            TimeStampLabel.Text = Model.TimeStamp;

            ContentTectLabel.Text = Model.ContentText;
            ContentTectLabel.MaximumSize = new Size(Width, 0);

            if (Model.IsMyTake)
            {
                SenderLabel.Visible = false;
                Height = ContentTectLabel.Height + TIME_STAMP_HEIGHT;
                Width = ContentTectLabel.Width > TimeStampLabel.Width ? ContentTectLabel.Width : TimeStampLabel.Width;
            }
            else
            {
                SenderLabel.Visible = true;
                SenderLabel.Text = Model.SenderUserName;
                Height = ContentTectLabel.Height + YOUR_TALK_LABEL_LOCATION_Y + TIME_STAMP_HEIGHT;
                if (ContentTectLabel.Width > TimeStampLabel.Width)
                {
                    if (ContentTectLabel.Width > SenderLabel.Width)
                    {
                        Width = ContentTectLabel.Width;
                    }
                    else if (TimeStampLabel.Width > SenderLabel.Width)
                    {
                        Width = TimeStampLabel.Width;
                    }
                    else
                    {
                        Width = SenderLabel.Width;
                    }
                }
                else
                {
                    if (TimeStampLabel.Width > SenderLabel.Width)
                    {
                        Width = TimeStampLabel.Width;
                    }
                    else if (ContentTectLabel.Width > SenderLabel.Width)
                    {
                        Width = ContentTectLabel.Width;
                    }
                    else
                    {
                        Width = SenderLabel.Width;
                    }
                }
            }

            PeintImae();
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
        private void PeintImae()
        {
            Rectangle rect = new Rectangle(0, Model.IsMyTake ? 0 : YOUR_TALK_LABEL_LOCATION_Y,
                ContentTectLabel.Width, ContentTectLabel.Height);
            GraphicsPath path = GetRoundRect(rect, 10);

            Graphics graphics = CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillPath(Brushes.Red, path);
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
