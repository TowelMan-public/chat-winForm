using chat_winForm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// TalkControlの中身の部分
    /// </summary>
    /// <see cref="TalkControl"/>
    public partial class TalkInnerControl : UserControl
    {
        private const int TIME_STAMP_HEIGHT = 15;
        private const int YOUR_TALK_LABEL_LOCATION_Y = 20;
        private static readonly Color MY_TAKL_COLOR = Color.FromArgb(128, 255, 128);
        private static readonly Color YOUR_TAKL_COLOR = Color.Gray;

        /// <summary>
        /// このコントロールで使うデータセットのセット・取得
        /// </summary>
        public TalkModel Model
        {
            get => _model;
            set
            {
                _model = value;
                PaintAll();
            }
        }

        /// <summary>
        /// トークの内容の部分がクリックされたときのイベント
        /// </summary>
        public event EventHandler TalkClickEventHandler
        {
            add => ContentTextLabel.Click += value;
            remove => ContentTextLabel.Click -= value;
        }

        private bool alreadyPringtAll;
        private TalkModel _model;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TalkInnerControl()
        {
            InitializeComponent();
            alreadyPringtAll = false;
        }

        /// <summary>
        /// トークの全てを表示する
        /// </summary>
        public void PaintAll()
        {
            //プロパティーが足りない
            if (Model == null)
            {
                return;
            }

            TimeStampLabel.Text = Model.TimeStamp;

            ContentTextLabel.MaximumSize = new Size(Width, 0);
            ContentTextLabel.Text = Model.ContentText;

            if (Model.IsMyTake)
            {
                SenderLabel.Visible = false;

                List<int> widths = new List<int> { ContentTextLabel.Width, TimeStampLabel.Width };
                Width = widths.Max();


                ContentTextLabel.Location = new Point
                {
                    X = Width - ContentTextLabel.Width,
                    Y = 0
                };
                TimeStampLabel.Location = new Point
                {
                    X = Width - TimeStampLabel.Width,
                    Y = ContentTextLabel.Location.Y + ContentTextLabel.Height + 1
                };

                Height = TimeStampLabel.Location.Y + TimeStampLabel.Height;
                ContentTextLabel.ForeColor = Color.Black;
                PeintImae(MY_TAKL_COLOR);
            }
            else
            {
                SenderLabel.Visible = true;
                SenderLabel.Text = Model.SenderUserName;
                SenderLabel.Location = new Point(0);

                List<int> widths = new List<int> { ContentTextLabel.Width, SenderLabel.Width, TimeStampLabel.Width };
                Width = widths.Max();

                ContentTextLabel.Location = new Point
                {
                    X = 0,
                    Y = SenderLabel.Height + 1
                };
                TimeStampLabel.Location = new Point
                {
                    X = Width - TimeStampLabel.Width,
                    Y = ContentTextLabel.Location.Y + ContentTextLabel.Height + 1
                };

                Height = TimeStampLabel.Location.Y + TimeStampLabel.Height;
                ContentTextLabel.ForeColor = Color.White;
                PeintImae(YOUR_TAKL_COLOR);
            }

            alreadyPringtAll = true;
        }

        /// <summary>
        /// 角丸四角形の形を作る
        /// </summary>
        /// <param name="rect">四角形の位置とサイズ</param>
        /// <param name="radius">丸みの度合い</param>
        /// <returns></returns>
        private GraphicsPath GetRoundRect(Rectangle rect, int radius)
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

        /// <summary>
        /// トークの内容部分の四角形を描画する
        /// </summary>
        /// <param name="fillColor">四角形の色</param>
        private void PeintImae(Color fillColor)
        {
            Rectangle rect = new Rectangle(0, 0, ContentTextLabel.Width, ContentTextLabel.Height);
            GraphicsPath path = GetRoundRect(rect, 10);

            ContentTextLabel.BackgroundImage = new Bitmap(ContentTextLabel.Width, ContentTextLabel.Height);
            Graphics graphics = Graphics.FromImage(ContentTextLabel.BackgroundImage);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            graphics.FillPath(new SolidBrush(fillColor), path);
        }

        /// <summary>
        /// リサイズされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void TalkControl_SizeChanged(object sender, EventArgs e)
        {
            if (alreadyPringtAll)
            {
                PaintAll();
            }
        }
    }
}
