
namespace chat_winForm.Forms
{
    partial class HomeForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.TalkRoomListPanel = new System.Windows.Forms.Panel();
            this.TalkRoomList = new chat_winForm.Control.TalkRoomListControl();
            this.TalkListInTalkRoomPanel = new System.Windows.Forms.Panel();
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            this.ShowAddDialogueButton = new System.Windows.Forms.Button();
            this.ShowAddGroupButton = new System.Windows.Forms.Button();
            this.ShowUserConfingButton = new System.Windows.Forms.Button();
            this.SendPanel = new System.Windows.Forms.Panel();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.TalkRoomListPanel.SuspendLayout();
            this.TalkListInTalkRoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            this.SendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TalkRoomListPanel
            // 
            this.TalkRoomListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TalkRoomListPanel.AutoScroll = true;
            this.TalkRoomListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TalkRoomListPanel.Controls.Add(this.TalkRoomList);
            this.TalkRoomListPanel.Location = new System.Drawing.Point(88, 29);
            this.TalkRoomListPanel.Name = "TalkRoomListPanel";
            this.TalkRoomListPanel.Size = new System.Drawing.Size(249, 403);
            this.TalkRoomListPanel.TabIndex = 12;
            // 
            // TalkRoomList
            // 
            this.TalkRoomList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TalkRoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TalkRoomList.ForeColor = System.Drawing.Color.White;
            this.TalkRoomList.Location = new System.Drawing.Point(0, 0);
            this.TalkRoomList.Margin = new System.Windows.Forms.Padding(0);
            this.TalkRoomList.Name = "TalkRoomList";
            this.TalkRoomList.Size = new System.Drawing.Size(249, 403);
            this.TalkRoomList.TabIndex = 0;
            // 
            // TalkListInTalkRoomPanel
            // 
            this.TalkListInTalkRoomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TalkListInTalkRoomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TalkListInTalkRoomPanel.Controls.Add(this.SpinnerBox);
            this.TalkListInTalkRoomPanel.Location = new System.Drawing.Point(343, 29);
            this.TalkListInTalkRoomPanel.Name = "TalkListInTalkRoomPanel";
            this.TalkListInTalkRoomPanel.Size = new System.Drawing.Size(445, 276);
            this.TalkListInTalkRoomPanel.TabIndex = 13;
            // 
            // SpinnerBox
            // 
            this.SpinnerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpinnerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SpinnerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpinnerBox.Image = ((System.Drawing.Image)(resources.GetObject("SpinnerBox.Image")));
            this.SpinnerBox.Location = new System.Drawing.Point(28, 146);
            this.SpinnerBox.Name = "SpinnerBox";
            this.SpinnerBox.Size = new System.Drawing.Size(106, 106);
            this.SpinnerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinnerBox.TabIndex = 22;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // ShowAddDialogueButton
            // 
            this.ShowAddDialogueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowAddDialogueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ShowAddDialogueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowAddDialogueButton.BackgroundImage")));
            this.ShowAddDialogueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowAddDialogueButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowAddDialogueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.ShowAddDialogueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.ShowAddDialogueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAddDialogueButton.Location = new System.Drawing.Point(18, 218);
            this.ShowAddDialogueButton.Name = "ShowAddDialogueButton";
            this.ShowAddDialogueButton.Size = new System.Drawing.Size(53, 53);
            this.ShowAddDialogueButton.TabIndex = 0;
            this.ShowAddDialogueButton.UseVisualStyleBackColor = false;
            this.ShowAddDialogueButton.Click += new System.EventHandler(this.ShowAddDialogueButton_Click);
            // 
            // ShowAddGroupButton
            // 
            this.ShowAddGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowAddGroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ShowAddGroupButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowAddGroupButton.BackgroundImage")));
            this.ShowAddGroupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowAddGroupButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowAddGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.ShowAddGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.ShowAddGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAddGroupButton.Location = new System.Drawing.Point(18, 302);
            this.ShowAddGroupButton.Name = "ShowAddGroupButton";
            this.ShowAddGroupButton.Size = new System.Drawing.Size(53, 53);
            this.ShowAddGroupButton.TabIndex = 14;
            this.ShowAddGroupButton.UseVisualStyleBackColor = false;
            this.ShowAddGroupButton.Click += new System.EventHandler(this.ShowAddGroupButton_Click);
            // 
            // ShowUserConfingButton
            // 
            this.ShowUserConfingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowUserConfingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ShowUserConfingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowUserConfingButton.BackgroundImage")));
            this.ShowUserConfingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowUserConfingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowUserConfingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.ShowUserConfingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.ShowUserConfingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowUserConfingButton.Location = new System.Drawing.Point(18, 379);
            this.ShowUserConfingButton.Name = "ShowUserConfingButton";
            this.ShowUserConfingButton.Size = new System.Drawing.Size(53, 53);
            this.ShowUserConfingButton.TabIndex = 15;
            this.ShowUserConfingButton.UseVisualStyleBackColor = false;
            this.ShowUserConfingButton.Click += new System.EventHandler(this.ShowUserConfingButton_Click);
            // 
            // SendPanel
            // 
            this.SendPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendPanel.Controls.Add(this.SendTextBox);
            this.SendPanel.Controls.Add(this.SendButton);
            this.SendPanel.Location = new System.Drawing.Point(343, 311);
            this.SendPanel.Name = "SendPanel";
            this.SendPanel.Size = new System.Drawing.Size(445, 121);
            this.SendPanel.TabIndex = 16;
            // 
            // SendTextBox
            // 
            this.SendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SendTextBox.ForeColor = System.Drawing.Color.White;
            this.SendTextBox.Location = new System.Drawing.Point(0, 0);
            this.SendTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SendTextBox.MaxLength = 2000;
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(442, 92);
            this.SendTextBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.BackColor = System.Drawing.Color.Blue;
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(366, 92);
            this.SendButton.Margin = new System.Windows.Forms.Padding(0);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(76, 29);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "送信";
            this.SendButton.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendPanel);
            this.Controls.Add(this.ShowUserConfingButton);
            this.Controls.Add(this.ShowAddGroupButton);
            this.Controls.Add(this.ShowAddDialogueButton);
            this.Controls.Add(this.TalkListInTalkRoomPanel);
            this.Controls.Add(this.TalkRoomListPanel);
            this.Name = "HomeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.Controls.SetChildIndex(this.TalkRoomListPanel, 0);
            this.Controls.SetChildIndex(this.TalkListInTalkRoomPanel, 0);
            this.Controls.SetChildIndex(this.ShowAddDialogueButton, 0);
            this.Controls.SetChildIndex(this.ShowAddGroupButton, 0);
            this.Controls.SetChildIndex(this.ShowUserConfingButton, 0);
            this.Controls.SetChildIndex(this.SendPanel, 0);
            this.TalkRoomListPanel.ResumeLayout(false);
            this.TalkListInTalkRoomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            this.SendPanel.ResumeLayout(false);
            this.SendPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TalkRoomListPanel;
        private System.Windows.Forms.Panel TalkListInTalkRoomPanel;
        private System.Windows.Forms.Button ShowAddDialogueButton;
        private System.Windows.Forms.Button ShowAddGroupButton;
        private System.Windows.Forms.Button ShowUserConfingButton;
        private System.Windows.Forms.Panel SendPanel;
        private Control.TalkRoomListControl TalkRoomList;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.PictureBox SpinnerBox;
    }
}
