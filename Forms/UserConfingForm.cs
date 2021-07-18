using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Registry;
using chat_winForm.Regular;
using chat_winForm.Service;
using System;
using System.Threading.Tasks;

namespace chat_winForm.Forms
{
    /// <summary>
    /// ユーザー設定画面
    /// </summary>
    public partial class UserConfingForm : chat_winForm.OuterForm
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserConfingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// この画面が読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void UserConfingForm_Load(object sender, EventArgs e)
        {
            if (userCredentialsProvider.UserIdName == null || userCredentialsProvider.Password == null)
            {
                Close();
                return;
            }

            //パスワード
            PasswordTextBox.PasswordChar = '*';
            OneMorePasswordTextBox.PasswordChar = '*';

            try
            {
                StartSpinnerMode();
                UserIdNameTextBox.Text = userCredentialsProvider.UserIdName;
                UserNameTextBox.Text = await Task.Run(() => { return UserService.GetMyUserName(); });
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// ユーザー名を変更するボタンがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void UpdateUserNameButton_Click(object sender, EventArgs e)
        {
            if (UserConfingErrorProvider.GetError(UserNameTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();
                await Task.Run(() => { UserService.UpdateUserName(UserNameTextBox.Text); });
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// ユーザーID名を変更するボタンがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void UpdateUserIdNameButton_Click(object sender, EventArgs e)
        {
            if (UserConfingErrorProvider.GetError(UserIdNameTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();
                await Task.Run(() => { UserService.UpdateUserIdName(UserIdNameTextBox.Text); });
                userCredentialsProvider.UserIdName = UserIdNameTextBox.Text;
            }
            catch (AlreadyUsedUserIdNameException)
            {
                CommonMessageBoxs.AlreadyUsedUserIdNameErrorMessageBox();
                UserConfingErrorProvider.SetError(UserIdNameTextBox, ValidateMessage.ALREADY_USED_USER_ID_NAME_MESSAGE);
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// パスワードを変更するボタンがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            if (UserConfingErrorProvider.GetError(PasswordTextBox) != "" ||
                UserConfingErrorProvider.GetError(OneMorePasswordTextBox) != "" ||
                PasswordIsNotMatchLabel.Visible)
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();
                await Task.Run(() => { UserService.UpdatePassword(PasswordTextBox.Text); });
                userCredentialsProvider.Password = PasswordTextBox.Text;
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// 退会確認表示ボタンがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void ShowWithdrawalFormButton_Click(object sender, EventArgs e)
        {
            WithdrawalForm withdrawalForm = new WithdrawalForm();
            withdrawalForm.Show();
            Close();
        }

        /// <summary>
        /// この機種からユーザー情報を削除するボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void DeleteUserMemoButton_Click(object sender, EventArgs e)
        {
            userCredentialsProvider.DeletePassword();
            OuthTokenUpdater.GetInstance().Stop();
            Close();
        }

        /// <summary>
        /// ユーザー名のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void UserNameTextBox_Validated(object sender, EventArgs e)
        {
            UserConfingErrorProvider.SetError(UserNameTextBox,
                new Validater(UserNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        /// <summary>
        /// ユーザーID名のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void UserIdNameTextBox_Validated(object sender, EventArgs e)
        {
            UserConfingErrorProvider.SetError(UserIdNameTextBox,
                new Validater(UserIdNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        /// <summary>
        /// パスワードのバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void PasswordTextBox_Validated(object sender, EventArgs e)
        {
            UserConfingErrorProvider.SetError(PasswordTextBox,
                new Validater(PasswordTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());

            PasswordIsNotMatchLabel.Visible = PasswordTextBox.Text != OneMorePasswordTextBox.Text;
        }

        /// <summary>
        /// パスワード（もう一回）のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void OneMorePasswordTextBox_Validated(object sender, EventArgs e)
        {
            UserConfingErrorProvider.SetError(OneMorePasswordTextBox,
                new Validater(OneMorePasswordTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());

            PasswordIsNotMatchLabel.Visible = PasswordTextBox.Text != OneMorePasswordTextBox.Text;
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
