using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// 通知コントロール
    /// </summary>
    public partial class NoticeControl : UserControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public NoticeControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 通知の文字列のサイズのセット・取得
        /// </summary>
        public float FontSize
        {
            get
            {
                return NoticeLabel.Font.Size;
            }
            set
            {

                NoticeLabel.Font = new Font("MS UI Gothic", value, FontStyle.Regular, GraphicsUnit.Point, 128);
            }
        }

        /// <summary>
        /// 通知の文字列のセット・取得
        /// </summary>
        public new String Text
        {
            get
            {
                return NoticeLabel.Text;
            }
            set
            {
                NoticeLabel.Text = value;
            }
        }

        /// <summary>
        /// 通知コントロールが読み込まれたときの処理
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void NoticeControl_Load(object sender, EventArgs e)
        {
            (BackgroundImage as Bitmap).MakeTransparent();
        }
    }
}
