
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
            this.TtalkRoomList = new chat_winForm.Control.TalkRoomListControl();
            this.TalkListInTalkRoomPanel = new System.Windows.Forms.Panel();
            this.ShowAddDialogueButton = new System.Windows.Forms.Button();
            this.ShowAddGroupButton = new System.Windows.Forms.Button();
            this.ShowUserConfingButton = new System.Windows.Forms.Button();
            this.SendPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TalkRoomListPanel.SuspendLayout();
            this.SendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TalkRoomListPanel
            // 
            this.TalkRoomListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TalkRoomListPanel.AutoScroll = true;
            this.TalkRoomListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TalkRoomListPanel.Controls.Add(this.TtalkRoomList);
            this.TalkRoomListPanel.Location = new System.Drawing.Point(88, 29);
            this.TalkRoomListPanel.Name = "TalkRoomListPanel";
            this.TalkRoomListPanel.Size = new System.Drawing.Size(249, 403);
            this.TalkRoomListPanel.TabIndex = 12;
            // 
            // TtalkRoomList
            // 
            this.TtalkRoomList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TtalkRoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TtalkRoomList.DesireDialogueTalkRoomClickEventHandler = null;
            this.TtalkRoomList.DesireGroupTalkRoomClickEventHandler = null;
            this.TtalkRoomList.DialigueTalkRoomClickEventHandler = null;
            this.TtalkRoomList.ForeColor = System.Drawing.Color.White;
            this.TtalkRoomList.GroupTalkRoomClickEventHandler = null;
            this.TtalkRoomList.Location = new System.Drawing.Point(0, 0);
            this.TtalkRoomList.Margin = new System.Windows.Forms.Padding(0);
            this.TtalkRoomList.Name = "TtalkRoomList";
            this.TtalkRoomList.Size = new System.Drawing.Size(249, 403);
            this.TtalkRoomList.TabIndex = 0;
            // 
            // TalkListInTalkRoomPanel
            // 
            this.TalkListInTalkRoomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TalkListInTalkRoomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TalkListInTalkRoomPanel.Location = new System.Drawing.Point(343, 29);
            this.TalkListInTalkRoomPanel.Name = "TalkListInTalkRoomPanel";
            this.TalkListInTalkRoomPanel.Size = new System.Drawing.Size(445, 276);
            this.TalkListInTalkRoomPanel.TabIndex = 13;
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
            // 
            // SendPanel
            // 
            this.SendPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendPanel.Controls.Add(this.textBox1);
            this.SendPanel.Controls.Add(this.button1);
            this.SendPanel.Location = new System.Drawing.Point(343, 311);
            this.SendPanel.Name = "SendPanel";
            this.SendPanel.Size = new System.Drawing.Size(445, 121);
            this.SendPanel.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 2000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 92);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(366, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "送信";
            this.button1.UseVisualStyleBackColor = false;
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
            this.Load += new System.EventHandler(this.HomeForm_Load_1);
            this.Controls.SetChildIndex(this.TalkRoomListPanel, 0);
            this.Controls.SetChildIndex(this.TalkListInTalkRoomPanel, 0);
            this.Controls.SetChildIndex(this.ShowAddDialogueButton, 0);
            this.Controls.SetChildIndex(this.ShowAddGroupButton, 0);
            this.Controls.SetChildIndex(this.ShowUserConfingButton, 0);
            this.Controls.SetChildIndex(this.SendPanel, 0);
            this.TalkRoomListPanel.ResumeLayout(false);
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
        private Control.TalkRoomListControl TtalkRoomList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
