
namespace chat_winForm.Forms
{
    partial class TalkEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkEditorForm));
            this.TalkContentTextBox = new System.Windows.Forms.TextBox();
            this.UpdateTalkButton = new System.Windows.Forms.Button();
            this.DeleteTalkButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TalkContentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TalkContentErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TalkContentTextBox
            // 
            this.TalkContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TalkContentTextBox.BackColor = System.Drawing.Color.Black;
            this.TalkContentTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TalkContentTextBox.ForeColor = System.Drawing.Color.White;
            this.TalkContentTextBox.Location = new System.Drawing.Point(12, 116);
            this.TalkContentTextBox.Multiline = true;
            this.TalkContentTextBox.Name = "TalkContentTextBox";
            this.TalkContentTextBox.Size = new System.Drawing.Size(773, 276);
            this.TalkContentTextBox.TabIndex = 12;
            this.TalkContentTextBox.Validated += new System.EventHandler(this.TalkContentTextBox_Validated);
            // 
            // UpdateTalkButton
            // 
            this.UpdateTalkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateTalkButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.UpdateTalkButton.Location = new System.Drawing.Point(627, 395);
            this.UpdateTalkButton.Name = "UpdateTalkButton";
            this.UpdateTalkButton.Size = new System.Drawing.Size(155, 37);
            this.UpdateTalkButton.TabIndex = 13;
            this.UpdateTalkButton.Text = "変更";
            this.UpdateTalkButton.UseVisualStyleBackColor = true;
            this.UpdateTalkButton.Click += new System.EventHandler(this.UpdateTalkButton_Click);
            // 
            // DeleteTalkButton
            // 
            this.DeleteTalkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTalkButton.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteTalkButton.Location = new System.Drawing.Point(466, 395);
            this.DeleteTalkButton.Name = "DeleteTalkButton";
            this.DeleteTalkButton.Size = new System.Drawing.Size(155, 37);
            this.DeleteTalkButton.TabIndex = 14;
            this.DeleteTalkButton.Text = "削除";
            this.DeleteTalkButton.UseVisualStyleBackColor = true;
            this.DeleteTalkButton.Click += new System.EventHandler(this.DeleteTalkButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(18, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(72, 25);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "label1";
            // 
            // TalkContentErrorProvider
            // 
            this.TalkContentErrorProvider.BlinkRate = 100;
            this.TalkContentErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.TalkContentErrorProvider.ContainerControl = this;
            // 
            // SpinnerBox
            // 
            this.SpinnerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpinnerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SpinnerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpinnerBox.Image = ((System.Drawing.Image)(resources.GetObject("SpinnerBox.Image")));
            this.SpinnerBox.Location = new System.Drawing.Point(347, 172);
            this.SpinnerBox.Name = "SpinnerBox";
            this.SpinnerBox.Size = new System.Drawing.Size(106, 106);
            this.SpinnerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinnerBox.TabIndex = 23;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // TalkEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpinnerBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DeleteTalkButton);
            this.Controls.Add(this.UpdateTalkButton);
            this.Controls.Add(this.TalkContentTextBox);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "TalkEditorForm";
            this.Load += new System.EventHandler(this.TalkEditorForm_Load);
            this.Controls.SetChildIndex(this.TalkContentTextBox, 0);
            this.Controls.SetChildIndex(this.UpdateTalkButton, 0);
            this.Controls.SetChildIndex(this.DeleteTalkButton, 0);
            this.Controls.SetChildIndex(this.TitleLabel, 0);
            this.Controls.SetChildIndex(this.SpinnerBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TalkContentErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TalkContentTextBox;
        private System.Windows.Forms.Button UpdateTalkButton;
        private System.Windows.Forms.Button DeleteTalkButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ErrorProvider TalkContentErrorProvider;
        private System.Windows.Forms.PictureBox SpinnerBox;
    }
}
