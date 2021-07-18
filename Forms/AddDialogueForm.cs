using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Service;
using System;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    /// <summary>
    /// 友達追加画面
    /// </summary>
    public partial class AddDialogueForm : chat_winForm.OuterForm
    {
        public delegate void Prosess();

        /// <summary>
        /// 友達追加の後処理のセット・取得
        /// </summary>
        public Prosess AddDialogue_After { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AddDialogueForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登録ボタンが押された
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void AddDialogueButton_Click(object sender, EventArgs e)
        {
            if (AddDialogueErrorProvider.GetError(UserIdNameTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();

                DialogueService.AddUserInDialogue(UserIdNameTextBox.Text);
                AddDialogue_After();
            }
            catch (NotFoundException exception)
            {
                if (!exception.IsErrorFieldUserIdName())
                {
                    throw exception;
                }

                string ERROR_MESSAGE = "あなたが入力したユーザーIDは存在しません。もう一度ご確認ください。";

                MessageBox.Show(ERROR_MESSAGE,
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                AddDialogueErrorProvider.SetError(UserIdNameTextBox, ERROR_MESSAGE);
            }
            catch (AlreadyHaveUserException)
            {
                string ERROR_MESSAGE = "あなたが指定したユーザーは既に友達です。もう一度ご確認ください。";

                MessageBox.Show(ERROR_MESSAGE,
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                AddDialogueErrorProvider.SetError(UserIdNameTextBox, ERROR_MESSAGE);
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// ユーザーID名のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void UserIdNameTextBox_Validated(object sender, EventArgs e)
        {
            AddDialogueErrorProvider.SetError(UserIdNameTextBox,
                new Validater(UserIdNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        /// <summary>
        /// このフォームで、スピナーを表示するモードにする
        /// </summary>
        private void StartSpinnerMode()
        {
            SpinnerBox.Visible = true;
            UseWaitCursor = true;

        }

        /// <summary>
        /// このフォームで、スピナーを表示するモードを終了する
        /// </summary>
        private void FinishSpinnerMode()
        {
            SpinnerBox.Visible = false;
            UseWaitCursor = false;
        }
    }
}
