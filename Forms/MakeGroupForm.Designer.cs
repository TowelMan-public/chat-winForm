
namespace chat_winForm.Forms
{
    partial class MakeGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeGroupForm));
            this.label1 = new System.Windows.Forms.Label();
            this.MakeGrolupButton = new System.Windows.Forms.Button();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpinnerBox = new System.Windows.Forms.PictureBox();
            this.MakeGroupErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakeGroupErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "グループ作成";
            // 
            // MakeGrolupButton
            // 
            this.MakeGrolupButton.BackColor = System.Drawing.Color.Blue;
            this.MakeGrolupButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.MakeGrolupButton.ForeColor = System.Drawing.Color.White;
            this.MakeGrolupButton.Location = new System.Drawing.Point(246, 337);
            this.MakeGrolupButton.Name = "MakeGrolupButton";
            this.MakeGrolupButton.Size = new System.Drawing.Size(255, 76);
            this.MakeGrolupButton.TabIndex = 16;
            this.MakeGrolupButton.Text = "グループ作成";
            this.MakeGrolupButton.UseVisualStyleBackColor = false;
            this.MakeGrolupButton.Click += new System.EventHandler(this.MakeGrolupButton_Click);
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.GroupNameTextBox.Location = new System.Drawing.Point(321, 183);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(313, 27);
            this.GroupNameTextBox.TabIndex = 18;
            this.GroupNameTextBox.Validated += new System.EventHandler(this.GroupNameTextBox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "作りたいグループ名：";
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
            this.SpinnerBox.TabIndex = 25;
            this.SpinnerBox.TabStop = false;
            this.SpinnerBox.Visible = false;
            // 
            // MakeGroupErrorProvider
            // 
            this.MakeGroupErrorProvider.ContainerControl = this;
            // 
            // MakeGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpinnerBox);
            this.Controls.Add(this.GroupNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MakeGrolupButton);
            this.Controls.Add(this.label1);
            this.Name = "MakeGroupForm";
            this.Load += new System.EventHandler(this.MakeGroupForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.MakeGrolupButton, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.GroupNameTextBox, 0);
            this.Controls.SetChildIndex(this.SpinnerBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakeGroupErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MakeGrolupButton;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox SpinnerBox;
        private System.Windows.Forms.ErrorProvider MakeGroupErrorProvider;
    }
}
