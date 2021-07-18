
namespace chat_winForm.Control
{
    partial class TalkRoomColtrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkRoomColtrol));
            this.TalkRoomLabel = new System.Windows.Forms.Label();
            this.NoticeCountColtrol = new chat_winForm.Control.NoticeControl();
            this.SuspendLayout();
            // 
            // TalkRoomLabel
            // 
            this.TalkRoomLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TalkRoomLabel.AutoSize = true;
            this.TalkRoomLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TalkRoomLabel.Location = new System.Drawing.Point(0, 4);
            this.TalkRoomLabel.Name = "TalkRoomLabel";
            this.TalkRoomLabel.Size = new System.Drawing.Size(57, 20);
            this.TalkRoomLabel.TabIndex = 1;
            this.TalkRoomLabel.Text = "label1";
            this.TalkRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoticeCountColtrol
            // 
            this.NoticeCountColtrol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NoticeCountColtrol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoticeCountColtrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoticeCountColtrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoticeCountColtrol.BackgroundImage")));
            this.NoticeCountColtrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoticeCountColtrol.FontSize = 10F;
            this.NoticeCountColtrol.Location = new System.Drawing.Point(124, 1);
            this.NoticeCountColtrol.Name = "NoticeCountColtrol";
            this.NoticeCountColtrol.Size = new System.Drawing.Size(33, 27);
            this.NoticeCountColtrol.TabIndex = 3;
            // 
            // TalkRoomColtrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.NoticeCountColtrol);
            this.Controls.Add(this.TalkRoomLabel);
            this.Name = "TalkRoomColtrol";
            this.Size = new System.Drawing.Size(160, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TalkRoomLabel;
        private NoticeControl NoticeCountColtrol;
    }
}
