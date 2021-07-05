
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
            this.Inner = new chat_winForm.Control.TalkInnerControl();
            this.SuspendLayout();
            // 
            // Inner
            // 
            this.Inner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Inner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Inner.ForeColor = System.Drawing.Color.White;
            this.Inner.Location = new System.Drawing.Point(11, 0);
            this.Inner.Margin = new System.Windows.Forms.Padding(0);
            this.Inner.Model = null;
            this.Inner.Name = "Inner";
            this.Inner.Size = new System.Drawing.Size(99, 83);
            this.Inner.TabIndex = 0;
            // 
            // TalkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.Inner);
            this.Name = "TalkControl";
            this.Size = new System.Drawing.Size(262, 83);
            this.Load += new System.EventHandler(this.TalkControl_Load);
            this.SizeChanged += new System.EventHandler(this.TalkControl_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private TalkInnerControl Inner;
    }
}
