
namespace chat_winForm.Control
{
    partial class TalkListControl
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
            this.LoadOlderTalkButtom = new System.Windows.Forms.Button();
            this.LoadNewerTalkButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadOlderTalkButtom
            // 
            this.LoadOlderTalkButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadOlderTalkButtom.BackColor = System.Drawing.Color.Maroon;
            this.LoadOlderTalkButtom.ForeColor = System.Drawing.Color.White;
            this.LoadOlderTalkButtom.Location = new System.Drawing.Point(0, 0);
            this.LoadOlderTalkButtom.Margin = new System.Windows.Forms.Padding(0);
            this.LoadOlderTalkButtom.Name = "LoadOlderTalkButtom";
            this.LoadOlderTalkButtom.Size = new System.Drawing.Size(543, 25);
            this.LoadOlderTalkButtom.TabIndex = 0;
            this.LoadOlderTalkButtom.Text = "もっと古いトークを読み込む";
            this.LoadOlderTalkButtom.UseVisualStyleBackColor = false;
            // 
            // LoadNewerTalkButtom
            // 
            this.LoadNewerTalkButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadNewerTalkButtom.BackColor = System.Drawing.Color.Maroon;
            this.LoadNewerTalkButtom.ForeColor = System.Drawing.Color.White;
            this.LoadNewerTalkButtom.Location = new System.Drawing.Point(0, 54);
            this.LoadNewerTalkButtom.Margin = new System.Windows.Forms.Padding(0);
            this.LoadNewerTalkButtom.Name = "LoadNewerTalkButtom";
            this.LoadNewerTalkButtom.Size = new System.Drawing.Size(543, 25);
            this.LoadNewerTalkButtom.TabIndex = 1;
            this.LoadNewerTalkButtom.Text = "もっと新しいトークを読み込む";
            this.LoadNewerTalkButtom.UseVisualStyleBackColor = false;
            // 
            // TalkListControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.LoadNewerTalkButtom);
            this.Controls.Add(this.LoadOlderTalkButtom);
            this.Name = "TalkListControl";
            this.Size = new System.Drawing.Size(543, 80);
            this.Load += new System.EventHandler(this.TalkListControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadOlderTalkButtom;
        private System.Windows.Forms.Button LoadNewerTalkButtom;
    }
}
