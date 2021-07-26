
namespace chat_winForm.Forms
{
    partial class AddDialogueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDialogueForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIdNameTextBox = new System.Windows.Forms.TextBox();
            this.AddDialogueButton = new System.Windows.Forms.Button();
            this.AddDialogueErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddDialogueErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "友達追加";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "追加したいユーザーID：";
            // 
            // UserIdNameTextBox
            // 
            this.UserIdNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserIdNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.UserIdNameTextBox.Location = new System.Drawing.Point(309, 181);
            this.UserIdNameTextBox.Name = "UserIdNameTextBox";
            this.UserIdNameTextBox.Size = new System.Drawing.Size(313, 27);
            this.UserIdNameTextBox.TabIndex = 14;
            this.UserIdNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserIdNameTextBox_Validating);
            this.UserIdNameTextBox.Validated += new System.EventHandler(this.UserIdNameTextBox_Validated);
            // 
            // AddDialogueButton
            // 
            this.AddDialogueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDialogueButton.BackColor = System.Drawing.Color.Blue;
            this.AddDialogueButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.AddDialogueButton.ForeColor = System.Drawing.Color.White;
            this.AddDialogueButton.Location = new System.Drawing.Point(259, 303);
            this.AddDialogueButton.Name = "AddDialogueButton";
            this.AddDialogueButton.Size = new System.Drawing.Size(255, 76);
            this.AddDialogueButton.TabIndex = 15;
            this.AddDialogueButton.Text = "友達に追加";
            this.AddDialogueButton.UseVisualStyleBackColor = false;
            this.AddDialogueButton.Click += new System.EventHandler(this.AddDialogueButton_Click);
            // 
            // AddDialogueErrorProvider
            // 
            this.AddDialogueErrorProvider.BlinkRate = 100;
            this.AddDialogueErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AddDialogueErrorProvider.ContainerControl = this;
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
            this.SpinnerBox.TabIndex = 24;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // AddDialogueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpinnerBox);
            this.Controls.Add(this.AddDialogueButton);
            this.Controls.Add(this.UserIdNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(670, 390);
            this.Name = "AddDialogueForm";
            this.Load += new System.EventHandler(this.AddDialogueForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.UserIdNameTextBox, 0);
            this.Controls.SetChildIndex(this.AddDialogueButton, 0);
            this.Controls.SetChildIndex(this.SpinnerBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.AddDialogueErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserIdNameTextBox;
        private System.Windows.Forms.Button AddDialogueButton;
        private System.Windows.Forms.ErrorProvider AddDialogueErrorProvider;
        private System.Windows.Forms.PictureBox SpinnerBox;
    }
}
