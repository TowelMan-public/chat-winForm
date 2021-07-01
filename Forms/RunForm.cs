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
        /// 初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunForm_Load(object sender, EventArgs e)
        {
            //一番最初に表示するフォーム
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void RunForm_Activated(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
