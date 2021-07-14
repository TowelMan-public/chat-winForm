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
            //マウスイベント登録
            MouseDown +=
                new MouseEventHandler(OuterForm_MouseDown);
            MouseMove +=
                new MouseEventHandler(OuterForm_MouseMove);

            //リサイズ用コントロールにマウスイベントを追加
            LeftTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(TopSizeChanger_MouseMove);
            LeftTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(LeftSizeChanger_MouseMove);
            RightTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(RightSizeChanger_MouseMove);
            RightTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(TopSizeChanger_MouseMove);
            LeftBottomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(LeftSizeChanger_MouseMove);
            LeftBottomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(BottomSizeChanger_MouseMove);
            RightButtonSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(RightSizeChanger_MouseMove);
            RightButtonSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(BottomSizeChanger_MouseMove);

            //ボタンの画像を透過させる
            (ExitButton.BackgroundImage as Bitmap).MakeTransparent(Color.FromArgb(255, 255, 255));
            (ReSizeButton.BackgroundImage as Bitmap).MakeTransparent();
            (ToMinButton.BackgroundImage as Bitmap).MakeTransparent();
            (ReReSizeButton.BackgroundImage as Bitmap).MakeTransparent();

            //サイズをもとに戻すボタンを非表示にする
            ReReSizeButton.Visible = false;
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
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(200, 40, 40);
        }

        /// <summary>
        /// 閉じるボタンからカーソルが出て行った
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(64, 64, 64);
        }

        /// <summary>
        /// 閉じるボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 最大化ボタン(ReSizeButton)が押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReSizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ReSizeButton.Visible = false;
            ReReSizeButton.Visible = true;
        }

        /// <summary>
        /// 最小化ボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// リサイズボタン(ReReSize)が押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReReSizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ReReSizeButton.Visible = false;
            ReSizeButton.Visible = true;
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
