
namespace chat_winForm.Forms
{
    partial class UserConfingForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserConfingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserIdNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.OneMorePasswordTextBox = new System.Windows.Forms.TextBox();
            this.UpdateUserNameButton = new System.Windows.Forms.Button();
            this.UpdateUserIdNameButton = new System.Windows.Forms.Button();
            this.UpdatePasswordButton = new System.Windows.Forms.Button();
            this.ShowWithdrawalFormButton = new System.Windows.Forms.Button();
            this.UserConfingErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordIsNotMatchLabel = new System.Windows.Forms.Label();
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            this.DeleteUserMemoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserConfingErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ユーザー設定";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(137, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "ニックネーム：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "ユーザーID：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(142, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "パスワード：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "パスワード（もう一度）：";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTextBox.Location = new System.Drawing.Point(297, 84);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(335, 29);
            this.UserNameTextBox.TabIndex = 18;
            this.UserNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserNameTextBox_Validating);
            this.UserNameTextBox.Validated += new System.EventHandler(this.UserNameTextBox_Validated);
            // 
            // UserIdNameTextBox
            // 
            this.UserIdNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserIdNameTextBox.Location = new System.Drawing.Point(297, 170);
            this.UserIdNameTextBox.Name = "UserIdNameTextBox";
            this.UserIdNameTextBox.Size = new System.Drawing.Size(335, 29);
            this.UserIdNameTextBox.TabIndex = 19;
            this.UserIdNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserIdNameTextBox_Validating);
            this.UserIdNameTextBox.Validated += new System.EventHandler(this.UserIdNameTextBox_Validated);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(297, 260);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(335, 29);
            this.PasswordTextBox.TabIndex = 20;
            this.PasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBox_Validating);
            this.PasswordTextBox.Validated += new System.EventHandler(this.PasswordTextBox_Validated);
            // 
            // OneMorePasswordTextBox
            // 
            this.OneMorePasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OneMorePasswordTextBox.Location = new System.Drawing.Point(297, 310);
            this.OneMorePasswordTextBox.Name = "OneMorePasswordTextBox";
            this.OneMorePasswordTextBox.Size = new System.Drawing.Size(335, 29);
            this.OneMorePasswordTextBox.TabIndex = 21;
            this.OneMorePasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OneMorePasswordTextBox_Validating);
            this.OneMorePasswordTextBox.Validated += new System.EventHandler(this.OneMorePasswordTextBox_Validated);
            // 
            // UpdateUserNameButton
            // 
            this.UpdateUserNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateUserNameButton.BackColor = System.Drawing.Color.Blue;
            this.UpdateUserNameButton.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.UpdateUserNameButton.ForeColor = System.Drawing.Color.White;
            this.UpdateUserNameButton.Location = new System.Drawing.Point(659, 69);
            this.UpdateUserNameButton.Name = "UpdateUserNameButton";
            this.UpdateUserNameButton.Size = new System.Drawing.Size(123, 51);
            this.UpdateUserNameButton.TabIndex = 22;
            this.UpdateUserNameButton.Text = "変更";
            this.UpdateUserNameButton.UseVisualStyleBackColor = false;
            this.UpdateUserNameButton.Click += new System.EventHandler(this.UpdateUserNameButton_Click);
            // 
            // UpdateUserIdNameButton
            // 
            this.UpdateUserIdNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateUserIdNameButton.BackColor = System.Drawing.Color.Blue;
            this.UpdateUserIdNameButton.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.UpdateUserIdNameButton.ForeColor = System.Drawing.Color.White;
            this.UpdateUserIdNameButton.Location = new System.Drawing.Point(659, 155);
            this.UpdateUserIdNameButton.Name = "UpdateUserIdNameButton";
            this.UpdateUserIdNameButton.Size = new System.Drawing.Size(123, 51);
            this.UpdateUserIdNameButton.TabIndex = 23;
            this.UpdateUserIdNameButton.Text = "変更";
            this.UpdateUserIdNameButton.UseVisualStyleBackColor = false;
            this.UpdateUserIdNameButton.Click += new System.EventHandler(this.UpdateUserIdNameButton_Click);
            // 
            // UpdatePasswordButton
            // 
            this.UpdatePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdatePasswordButton.BackColor = System.Drawing.Color.Blue;
            this.UpdatePasswordButton.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.UpdatePasswordButton.ForeColor = System.Drawing.Color.White;
            this.UpdatePasswordButton.Location = new System.Drawing.Point(659, 269);
            this.UpdatePasswordButton.Name = "UpdatePasswordButton";
            this.UpdatePasswordButton.Size = new System.Drawing.Size(123, 51);
            this.UpdatePasswordButton.TabIndex = 24;
            this.UpdatePasswordButton.Text = "変更";
            this.UpdatePasswordButton.UseVisualStyleBackColor = false;
            this.UpdatePasswordButton.Click += new System.EventHandler(this.UpdatePasswordButton_Click);
            // 
            // ShowWithdrawalFormButton
            // 
            this.ShowWithdrawalFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowWithdrawalFormButton.BackColor = System.Drawing.Color.Red;
            this.ShowWithdrawalFormButton.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.ShowWithdrawalFormButton.ForeColor = System.Drawing.Color.White;
            this.ShowWithdrawalFormButton.Location = new System.Drawing.Point(444, 381);
            this.ShowWithdrawalFormButton.Name = "ShowWithdrawalFormButton";
            this.ShowWithdrawalFormButton.Size = new System.Drawing.Size(316, 51);
            this.ShowWithdrawalFormButton.TabIndex = 25;
            this.ShowWithdrawalFormButton.Text = "退会する";
            this.ShowWithdrawalFormButton.UseVisualStyleBackColor = false;
            this.ShowWithdrawalFormButton.Click += new System.EventHandler(this.ShowWithdrawalFormButton_Click);
            // 
            // UserConfingErrorProvider
            // 
            this.UserConfingErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.UserConfingErrorProvider.ContainerControl = this;
            // 
            // PasswordIsNotMatchLabel
            // 
            this.PasswordIsNotMatchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordIsNotMatchLabel.AutoSize = true;
            this.PasswordIsNotMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordIsNotMatchLabel.Location = new System.Drawing.Point(255, 342);
            this.PasswordIsNotMatchLabel.Name = "PasswordIsNotMatchLabel";
            this.PasswordIsNotMatchLabel.Size = new System.Drawing.Size(426, 22);
            this.PasswordIsNotMatchLabel.TabIndex = 26;
            this.PasswordIsNotMatchLabel.Text = "2つのパスワードが一致しません。ご確認ください。";
            this.PasswordIsNotMatchLabel.Visible = false;
            // 
            // SpinnerBox
            // 
            this.SpinnerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpinnerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SpinnerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpinnerBox.Image = ((System.Drawing.Image)(resources.GetObject("SpinnerBox.Image")));
            this.SpinnerBox.Location = new System.Drawing.Point(347, 172);
            this.SpinnerBox.Name = "SpinnerBox";
            this.SpinnerBox.Size = new System.Drawing.Size(106, 106);
            this.SpinnerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinnerBox.TabIndex = 27;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // DeleteUserMemoButton
            // 
            this.DeleteUserMemoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteUserMemoButton.BackColor = System.Drawing.Color.Blue;
            this.DeleteUserMemoButton.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.DeleteUserMemoButton.ForeColor = System.Drawing.Color.White;
            this.DeleteUserMemoButton.Location = new System.Drawing.Point(30, 381);
            this.DeleteUserMemoButton.Name = "DeleteUserMemoButton";
            this.DeleteUserMemoButton.Size = new System.Drawing.Size(322, 51);
            this.DeleteUserMemoButton.TabIndex = 28;
            this.DeleteUserMemoButton.Text = "この機種のユーザー情報を消す";
            this.DeleteUserMemoButton.UseVisualStyleBackColor = false;
            this.DeleteUserMemoButton.Click += new System.EventHandler(this.DeleteUserMemoButton_Click);
            // 
            // UserConfingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteUserMemoButton);
            this.Controls.Add(this.SpinnerBox);
            this.Controls.Add(this.PasswordIsNotMatchLabel);
            this.Controls.Add(this.ShowWithdrawalFormButton);
            this.Controls.Add(this.UpdatePasswordButton);
            this.Controls.Add(this.UpdateUserIdNameButton);
            this.Controls.Add(this.UpdateUserNameButton);
            this.Controls.Add(this.OneMorePasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserIdNameTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "UserConfingForm";
            this.Load += new System.EventHandler(this.UserConfingForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.UserNameTextBox, 0);
            this.Controls.SetChildIndex(this.UserIdNameTextBox, 0);
            this.Controls.SetChildIndex(this.PasswordTextBox, 0);
            this.Controls.SetChildIndex(this.OneMorePasswordTextBox, 0);
            this.Controls.SetChildIndex(this.UpdateUserNameButton, 0);
            this.Controls.SetChildIndex(this.UpdateUserIdNameButton, 0);
            this.Controls.SetChildIndex(this.UpdatePasswordButton, 0);
            this.Controls.SetChildIndex(this.ShowWithdrawalFormButton, 0);
            this.Controls.SetChildIndex(this.PasswordIsNotMatchLabel, 0);
            this.Controls.SetChildIndex(this.SpinnerBox, 0);
            this.Controls.SetChildIndex(this.DeleteUserMemoButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UserConfingErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox UserIdNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox OneMorePasswordTextBox;
        private System.Windows.Forms.Button UpdateUserNameButton;
        private System.Windows.Forms.Button UpdateUserIdNameButton;
        private System.Windows.Forms.Button UpdatePasswordButton;
        private System.Windows.Forms.Button ShowWithdrawalFormButton;
        private System.Windows.Forms.ErrorProvider UserConfingErrorProvider;
        private System.Windows.Forms.Label PasswordIsNotMatchLabel;
        private System.Windows.Forms.PictureBox SpinnerBox;
        private System.Windows.Forms.Button DeleteUserMemoButton;
    }
}
