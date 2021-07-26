using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Registry;
using chat_winForm.Service;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    /// <summary>
    /// ユーザーの新規登録画面
    /// </summary>
    public partial class SignupForm : OuterForm
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();
        private bool IsClosedByThis;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SignupForm()
        {
            InitializeComponent();
            IsClosedByThis = false;
        }

        /// <summary>
        /// このフォームが読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void SignupForm_Load(object sender, System.EventArgs e)
        {
            Thread.GetDomain().UnhandledException += NoneCatchedEception_Throw;

            //大枠のサイズ
            Width = 320;
            Height = 500;
            MinimumSize = Size;

            //ValidationErrorProviderの初期状態作成
            ValidationErrorProvider.SetError(UserIdNameTextBox, ValidateMessage.INIT_MESSAGE);
            ValidationErrorProvider.SetError(UserNameTextBox, ValidateMessage.INIT_MESSAGE);
            ValidationErrorProvider.SetError(PasswordTextBox, ValidateMessage.INIT_MESSAGE);

            //PasswordTextBox
            PasswordTextBox.PasswordChar = '*';

            //バリデーション
            ValidateChildren();
        }

        /// <summary>
        /// ユーザー登録ボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void SignupButton_Click(object sender, System.EventArgs e)
        {
            //バリデーションチェック
            if (ValidationErrorProvider.GetError(UserIdNameTextBox) != "" ||
                ValidationErrorProvider.GetError(UserNameTextBox) != "" ||
                ValidationErrorProvider.GetError(PasswordTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();

                //UIからデータ取得
                string userIdName = UserIdNameTextBox.Text;
                string userName = UserNameTextBox.Text;
                string password = PasswordTextBox.Text;

                //処理
                await Task.Run(() => UserService.InsertUser(userIdName, userName, password));

                //後処理
                if (CheckIsSavePassword.Checked)
                {
                    userCredentialsProvider.UserIdName = userIdName;
                    userCredentialsProvider.Password = password;
                }

                //画面遷移
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                IsClosedByThis = true;
                Close();
            }
            catch (AlreadyUsedUserIdNameException)
            {
                CommonMessageBoxs.AlreadyUsedUserIdNameErrorMessageBox();
                ValidationErrorProvider.SetError(UserIdNameTextBox, ValidateMessage.ALREADY_USED_USER_ID_NAME_MESSAGE);
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// ログインボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.Location = Location;

            IsClosedByThis = true;
            Close();
        }

        /// <summary>
        /// ユーザーID名のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void UserIdNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = new Validater(UserIdNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage();

            ValidationErrorProvider.SetError(UserIdNameTextBox, errorMessage);
        }

        /// <summary>
        /// ユーザー名のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void UserNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = new Validater(UserNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage();

            ValidationErrorProvider.SetError(UserNameTextBox, errorMessage);
        }

        /// <summary>
        /// パスワードのバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void PasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = new Validater(PasswordTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage();

            ValidationErrorProvider.SetError(PasswordTextBox, errorMessage);
        }

        /// <summary>
        /// ユーザーID名のバリデーションチェックのイベントハンドラーの後処理
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void UserIdNameTextBox_Validated(object sender, EventArgs e)
        {
            if (ValidationErrorProvider.GetError(UserIdNameTextBox) == "")
                UserIdNameTextBox.BackColor = Color.White;
            else
                UserIdNameTextBox.BackColor = Color.Red;
        }

        /// <summary>
        /// ユーザー名のバリデーションチェックのイベントハンドラーの後処理
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void UserNameTextBox_Validated(object sender, EventArgs e)
        {
            if (ValidationErrorProvider.GetError(UserNameTextBox) == "")
                UserNameTextBox.BackColor = Color.White;
            else
                UserNameTextBox.BackColor = Color.Red;
        }

        /// <summary>
        /// パスワードのバリデーションチェックのイベントハンドラーの後処理
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void PasswordTextBox_Validated(object sender, EventArgs e)
        {
            if (ValidationErrorProvider.GetError(PasswordTextBox) == "")
                PasswordTextBox.BackColor = Color.White;
            else
                PasswordTextBox.BackColor = Color.Red;
        }

        /// <summary>
        /// この画面が閉じられた時のイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsClosedByThis)
            {
                Application.Exit();
            }
            Thread.GetDomain().UnhandledException -= NoneCatchedEception_Throw;
        }

        /// <summary>
        /// このフォームの管理下で投げられた例外の内キャッチされなかった例外を処理するイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void NoneCatchedEception_Throw(object sender, UnhandledExceptionEventArgs e)
        {
            object exceptionObject = e.ExceptionObject;

            CommonMessageBoxs.UnexpectedErrorMessageBox();
        }

        /// <summary>
        /// このフォームで、スピナーを表示するモードにする
        /// </summary>
        private void StartSpinnerMode()
        {
            SpinnerBox.Visible = true;
            UseWaitCursor = true;
            LoginButton.Visible = false;
            SignupButton.Visible = false;
        }

        /// <summary>
        /// このフォームで、スピナーを表示するモードを終了する
        /// </summary>
        private void FinishSpinnerMode()
        {
            SpinnerBox.Visible = false;
            UseWaitCursor = false;
            LoginButton.Visible = true;
            SignupButton.Visible = true;
        }
    }
}
