﻿
namespace chat_winForm.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIdNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChackIsSavePassword = new System.Windows.Forms.CheckBox();
            this.LoginButtom = new System.Windows.Forms.Button();
            this.SignupButtom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ValidationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "ログイン";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "ユーザーID";
            // 
            // UserIdNameTextBox
            // 
            this.UserIdNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserIdNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserIdNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserIdNameTextBox.Location = new System.Drawing.Point(349, 165);
            this.UserIdNameTextBox.Name = "UserIdNameTextBox";
            this.UserIdNameTextBox.Size = new System.Drawing.Size(228, 24);
            this.UserIdNameTextBox.TabIndex = 14;
            this.UserIdNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserIdNameTextBox_Validating);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordTextBox.Location = new System.Drawing.Point(349, 247);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(228, 24);
            this.PasswordTextBox.TabIndex = 15;
            this.PasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBox_Validating);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "パスワード";
            // 
            // ChackIsSavePassword
            // 
            this.ChackIsSavePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChackIsSavePassword.AutoSize = true;
            this.ChackIsSavePassword.ForeColor = System.Drawing.Color.White;
            this.ChackIsSavePassword.Location = new System.Drawing.Point(314, 307);
            this.ChackIsSavePassword.Name = "ChackIsSavePassword";
            this.ChackIsSavePassword.Size = new System.Drawing.Size(204, 19);
            this.ChackIsSavePassword.TabIndex = 17;
            this.ChackIsSavePassword.Text = "パスワードをこのPCに保持する";
            this.ChackIsSavePassword.UseVisualStyleBackColor = true;
            // 
            // LoginButtom
            // 
            this.LoginButtom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.LoginButtom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButtom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoginButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LoginButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButtom.Location = new System.Drawing.Point(283, 359);
            this.LoginButtom.Name = "LoginButtom";
            this.LoginButtom.Size = new System.Drawing.Size(98, 31);
            this.LoginButtom.TabIndex = 18;
            this.LoginButtom.Text = "ログイン";
            this.LoginButtom.UseVisualStyleBackColor = false;
            this.LoginButtom.Click += new System.EventHandler(this.LoginButtom_Click);
            // 
            // SignupButtom
            // 
            this.SignupButtom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignupButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.SignupButtom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignupButtom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SignupButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignupButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupButtom.Location = new System.Drawing.Point(393, 359);
            this.SignupButtom.Name = "SignupButtom";
            this.SignupButtom.Size = new System.Drawing.Size(103, 31);
            this.SignupButtom.TabIndex = 19;
            this.SignupButtom.Text = "新規登録";
            this.SignupButtom.UseVisualStyleBackColor = false;
            this.SignupButtom.Click += new System.EventHandler(this.SignupButtom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "チャット♪";
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
            this.SpinnerBox.Location = new System.Drawing.Point(349, 165);
            this.SpinnerBox.Name = "SpinnerBox";
            this.SpinnerBox.Size = new System.Drawing.Size(106, 106);
            this.SpinnerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinnerBox.TabIndex = 21;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpinnerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignupButtom);
            this.Controls.Add(this.LoginButtom);
            this.Controls.Add(this.ChackIsSavePassword);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserIdNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.UserIdNameTextBox, 0);
            this.Controls.SetChildIndex(this.PasswordTextBox, 0);
            this.Controls.SetChildIndex(this.ChackIsSavePassword, 0);
            this.Controls.SetChildIndex(this.LoginButtom, 0);
            this.Controls.SetChildIndex(this.SignupButtom, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.SpinnerBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserIdNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChackIsSavePassword;
        private System.Windows.Forms.Button LoginButtom;
        private System.Windows.Forms.Button SignupButtom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ValidationErrorProvider;
        private System.Windows.Forms.PictureBox SpinnerBox;
    }
}
