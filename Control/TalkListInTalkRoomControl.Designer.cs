
namespace chat_winForm.Control
{
    partial class TalkListInTalkRoomControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkListInTalkRoomControl));
            this.SwitchButton = new System.Windows.Forms.Button();
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BodyControl = new chat_winForm.Control.TalkListControl();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SwitchButton
            // 
            this.SwitchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SwitchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchButton.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SwitchButton.Location = new System.Drawing.Point(0, 0);
            this.SwitchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchButton.MaximumSize = new System.Drawing.Size(0, 40);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(488, 40);
            this.SwitchButton.TabIndex = 1;
            this.SwitchButton.Text = "button1";
            this.SwitchButton.UseVisualStyleBackColor = false;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // SpinnerBox
            // 
            this.SpinnerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpinnerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SpinnerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpinnerBox.Image = ((System.Drawing.Image)(resources.GetObject("SpinnerBox.Image")));
            this.SpinnerBox.Location = new System.Drawing.Point(181, 112);
            this.SpinnerBox.Name = "SpinnerBox";
            this.SpinnerBox.Size = new System.Drawing.Size(106, 106);
            this.SpinnerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinnerBox.TabIndex = 33;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.SpinnerBox);
            this.panel1.Controls.Add(this.BodyControl);
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 418);
            this.panel1.TabIndex = 34;
            // 
            // BodyControl
            // 
            this.BodyControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BodyControl.Location = new System.Drawing.Point(0, 3);
            this.BodyControl.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BodyControl.Name = "BodyControl";
            this.BodyControl.NewestTalkIndex = -1;
            this.BodyControl.OldestTalkIndex = -1;
            this.BodyControl.Size = new System.Drawing.Size(482, 412);
            this.BodyControl.TabIndex = 3;
            this.BodyControl.TalkClick = null;
            this.BodyControl.TalkControlClick = null;
            // 
            // TalkListInTalkRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SwitchButton);
            this.Name = "TalkListInTalkRoomControl";
            this.Size = new System.Drawing.Size(488, 464);
            this.Load += new System.EventHandler(this.TalkListInTalkRoomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.PictureBox SpinnerBox;
        private System.Windows.Forms.Panel panel1;
        private TalkListControl BodyControl;
    }
}
