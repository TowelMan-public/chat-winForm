
namespace chat_winForm.Control
{
    partial class TalkControl
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
            this.SenderLabel = new System.Windows.Forms.Label();
            this.ContentTectLabel = new System.Windows.Forms.Label();
            this.TimeStampLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.Location = new System.Drawing.Point(0, 0);
            this.SenderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(43, 15);
            this.SenderLabel.TabIndex = 0;
            this.SenderLabel.Text = "label1";
            // 
            // ContentTectLabel
            // 
            this.ContentTectLabel.AutoSize = true;
            this.ContentTectLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ContentTectLabel.Location = new System.Drawing.Point(0, 20);
            this.ContentTectLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentTectLabel.Name = "ContentTectLabel";
            this.ContentTectLabel.Size = new System.Drawing.Size(63, 22);
            this.ContentTectLabel.TabIndex = 1;
            this.ContentTectLabel.Text = "label2";
            // 
            // TimeStampLabel
            // 
            this.TimeStampLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeStampLabel.AutoSize = true;
            this.TimeStampLabel.Location = new System.Drawing.Point(132, 59);
            this.TimeStampLabel.Name = "TimeStampLabel";
            this.TimeStampLabel.Size = new System.Drawing.Size(43, 15);
            this.TimeStampLabel.TabIndex = 2;
            this.TimeStampLabel.Text = "label1";
            this.TimeStampLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TalkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.TimeStampLabel);
            this.Controls.Add(this.ContentTectLabel);
            this.Controls.Add(this.SenderLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TalkControl";
            this.Size = new System.Drawing.Size(175, 74);
            this.Load += new System.EventHandler(this.TalkControl_Load);
            this.SizeChanged += new System.EventHandler(this.TalkControl_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.Label ContentTectLabel;
        private System.Windows.Forms.Label TimeStampLabel;
    }
}
