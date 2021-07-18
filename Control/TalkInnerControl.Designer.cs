
namespace chat_winForm.Control
{
    partial class TalkInnerControl
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
            this.ContentTextLabel = new System.Windows.Forms.Label();
            this.TimeStampLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SenderLabel
            // 
            this.SenderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.Location = new System.Drawing.Point(0, 0);
            this.SenderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(43, 15);
            this.SenderLabel.TabIndex = 0;
            this.SenderLabel.Text = "label1";
            // 
            // ContentTextLabel
            // 
            this.ContentTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContentTextLabel.AutoSize = true;
            this.ContentTextLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ContentTextLabel.Location = new System.Drawing.Point(0, 20);
            this.ContentTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentTextLabel.Name = "ContentTextLabel";
            this.ContentTextLabel.Size = new System.Drawing.Size(63, 22);
            this.ContentTextLabel.TabIndex = 1;
            this.ContentTextLabel.Text = "label2";
            // 
            // TimeStampLabel
            // 
            this.TimeStampLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeStampLabel.AutoSize = true;
            this.TimeStampLabel.Location = new System.Drawing.Point(109, 135);
            this.TimeStampLabel.Name = "TimeStampLabel";
            this.TimeStampLabel.Size = new System.Drawing.Size(43, 15);
            this.TimeStampLabel.TabIndex = 2;
            this.TimeStampLabel.Text = "label1";
            this.TimeStampLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TalkInnerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TimeStampLabel);
            this.Controls.Add(this.ContentTextLabel);
            this.Controls.Add(this.SenderLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TalkInnerControl";
            this.Size = new System.Drawing.Size(152, 150);
            this.SizeChanged += new System.EventHandler(this.TalkControl_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.Label ContentTextLabel;
        private System.Windows.Forms.Label TimeStampLabel;
    }
}
