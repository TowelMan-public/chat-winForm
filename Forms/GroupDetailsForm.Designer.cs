
namespace chat_winForm.Forms
{
    partial class GroupDetailsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupDetailsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.InvitationUserIdNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeGroupNameButton = new System.Windows.Forms.Button();
            this.DeleteGroupButton = new System.Windows.Forms.Button();
            this.InvitationUserButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserInGroupList = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BrockGroupButton = new System.Windows.Forms.Button();
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.UserInGroupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 50);
            this.label1.TabIndex = 23;
            this.label1.Text = "グループ詳細";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "グループ名：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "招待するユーザーID：";
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GroupNameTextBox.Location = new System.Drawing.Point(221, 89);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(314, 27);
            this.GroupNameTextBox.TabIndex = 28;
            this.GroupNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.GroupNameTextBox_Validating);
            // 
            // InvitationUserIdNameTextBox
            // 
            this.InvitationUserIdNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InvitationUserIdNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InvitationUserIdNameTextBox.Location = new System.Drawing.Point(221, 144);
            this.InvitationUserIdNameTextBox.Name = "InvitationUserIdNameTextBox";
            this.InvitationUserIdNameTextBox.Size = new System.Drawing.Size(314, 27);
            this.InvitationUserIdNameTextBox.TabIndex = 29;
            this.InvitationUserIdNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.InvitationUserIdNameTextBox_Validating);
            // 
            // ChangeGroupNameButton
            // 
            this.ChangeGroupNameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChangeGroupNameButton.BackColor = System.Drawing.Color.Blue;
            this.ChangeGroupNameButton.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChangeGroupNameButton.ForeColor = System.Drawing.Color.White;
            this.ChangeGroupNameButton.Location = new System.Drawing.Point(541, 89);
            this.ChangeGroupNameButton.Name = "ChangeGroupNameButton";
            this.ChangeGroupNameButton.Size = new System.Drawing.Size(75, 27);
            this.ChangeGroupNameButton.TabIndex = 30;
            this.ChangeGroupNameButton.Text = "変更";
            this.ChangeGroupNameButton.UseVisualStyleBackColor = false;
            this.ChangeGroupNameButton.Click += new System.EventHandler(this.ChangeGroupNameButton_Click);
            // 
            // DeleteGroupButton
            // 
            this.DeleteGroupButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteGroupButton.BackColor = System.Drawing.Color.Red;
            this.DeleteGroupButton.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteGroupButton.ForeColor = System.Drawing.Color.White;
            this.DeleteGroupButton.Location = new System.Drawing.Point(622, 89);
            this.DeleteGroupButton.Name = "DeleteGroupButton";
            this.DeleteGroupButton.Size = new System.Drawing.Size(160, 27);
            this.DeleteGroupButton.TabIndex = 30;
            this.DeleteGroupButton.Text = "このグループの削除";
            this.DeleteGroupButton.UseVisualStyleBackColor = false;
            this.DeleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            // 
            // InvitationUserButton
            // 
            this.InvitationUserButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InvitationUserButton.BackColor = System.Drawing.Color.Blue;
            this.InvitationUserButton.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InvitationUserButton.ForeColor = System.Drawing.Color.White;
            this.InvitationUserButton.Location = new System.Drawing.Point(541, 144);
            this.InvitationUserButton.Name = "InvitationUserButton";
            this.InvitationUserButton.Size = new System.Drawing.Size(75, 27);
            this.InvitationUserButton.TabIndex = 31;
            this.InvitationUserButton.Text = "招待";
            this.InvitationUserButton.UseVisualStyleBackColor = false;
            this.InvitationUserButton.Click += new System.EventHandler(this.InvitationUserButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(288, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "ユーザー一覧";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.UserInGroupList);
            this.panel1.Location = new System.Drawing.Point(141, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 173);
            this.panel1.TabIndex = 33;
            // 
            // UserInGroupList
            // 
            this.UserInGroupList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInGroupList.ColumnCount = 3;
            this.UserInGroupList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserInGroupList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserInGroupList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.UserInGroupList.Controls.Add(this.label8, 2, 0);
            this.UserInGroupList.Controls.Add(this.label7, 1, 0);
            this.UserInGroupList.Controls.Add(this.label6, 0, 0);
            this.UserInGroupList.Location = new System.Drawing.Point(3, 3);
            this.UserInGroupList.Name = "UserInGroupList";
            this.UserInGroupList.RowCount = 1;
            this.UserInGroupList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserInGroupList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UserInGroupList.Size = new System.Drawing.Size(486, 54);
            this.UserInGroupList.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(423, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 54);
            this.label8.TabIndex = 2;
            this.label8.Text = "削除";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(213, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 54);
            this.label7.TabIndex = 1;
            this.label7.Text = "ユーザーID ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 54);
            this.label6.TabIndex = 0;
            this.label6.Text = "ニックネーム";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupErrorProvider
            // 
            this.GroupErrorProvider.BlinkRate = 100;
            this.GroupErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.GroupErrorProvider.ContainerControl = this;
            // 
            // BrockGroupButton
            // 
            this.BrockGroupButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrockGroupButton.BackColor = System.Drawing.Color.Red;
            this.BrockGroupButton.ForeColor = System.Drawing.Color.White;
            this.BrockGroupButton.Location = new System.Drawing.Point(258, 177);
            this.BrockGroupButton.Name = "BrockGroupButton";
            this.BrockGroupButton.Size = new System.Drawing.Size(256, 23);
            this.BrockGroupButton.TabIndex = 34;
            this.BrockGroupButton.Text = "脱退する";
            this.BrockGroupButton.UseVisualStyleBackColor = false;
            this.BrockGroupButton.Click += new System.EventHandler(this.BrockGroupButton_Click);
            // 
            // SpinnerBox
            // 
            this.SpinnerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpinnerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SpinnerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpinnerBox.Image = ((System.Drawing.Image)(resources.GetObject("SpinnerBox.Image")));
            this.SpinnerBox.Location = new System.Drawing.Point(320, 177);
            this.SpinnerBox.Name = "SpinnerBox";
            this.SpinnerBox.Size = new System.Drawing.Size(106, 106);
            this.SpinnerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinnerBox.TabIndex = 35;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // GroupDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpinnerBox);
            this.Controls.Add(this.BrockGroupButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InvitationUserButton);
            this.Controls.Add(this.DeleteGroupButton);
            this.Controls.Add(this.ChangeGroupNameButton);
            this.Controls.Add(this.InvitationUserIdNameTextBox);
            this.Controls.Add(this.GroupNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GroupDetailsForm";
            this.Load += new System.EventHandler(this.GroupDetailsForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.GroupNameTextBox, 0);
            this.Controls.SetChildIndex(this.InvitationUserIdNameTextBox, 0);
            this.Controls.SetChildIndex(this.ChangeGroupNameButton, 0);
            this.Controls.SetChildIndex(this.DeleteGroupButton, 0);
            this.Controls.SetChildIndex(this.InvitationUserButton, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.BrockGroupButton, 0);
            this.Controls.SetChildIndex(this.SpinnerBox, 0);
            this.panel1.ResumeLayout(false);
            this.UserInGroupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.TextBox InvitationUserIdNameTextBox;
        private System.Windows.Forms.Button ChangeGroupNameButton;
        private System.Windows.Forms.Button DeleteGroupButton;
        private System.Windows.Forms.Button InvitationUserButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel UserInGroupList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider GroupErrorProvider;
        private System.Windows.Forms.Button BrockGroupButton;
        private System.Windows.Forms.PictureBox SpinnerBox;
    }
}
