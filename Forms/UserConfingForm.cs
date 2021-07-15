using chat_winForm.Forms.Commons;
using chat_winForm.Registry;
using chat_winForm.Regular;
using chat_winForm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    public partial class UserConfingForm : chat_winForm.OuterForm
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        public UserConfingForm()
        {
            InitializeComponent();
        }

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

            UserIdNameTextBox.Text = userCredentialsProvider.UserIdName;
            UserNameTextBox.Text = await Task.Run(() => { return UserService.GetMyUserName(); });
        }

        private async void UpdateUserNameButton_Click(object sender, EventArgs e)
        {
            if (UserConfingErrorProvider.GetError(UserNameTextBox) == null)
                return;

            StartSpinnerMode();

            await Task.Run(() => { UserService.UpdateUserName(UserNameTextBox.Text); });

            FinishSpinnerMode();
        }

        private async void UpdateUserIdNameButton_Click(object sender, EventArgs e)
        {
            if (UserConfingErrorProvider.GetError(UserIdNameTextBox) == null)
                return;

            StartSpinnerMode();

            await Task.Run(() => { UserService.UpdateUserIdName(UserIdNameTextBox.Text); });
            userCredentialsProvider.UserIdName = UserIdNameTextBox.Text;

            FinishSpinnerMode();
        }

        private async void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            if (UserConfingErrorProvider.GetError(PasswordTextBox) == null ||
                UserConfingErrorProvider.GetError(OneMorePasswordTextBox) == null ||
                PasswordIsNotMatchLabel.Visible)
                return;

            StartSpinnerMode();

            await Task.Run(() => { UserService.UpdatePassword(PasswordTextBox.Text); });
            userCredentialsProvider.Password = PasswordTextBox.Text;

            FinishSpinnerMode();
        }

        private void ShowWithdrawalFormButton_Click(object sender, EventArgs e)
        {
            var withdrawalForm = new WithdrawalForm();
            withdrawalForm.Show();
            Close();
        }

        private void DeleteUserMemoButton_Click(object sender, EventArgs e)
        {
            userCredentialsProvider.DeletePassword();
            OuthTokenUpdater.GetInstance().Stop();
            Close();
        }

        private void UserNameTextBox_Validated(object sender, EventArgs e)
        {
            UserConfingErrorProvider.SetError(UserNameTextBox,
                new Validater(UserNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        private void UserIdNameTextBox_Validated(object sender, EventArgs e)
        {
            UserConfingErrorProvider.SetError(UserIdNameTextBox,
                new Validater(UserIdNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        private void PasswordTextBox_Validated(object sender, EventArgs e)
        {
            UserConfingErrorProvider.SetError(PasswordTextBox,
                new Validater(PasswordTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());

            PasswordIsNotMatchLabel.Visible = PasswordTextBox.Text != OneMorePasswordTextBox.Text;
        }

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
