
namespace chat_winForm.Control
{
    partial class TalkRoomListGroupTitleControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkRoomListGroupTitleControl));
            this.TalkRoomLabel = new System.Windows.Forms.Label();
            this.OpenOrCloseLabel = new System.Windows.Forms.Label();
            this.NoticeCountColtrol = new chat_winForm.Control.NoticeControl();
            this.SuspendLayout();
            // 
            // TalkRoomLabel
            // 
            this.TalkRoomLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TalkRoomLabel.AutoSize = true;
            this.TalkRoomLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TalkRoomLabel.Location = new System.Drawing.Point(3, 11);
            this.TalkRoomLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TalkRoomLabel.Name = "TalkRoomLabel";
            this.TalkRoomLabel.Size = new System.Drawing.Size(57, 20);
            this.TalkRoomLabel.TabIndex = 0;
            this.TalkRoomLabel.Text = "label1";
            this.TalkRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenOrCloseLabel
            // 
            this.OpenOrCloseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpenOrCloseLabel.AutoSize = true;
            this.OpenOrCloseLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpenOrCloseLabel.Location = new System.Drawing.Point(132, 11);
            this.OpenOrCloseLabel.Margin = new System.Windows.Forms.Padding(0);
            this.OpenOrCloseLabel.Name = "OpenOrCloseLabel";
            this.OpenOrCloseLabel.Size = new System.Drawing.Size(28, 19);
            this.OpenOrCloseLabel.TabIndex = 1;
            this.OpenOrCloseLabel.Text = "＞";
            this.OpenOrCloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoticeCountColtrol
            // 
            this.NoticeCountColtrol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NoticeCountColtrol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoticeCountColtrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoticeCountColtrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoticeCountColtrol.BackgroundImage")));
            this.NoticeCountColtrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoticeCountColtrol.FontSize = 10F;
            this.NoticeCountColtrol.Location = new System.Drawing.Point(80, 7);
            this.NoticeCountColtrol.Margin = new System.Windows.Forms.Padding(0);
            this.NoticeCountColtrol.Name = "NoticeCountColtrol";
            this.NoticeCountColtrol.Size = new System.Drawing.Size(33, 27);
            this.NoticeCountColtrol.TabIndex = 2;
            // 
            // TalkRoomListGroupTitleControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.NoticeCountColtrol);
            this.Controls.Add(this.OpenOrCloseLabel);
            this.Controls.Add(this.TalkRoomLabel);
            this.Name = "TalkRoomListGroupTitleControl";
            this.Size = new System.Drawing.Size(160, 42);
            this.Load += new System.EventHandler(this.TalkRoomControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TalkRoomLabel;
        private System.Windows.Forms.Label OpenOrCloseLabel;
        private NoticeControl NoticeCountColtrol;
    }
}
