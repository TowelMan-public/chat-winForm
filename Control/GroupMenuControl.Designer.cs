
namespace chat_winForm.Control
{
    partial class GroupMenuControl
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
            this.ShowGroupDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowGroupDetailsButton
            // 
            this.ShowGroupDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ShowGroupDetailsButton.BackColor = System.Drawing.Color.Blue;
            this.ShowGroupDetailsButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowGroupDetailsButton.ForeColor = System.Drawing.Color.White;
            this.ShowGroupDetailsButton.Location = new System.Drawing.Point(82, 0);
            this.ShowGroupDetailsButton.Margin = new System.Windows.Forms.Padding(0);
            this.ShowGroupDetailsButton.Name = "ShowGroupDetailsButton";
            this.ShowGroupDetailsButton.Size = new System.Drawing.Size(249, 74);
            this.ShowGroupDetailsButton.TabIndex = 4;
            this.ShowGroupDetailsButton.Text = "詳細画面へ";
            this.ShowGroupDetailsButton.UseVisualStyleBackColor = false;
            // 
            // GroupMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.ShowGroupDetailsButton);
            this.Name = "GroupMenuControl";
            this.Size = new System.Drawing.Size(421, 74);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowGroupDetailsButton;
    }
}
