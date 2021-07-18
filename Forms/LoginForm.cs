using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Registry;
using chat_winForm.Regular;
using chat_winForm.Service;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    /// <summary>
    /// ログイン画面のフォーム
    /// </summary>
    public partial class LoginForm : chat_winForm.OuterForm
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        private bool IsClosedByThis;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            IsClosedByThis = false;
        }

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void LoginForm_Load(object sender, EventArgs e)
        {
            Thread.GetDomain().UnhandledException += NoneCatchedEception_Throw;

            //大枠のサイズ
            Size formSize = new Size
            {
                Width = 320,
                Height = 500
            };

            Size = formSize;
            MinimumSize = formSize;

            //PasswordTextBox
            PasswordTextBox.PasswordChar = '*';

            //値の取得とセット
            string userIdName = userCredentialsProvider.UserIdName;
            string password = userCredentialsProvider.Password;
            UserIdNameTextBox.Text = userIdName;

            //ValidationErrorProviderの初期状態作成
            ValidationErrorProvider.SetError(PasswordTextBox, ValidateMessage.INIT_MESSAGE);
            if (userIdName == null)
            {
                ValidationErrorProvider.SetError(UserIdNameTextBox, ValidateMessage.INIT_MESSAGE);
            }

            //ログイン処理
            if (userIdName != null && password != null)
            {
                try
                {
                    StartSpinnerMode();

                    //処理
                    string outhToken = await Task.Run(() => UserService.Login(userIdName, password));

                    //後処理
                    userCredentialsProvider.OauthToken = outhToken;
                    OuthTokenUpdater.GetInstance().Start();

                    //画面遷移
                    HomeForm homeForm = new HomeForm();
                    homeForm.Show();

                    IsClosedByThis = true;
                    Close();
                }
                catch (LoginException)
                {
                    CommonMessageBoxs.FailureLoginMessageBox();
                }
                finally
                {
                    FinishSpinnerMode();
                }
            }

        }

        /// <summary>
        /// ログインボタンが押されたときの処理
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            //バリデーションチェック
            if (ValidationErrorProvider.GetError(UserIdNameTextBox) != "" ||
                ValidationErrorProvider.GetError(PasswordTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();

                //データ取得
                string userIdName = UserIdNameTextBox.Text;
                string password = PasswordTextBox.Text;

                //処理
                string outhToken = await Task.Run(() => UserService.Login(userIdName, password));

                //後処理
                if (ChackIsSavePassword.Checked)
                {
                    userCredentialsProvider.Password = PasswordTextBox.Text;
                    OuthTokenUpdater.GetInstance().Start();
                }
                userCredentialsProvider.UserIdName = UserIdNameTextBox.Text;
                userCredentialsProvider.OauthToken = outhToken;

                //画面遷移
                HomeForm homeForm = new HomeForm();
                homeForm.Show();

                IsClosedByThis = true;
                Close();
            }
            catch (LoginException)
            {
                CommonMessageBoxs.FailureLoginMessageBox();
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// 新規登録ボタンが押されたときの処理
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void SignupButton_Click(object sender, EventArgs e)
        {
            //画面遷移
            SignupForm signupForm = new SignupForm();
            signupForm.Show();

            IsClosedByThis = true;
            Close();
        }

        /// <summary>
        /// ユーザーID(UserIdName)のバリデーションチェック
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
        /// パスワードのバリデーションチェック
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
        /// このフォームが閉じられた時のイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsClosedByThis)
            {
                Application.Exit();
            }
            Thread.GetDomain().UnhandledException -= NoneCatchedEception_Throw;
        }

        /// <summary>
        /// このフォームの管理下で投げられた例外で、キャッチされなかった例外を処理するイベントハンドラー
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
