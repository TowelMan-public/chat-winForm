using chat_winForm.Forms.Commons;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_winForm
{
    /// <summary>
    /// このアプリで使うフォームの大枠。
    /// </summary>
    public partial class OuterForm : Form
    {
        private Point pointWhenLastMouseDown;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public OuterForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OuterForm_Load(object sender, EventArgs e)
        {
            MouseDown +=
                new MouseEventHandler(OuterForm_MouseDown);
            MouseMove +=
                new MouseEventHandler(OuterForm_MouseMove);

            LeftTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(TopSizeChanger_MouseMove);
            LeftTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(LeftSizeChanger_MouseMove);

            RightTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(RightSizeChanger_MouseMove);
            RightTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(TopSizeChanger_MouseMove);

            LeftBottomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(LeftSizeChanger_MouseMove);
            LeftBottomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(BottomSizeChanger_MouseMove);

            RightButtomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(RightSizeChanger_MouseMove);
            RightButtomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(BottomSizeChanger_MouseMove);

            Bitmap image = ExitButtom.BackgroundImage as Bitmap;
            image.MakeTransparent(Color.FromArgb(255, 255, 255));
            ExitButtom.BackgroundImage = image;

            image = ReSizeButtom.BackgroundImage as Bitmap;
            image.MakeTransparent(Color.FromArgb(255, 255, 255));
            ReSizeButtom.BackgroundImage = image;

            image = ToMinButtom.BackgroundImage as Bitmap;
            image.MakeTransparent(Color.FromArgb(255, 255, 255));
            ToMinButtom.BackgroundImage = image;

            image = ReReSizeButtom.BackgroundImage as Bitmap;
            image.MakeTransparent(Color.FromArgb(255, 255, 255));
            ReReSizeButtom.BackgroundImage = image;
            ReReSizeButtom.Visible = false;

        }

        /// <summary>
        /// このフォームでマウスが押されたときのイベント（マウスポイント等の記憶）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OuterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                pointWhenLastMouseDown = new Point(e.X, e.Y);
            }
        }

        /// <summary>
        /// このフォームでマウスがドラッグされたときのイベント
        /// フォームの移動用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OuterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Left += e.X - pointWhenLastMouseDown.X;
                Top += e.Y - pointWhenLastMouseDown.Y;
            }
        }

        /// <summary>
        /// このフォームのTopSizeChangerでマウスがドラッグされたときのイベント
        /// リサイズ用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopSizeChanger_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int h = Height;
                Height -= e.Y - pointWhenLastMouseDown.Y;
                Top += h - Height;
            }
        }

        /// <summary>
        /// このフォームのBottomSizeChangerでマウスがドラッグされたときのイベント
        /// リサイズ用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BottomSizeChanger_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Height += e.Y - pointWhenLastMouseDown.Y;
            }
        }

        /// <summary>
        /// このフォームのRightSizeChangerでマウスがドラッグされたときのイベント
        /// リサイズ用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightSizeChanger_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Width += e.X - pointWhenLastMouseDown.X;
            }
        }

        /// <summary>
        /// このフォームのLeftSizeChangerでマウスがドラッグされたときのイベント
        /// リサイズ用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftSizeChanger_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int w = Width;
                Width -= e.X - pointWhenLastMouseDown.X;
                Left += w - Width;
            }
        }

        /// <summary>
        /// 閉じるボタンの上にカーソルが乗った
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtom_MouseEnter(object sender, EventArgs e)
        {
            ExitButtom.BackColor = Color.FromArgb(200, 40, 40);
        }

        /// <summary>
        /// 閉じるボタンからカーソルが出て行った
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ExitButtom.BackColor = Color.FromArgb(64, 64, 64);
        }

        /// <summary>
        /// 閉じるボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtom_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 最大化ボタン(ReSizeButtom)が押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReSizeButtom_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ReSizeButtom.Visible = false;
            ReReSizeButtom.Visible = true;
        }

        /// <summary>
        /// 最小化ボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMinButtom_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// リサイズボタン(ReReSize)が押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReReSizeButtom_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ReReSizeButtom.Visible = false;
            ReSizeButtom.Visible = true;
        }

        /// <summary>
        /// 認証用トークンの期限が切れたときのハンドラー関数
        /// </summary>
        protected void InvalidLoginExceptionHandler()
        {
            CommonMessageBoxs.InvalidLoginExceptionMessageBox();
            Close();
            Forms.LoginForm loginForm = new Forms.LoginForm();
            loginForm.Show();
        }
    }
}
