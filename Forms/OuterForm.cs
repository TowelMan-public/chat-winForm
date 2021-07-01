using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm
{
    /// <summary>
    /// このアプリで使うフォームの大枠。
    /// </summary>
    public partial class OuterForm : Form
    {
        private Point pointWhenLastMouseDown;
        private Size sizeWhenLastMouseDown;

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
            this.MouseDown +=
                new MouseEventHandler(OuterForm_MouseDown);
            this.MouseMove +=
                new MouseEventHandler(OuterForm_MouseMove);

            this.LeftTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopSizeChanger_MouseMove);
            this.LeftTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftSizeChanger_MouseMove);

            this.RightTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightSizeChanger_MouseMove);
            this.RightTopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopSizeChanger_MouseMove);

            this.LeftBottomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftSizeChanger_MouseMove);
            this.LeftBottomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomSizeChanger_MouseMove);

            this.RightButtomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightSizeChanger_MouseMove);
            this.RightButtomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomSizeChanger_MouseMove);

            var image = this.ExitButtom.BackgroundImage as Bitmap;
            image.MakeTransparent(Color.FromArgb(255,255,255));
            this.ExitButtom.BackgroundImage = image;

            image = this.ReSizeButtom.BackgroundImage as Bitmap;
            image.MakeTransparent(Color.FromArgb(255, 255, 255));
            this.ReSizeButtom.BackgroundImage = image;

            image = this.ToMinButtom.BackgroundImage as Bitmap;
            image.MakeTransparent(Color.FromArgb(255, 255, 255));
            this.ToMinButtom.BackgroundImage = image;

            image = this.ReReSizeButtom.BackgroundImage as Bitmap;
            image.MakeTransparent(Color.FromArgb(255, 255, 255));
            this.ReReSizeButtom.BackgroundImage = image;
            this.ReReSizeButtom.Visible = false;

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
                sizeWhenLastMouseDown = this.Size;
                
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
                this.Left += e.X - pointWhenLastMouseDown.X;
                this.Top += e.Y - pointWhenLastMouseDown.Y;
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
                int h = this.Height;
                this.Height -= e.Y - pointWhenLastMouseDown.Y;
                this.Top += h - this.Height;
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
                this.Height += e.Y - pointWhenLastMouseDown.Y;
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
                this.Width += e.X - pointWhenLastMouseDown.X;
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
                int w = this.Width;
                this.Width -= e.X - pointWhenLastMouseDown.X;
                this.Left += w - this.Width;
            }
        }

        /// <summary>
        /// 閉じるボタンの上にカーソルが乗った
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtom_MouseEnter(object sender, EventArgs e)
        {
            this.ExitButtom.BackColor = Color.FromArgb(200,40,40);
        }

        /// <summary>
        /// 閉じるボタンからカーソルが出て行った
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            this.ExitButtom.BackColor = Color.FromArgb(64, 64, 64);
        }

        /// <summary>
        /// 閉じるボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 最大化ボタン(ReSizeButtom)が押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReSizeButtom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.ReSizeButtom.Visible = false;
            this.ReReSizeButtom.Visible = true;
        }

        /// <summary>
        /// 最小化ボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMinButtom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// リサイズボタン(ReReSize)が押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReReSizeButtom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ReReSizeButtom.Visible = false;
            this.ReSizeButtom.Visible = true;
        }

        protected void UnexpectedError(Exception e)
        {
            MessageBox.Show("予期しないエラーが発生しました。これまでに行われた操作は一部、あるいはすべてが無効になっている可能性があります。" +
                "この現象が続く場合は開発者に報告してください。",
                "重大なエラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
