
namespace chat_winForm.Control
{
    partial class NoticeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeControl));
            this.NoticeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoticeLabel
            // 
            this.NoticeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoticeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoticeLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NoticeLabel.ForeColor = System.Drawing.Color.White;
            this.NoticeLabel.Location = new System.Drawing.Point(0, 0);
            this.NoticeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NoticeLabel.Name = "NoticeLabel";
            this.NoticeLabel.Size = new System.Drawing.Size(137, 93);
            this.NoticeLabel.TabIndex = 0;
            this.NoticeLabel.Text = "1";
            this.NoticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoticeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.NoticeLabel);
            this.Name = "NoticeControl";
            this.Size = new System.Drawing.Size(137, 93);
            this.Load += new System.EventHandler(this.NoticeControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NoticeLabel;
    }
}
