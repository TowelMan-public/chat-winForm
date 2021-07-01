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
        static public void ValidationMessageBox()
        {
            MessageBox.Show("入力された値が不正です。テキストボックスのわきにある赤いアイコンをマウスでかざして、それに従ってください。",
                            "警告",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 予期しないエラーのメッセージボックス
        /// </summary>
        static public void UnexpectedErrorMessageBox()
        {
            MessageBox.Show("予期しないエラーが発生しました。これまでに行われた操作は一部、あるいはすべてが無効になっている可能性があります。" +
                "この現象が続く場合は開発者に報告してください。",
                "重大なエラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// ログインに失敗したときのメッセージボックス
        /// </summary>
        static public void FailureLoginMessageBox()
        {
            MessageBox.Show("ログインに失敗しました。パスワードとユーザーIDを確かめてください。",
                            "失敗",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        /// <summary>
        /// 認証の更新に失敗したときのメッセージボックス
        /// </summary>
        static public void FailureUpdateOuthTokenMessageBox()
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
        static public void InvalidLoginExceptionMessageBox()
        {
            MessageBox.Show("パスワード等が保存されていないか、外部からパスワード等を変更されたために認証が更新されずに寿命を迎えてしまいました。\n" +
                    "お手数をおかけしますが今の作業等を全てやめて、再度ログインしてくださりますようお願いいたします。" +
                    "尚、作業中のデータは失われるかもしれません。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        static public void AlreadyUsedUserIdNameErrorMessageBox()
        {
            MessageBox.Show("あなたが指定したユーザーIDは既にほかの人に使われています。ほかのユーザーIDをご検討ください。",
                            "失敗",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }
    }
}
