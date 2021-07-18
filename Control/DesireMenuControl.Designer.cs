
namespace chat_winForm.Control
{
    partial class DesireMenuControl
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
            this.BrockButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrockButton
            // 
            this.BrockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BrockButton.BackColor = System.Drawing.Color.Red;
            this.BrockButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BrockButton.ForeColor = System.Drawing.Color.White;
            this.BrockButton.Location = new System.Drawing.Point(126, 0);
            this.BrockButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrockButton.Name = "BrockButton";
            this.BrockButton.Size = new System.Drawing.Size(78, 89);
            this.BrockButton.TabIndex = 2;
            this.BrockButton.Text = "ブロックする";
            this.BrockButton.UseVisualStyleBackColor = false;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AcceptButton.BackColor = System.Drawing.Color.Blue;
            this.AcceptButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(204, 0);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(78, 89);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "受け入れる";
            this.AcceptButton.UseVisualStyleBackColor = false;
            // 
            // DesireMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.BrockButton);
            this.Name = "DesireMenuControl";
            this.Size = new System.Drawing.Size(413, 89);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrockButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}
