using chat_winForm.Client.Exception;
using chat_winForm.Registry;
using chat_winForm.Regular;
using chat_winForm.Service;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    public partial class LoginForm : chat_winForm.OuterForm
    {
        private static UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            //大枠のサイズ
            this.Width = 320;
            this.Height = 500;

            //PasswordTextBox
            this.PasswordTextBox.PasswordChar = '*';

            //初期動作
            var userIdName = userCredentialsProvider.UserIdName;
            var password = userCredentialsProvider.Password;
            this.UserIdNameTextBox.Text = userIdName;

            //ValidationErrorProviderの初期状態作成
            this.ValidationErrorProvider.SetError(this.PasswordTextBox, "何か入力してください");
            if (userIdName == null)
                this.ValidationErrorProvider.SetError(this.UserIdNameTextBox, "何か入力してください");

            //ログイン処理
            if (userIdName != null && password != null)
            {
                StartSpinnerMode();

                try
                {
                    var outhToken = await Task.Run(() => UserService.Login(userIdName, password));

                    userCredentialsProvider.oauthToken = outhToken;
                    OuthTokenUpdater.GetInstance().Start();

                    //画面遷移 HomeForm
                    //TODO
                    this.Close();
                }
                catch (LoginException)
                {
                    userCredentialsProvider.DeletePassword();
                }
                catch (Exception error)
                {
                    UnexpectedError(error);
                }

                FinishSpinnerMode();
            }

        }

        private async void LoginButtom_Click(object sender, EventArgs e)
        {
            //バリデーションチェック
            if(this.ValidationErrorProvider.GetError(this.UserIdNameTextBox) != "" || 
                this.ValidationErrorProvider.GetError(this.PasswordTextBox) != "")
            {
                MessageBox.Show("入力された値が不正です。テキストボックスのわきにある赤いアイコンをマウスでかざして、それに従ってください。",
                            "警告",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }

            StartSpinnerMode();

            try
            {
                //データ取得
                var userIdName = this.UserIdNameTextBox.Text;
                var password = this.PasswordTextBox.Text;

                //処理
                var outhToken = await Task.Run(() => UserService.Login(userIdName, password));
                if (this.ChackIsSavePassword.Checked)
                {
                    userCredentialsProvider.UserIdName = this.UserIdNameTextBox.Text;
                    userCredentialsProvider.Password = this.PasswordTextBox.Text;
                }

                //認証用トークンの保存
                userCredentialsProvider.oauthToken = outhToken;
                OuthTokenUpdater.GetInstance().Start();

                //画面遷移 HomeForm
                //TODO
                this.Close();
            }
            catch (LoginException)
            {
                MessageBox.Show("ログインに失敗しました。パスワードとユーザーIDを確かめてください。",
                            "失敗",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            catch(Exception error)
            {
                UnexpectedError(error);
            }

            FinishSpinnerMode();
        }

        private void SignupButtom_Click(object sender, EventArgs e)
        {
            //画面遷移 SugnupForm
            //TODO
            this.Close();
        }

        private void UserIdNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.UserIdNameTextBox.Text == null || this.UserIdNameTextBox.Text == "")
                this.ValidationErrorProvider.SetError(this.UserIdNameTextBox, "何か入力してください");
            else
                this.ValidationErrorProvider.SetError(this.UserIdNameTextBox, null);
        }

        private void PasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.PasswordTextBox.Text == null || this.PasswordTextBox.Text == "")
                this.ValidationErrorProvider.SetError(this.PasswordTextBox, "何か入力してください");
            else
                this.ValidationErrorProvider.SetError(this.PasswordTextBox, null);
        }

        private void StartSpinnerMode()
        {
            this.SpinnerBox.Visible = true;
            this.LoginButtom.Visible = false;
            this.SignupButtom.Visible = false;

        }

        private void FinishSpinnerMode()
        {
            this.SpinnerBox.Visible = false;
            this.LoginButtom.Visible = true;
            this.SignupButtom.Visible = true;
        }
    }
}
