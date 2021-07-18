using System.Windows.Forms;

namespace chat_winForm.Forms.Commons
{
    /// <summary>
    /// よく使うであろうメッセージボックス集
    /// </summary>
    static class CommonMessageBoxs
    {
        /// <summary>
        /// バリデーションエラーのメッセージボックス
        /// </summary>
        public static void ValidationMessageBox()
        {
            MessageBox.Show("入力された値が不正です。テキストボックスのわきにある赤いアイコンをマウスでかざして、それに従ってください。",
                            "警告",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 予期しないエラーのメッセージボックス
        /// </summary>
        public static void UnexpectedErrorMessageBox()
        {
            MessageBox.Show("予期しないエラーが発生しました。これまでに行われた操作は一部、あるいはすべてが無効、不正になっている可能性があります。" +
                "開発者にこのエラーが発生したことを、状況等を細かく伝えてください。",
                "重大なエラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// ログインに失敗したときのメッセージボックス
        /// </summary>
        public static void FailureLoginMessageBox()
        {
            MessageBox.Show("ログインに失敗しました。パスワードとユーザーIDを確かめてください。",
                            "失敗",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        /// <summary>
        /// 認証の更新に失敗したときのメッセージボックス
        /// </summary>
        public static void FailureUpdateOuthTokenMessageBox()
        {
            MessageBox.Show("認証の更新でエラーが発生しました。これは外部でパスワードが変更されたときにおこるエラーです。" +
                    "後でパスワードを再設定してください。",
                    "失敗",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        /// <summary>
        /// 再ログインが必要な時のメッセージボックス
        /// </summary>
        public static void InvalidLoginExceptionMessageBox()
        {
            MessageBox.Show("パスワード等が保存されていないか、外部からパスワード等を変更されたために認証が更新されずに寿命を迎えてしまいました。\n" +
                    "お手数をおかけしますが今の作業等を全てやめて、再度ログインしてくださりますようお願いいたします。" +
                    "尚、作業中のデータは失われるかもしれません。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        /// <summary>
        /// 既に使われているユーザーIDが指定されたときのメッセージボックス
        /// </summary>
        public static void AlreadyUsedUserIdNameErrorMessageBox()
        {
            MessageBox.Show("あなたが指定したユーザーIDは既にほかの人に使われています。ほかのユーザーIDをご検討ください。",
                            "失敗",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }
    }
}
