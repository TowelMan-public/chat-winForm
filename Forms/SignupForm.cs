using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Registry;
using chat_winForm.Service;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    public partial class SignupForm : OuterForm
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();
        private bool IsClosedByThis;

        public SignupForm()
        {
            InitializeComponent();
            IsClosedByThis = false;
        }

        private void SignupForm_Load(object sender, System.EventArgs e)
        {
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
        }

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
                Close();
            }
            catch (AlreadyUsedUserIdNameException)
            {
                CommonMessageBoxs.AlreadyUsedUserIdNameErrorMessageBox();
                ValidationErrorProvider.SetError(UserIdNameTextBox, ValidateMessage.ALREADY_USED_USER_ID_NAME_MESSAGE);
            }
            catch (Exception)
            {
                CommonMessageBoxs.UnexpectedErrorMessageBox();
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            IsClosedByThis = true;
            Close();
        }

        private void UserIdNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = new Validater(UserIdNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage();

            ValidationErrorProvider.SetError(UserIdNameTextBox, errorMessage);
        }

        private void UserNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = new Validater(UserNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage();

            ValidationErrorProvider.SetError(UserNameTextBox, errorMessage);
        }

        private void PasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = new Validater(PasswordTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage();

            ValidationErrorProvider.SetError(PasswordTextBox, errorMessage);
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

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsClosedByThis)
                Application.Exit();
        }
    }
}
