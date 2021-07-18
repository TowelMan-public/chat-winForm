
namespace chat_winForm.Control
{
    partial class DialogueMenuControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.UserIdNameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.BrockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserIdNameLabel
            // 
            this.UserIdNameLabel.AutoSize = true;
            this.UserIdNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserIdNameLabel.Location = new System.Drawing.Point(3, 19);
            this.UserIdNameLabel.Name = "UserIdNameLabel";
            this.UserIdNameLabel.Size = new System.Drawing.Size(52, 18);
            this.UserIdNameLabel.TabIndex = 0;
            this.UserIdNameLabel.Text = "label1";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserNameLabel.Location = new System.Drawing.Point(3, 50);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(52, 18);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "label1";
            // 
            // BrockButton
            // 
            this.BrockButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrockButton.BackColor = System.Drawing.Color.Red;
            this.BrockButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BrockButton.ForeColor = System.Drawing.Color.White;
            this.BrockButton.Location = new System.Drawing.Point(332, 0);
            this.BrockButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrockButton.Name = "BrockButton";
            this.BrockButton.Size = new System.Drawing.Size(78, 94);
            this.BrockButton.TabIndex = 1;
            this.BrockButton.Text = "ブロックする";
            this.BrockButton.UseVisualStyleBackColor = false;
            // 
            // DialogueMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.BrockButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserIdNameLabel);
            this.Name = "DialogueMenuControl";
            this.Size = new System.Drawing.Size(410, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserIdNameLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button BrockButton;
    }
}
