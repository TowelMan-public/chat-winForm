
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IsSavePassword = new System.Windows.Forms.CheckBox();
            this.LoginButtom = new System.Windows.Forms.Button();
            this.SignupButtom = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(349, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 24);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(349, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 24);
            this.textBox2.TabIndex = 15;
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
            // IsSavePassword
            // 
            this.IsSavePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsSavePassword.AutoSize = true;
            this.IsSavePassword.ForeColor = System.Drawing.Color.White;
            this.IsSavePassword.Location = new System.Drawing.Point(314, 307);
            this.IsSavePassword.Name = "IsSavePassword";
            this.IsSavePassword.Size = new System.Drawing.Size(204, 19);
            this.IsSavePassword.TabIndex = 17;
            this.IsSavePassword.Text = "パスワードをこのPCに保持する";
            this.IsSavePassword.UseVisualStyleBackColor = true;
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
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignupButtom);
            this.Controls.Add(this.LoginButtom);
            this.Controls.Add(this.IsSavePassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.IsSavePassword, 0);
            this.Controls.SetChildIndex(this.LoginButtom, 0);
            this.Controls.SetChildIndex(this.SignupButtom, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox IsSavePassword;
        private System.Windows.Forms.Button LoginButtom;
        private System.Windows.Forms.Button SignupButtom;
    }
}
