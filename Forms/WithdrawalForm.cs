using chat_winForm.Registry;
using chat_winForm.Service;
using System;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    /// <summary>
    /// 退会確認画面
    /// </summary>
    public partial class WithdrawalForm : chat_winForm.OuterForm
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WithdrawalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 退会ボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            UserService.Exit();
            userCredentialsProvider.DeleteOuthToken();
            userCredentialsProvider.AllDelete();
            Application.Exit();
        }

        /// <summary>
        /// 戻るボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
