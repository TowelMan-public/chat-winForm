using System;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    //ダミーの、メインフォーム
    public partial class RunForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RunForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// このフォームが読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void RunForm_Load(object sender, EventArgs e)
        {
            //一番最初に表示するフォーム
            LoginForm form = new LoginForm();
            form.Show();
        }

        /// <summary>
        /// このフォームがアクティブになったときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void RunForm_Activated(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
