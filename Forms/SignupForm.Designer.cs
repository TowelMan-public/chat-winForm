
namespace chat_winForm.Forms
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckIsSavePassword = new System.Windows.Forms.CheckBox();
            this.SignupButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserIdNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ValidationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "チャット♪";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "新規登録";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "ユーザーID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "ニックネーム";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(218, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "パスワード";
            // 
            // CheckIsSavePassword
            // 
            this.CheckIsSavePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckIsSavePassword.AutoSize = true;
            this.CheckIsSavePassword.ForeColor = System.Drawing.Color.White;
            this.CheckIsSavePassword.Location = new System.Drawing.Point(283, 331);
            this.CheckIsSavePassword.Name = "CheckIsSavePassword";
            this.CheckIsSavePassword.Size = new System.Drawing.Size(204, 19);
            this.CheckIsSavePassword.TabIndex = 26;
            this.CheckIsSavePassword.Text = "パスワードをこのPCに保持する";
            this.CheckIsSavePassword.UseVisualStyleBackColor = true;
            // 
            // SignupButton
            // 
            this.SignupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.SignupButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SignupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupButton.Location = new System.Drawing.Point(273, 371);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(104, 31);
            this.SignupButton.TabIndex = 27;
            this.SignupButton.Text = "新規登録";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(398, 371);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(104, 31);
            this.LoginButton.TabIndex = 28;
            this.LoginButton.Text = "ログイン画面へ";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserIdNameTextBox
            // 
            this.UserIdNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserIdNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserIdNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserIdNameTextBox.Location = new System.Drawing.Point(352, 144);
            this.UserIdNameTextBox.Name = "UserIdNameTextBox";
            this.UserIdNameTextBox.Size = new System.Drawing.Size(228, 24);
            this.UserIdNameTextBox.TabIndex = 29;
            this.UserIdNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserIdNameTextBox_Validating);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserNameTextBox.Location = new System.Drawing.Point(352, 215);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(228, 24);
            this.UserNameTextBox.TabIndex = 30;
            this.UserNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserNameTextBox_Validating);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordTextBox.Location = new System.Drawing.Point(352, 283);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(228, 24);
            this.PasswordTextBox.TabIndex = 31;
            this.PasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBox_Validating);
            // 
            // ValidationErrorProvider
            // 
            this.ValidationErrorProvider.BlinkRate = 100;
            this.ValidationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ValidationErrorProvider.ContainerControl = this;
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
            this.SpinnerBox.TabIndex = 32;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpinnerBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserIdNameTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.CheckIsSavePassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.CheckIsSavePassword, 0);
            this.Controls.SetChildIndex(this.SignupButton, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.Controls.SetChildIndex(this.UserIdNameTextBox, 0);
            this.Controls.SetChildIndex(this.UserNameTextBox, 0);
            this.Controls.SetChildIndex(this.PasswordTextBox, 0);
            this.Controls.SetChildIndex(this.SpinnerBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckIsSavePassword;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UserIdNameTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ErrorProvider ValidationErrorProvider;
        private System.Windows.Forms.PictureBox SpinnerBox;
    }
}
