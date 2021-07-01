
namespace chat_winForm
{
    partial class OuterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OuterForm));
            this.RightSizeChenger = new System.Windows.Forms.Panel();
            this.LeftSizeChenger = new System.Windows.Forms.Panel();
            this.TopSizeChanger = new System.Windows.Forms.Panel();
            this.ReReSizeButton = new System.Windows.Forms.Button();
            this.BottomSizeChanger = new System.Windows.Forms.Panel();
            this.LeftTopSizeChanger = new System.Windows.Forms.Panel();
            this.RightTopSizeChanger = new System.Windows.Forms.Panel();
            this.LeftBottomSizeChanger = new System.Windows.Forms.Panel();
            this.RightButtonSizeChanger = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ReSizeButton = new System.Windows.Forms.Button();
            this.ToMinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RightSizeChenger
            // 
            this.RightSizeChenger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightSizeChenger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightSizeChenger.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightSizeChenger.Location = new System.Drawing.Point(785, 15);
            this.RightSizeChenger.Margin = new System.Windows.Forms.Padding(0);
            this.RightSizeChenger.Name = "RightSizeChenger";
            this.RightSizeChenger.Size = new System.Drawing.Size(15, 420);
            this.RightSizeChenger.TabIndex = 0;
            this.RightSizeChenger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            this.RightSizeChenger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightSizeChanger_MouseMove);
            // 
            // LeftSizeChenger
            // 
            this.LeftSizeChenger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftSizeChenger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LeftSizeChenger.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftSizeChenger.Location = new System.Drawing.Point(0, 15);
            this.LeftSizeChenger.Margin = new System.Windows.Forms.Padding(0);
            this.LeftSizeChenger.Name = "LeftSizeChenger";
            this.LeftSizeChenger.Size = new System.Drawing.Size(15, 420);
            this.LeftSizeChenger.TabIndex = 1;
            this.LeftSizeChenger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            this.LeftSizeChenger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftSizeChanger_MouseMove);
            // 
            // TopSizeChanger
            // 
            this.TopSizeChanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopSizeChanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopSizeChanger.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopSizeChanger.Location = new System.Drawing.Point(15, 0);
            this.TopSizeChanger.Margin = new System.Windows.Forms.Padding(0);
            this.TopSizeChanger.Name = "TopSizeChanger";
            this.TopSizeChanger.Size = new System.Drawing.Size(770, 15);
            this.TopSizeChanger.TabIndex = 2;
            this.TopSizeChanger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            this.TopSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopSizeChanger_MouseMove);
            // 
            // ReReSizeButton
            // 
            this.ReReSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReReSizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReReSizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReReSizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReReSizeButton.BackgroundImage")));
            this.ReReSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReReSizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReReSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReReSizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.ReReSizeButton.Location = new System.Drawing.Point(671, 3);
            this.ReReSizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReReSizeButton.Name = "ReReSizeButton";
            this.ReReSizeButton.Size = new System.Drawing.Size(63, 22);
            this.ReReSizeButton.TabIndex = 11;
            this.ReReSizeButton.UseVisualStyleBackColor = false;
            this.ReReSizeButton.Click += new System.EventHandler(this.ReReSizeButton_Click);
            // 
            // BottomSizeChanger
            // 
            this.BottomSizeChanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomSizeChanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomSizeChanger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BottomSizeChanger.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomSizeChanger.Location = new System.Drawing.Point(15, 435);
            this.BottomSizeChanger.Margin = new System.Windows.Forms.Padding(0);
            this.BottomSizeChanger.Name = "BottomSizeChanger";
            this.BottomSizeChanger.Size = new System.Drawing.Size(770, 15);
            this.BottomSizeChanger.TabIndex = 3;
            this.BottomSizeChanger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            this.BottomSizeChanger.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.BottomSizeChanger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomSizeChanger_MouseMove);
            // 
            // LeftTopSizeChanger
            // 
            this.LeftTopSizeChanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LeftTopSizeChanger.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.LeftTopSizeChanger.Location = new System.Drawing.Point(0, 0);
            this.LeftTopSizeChanger.Name = "LeftTopSizeChanger";
            this.LeftTopSizeChanger.Size = new System.Drawing.Size(15, 15);
            this.LeftTopSizeChanger.TabIndex = 4;
            this.LeftTopSizeChanger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            // 
            // RightTopSizeChanger
            // 
            this.RightTopSizeChanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTopSizeChanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightTopSizeChanger.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.RightTopSizeChanger.Location = new System.Drawing.Point(785, 0);
            this.RightTopSizeChanger.Name = "RightTopSizeChanger";
            this.RightTopSizeChanger.Size = new System.Drawing.Size(15, 15);
            this.RightTopSizeChanger.TabIndex = 5;
            this.RightTopSizeChanger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            // 
            // LeftBottomSizeChanger
            // 
            this.LeftBottomSizeChanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBottomSizeChanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LeftBottomSizeChanger.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.LeftBottomSizeChanger.Location = new System.Drawing.Point(0, 435);
            this.LeftBottomSizeChanger.Name = "LeftBottomSizeChanger";
            this.LeftBottomSizeChanger.Size = new System.Drawing.Size(15, 15);
            this.LeftBottomSizeChanger.TabIndex = 6;
            this.LeftBottomSizeChanger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            // 
            // RightButtonSizeChanger
            // 
            this.RightButtonSizeChanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightButtonSizeChanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightButtonSizeChanger.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightButtonSizeChanger.Location = new System.Drawing.Point(785, 435);
            this.RightButtonSizeChanger.Name = "RightButtonSizeChanger";
            this.RightButtonSizeChanger.Size = new System.Drawing.Size(15, 15);
            this.RightButtonSizeChanger.TabIndex = 7;
            this.RightButtonSizeChanger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(734, 3);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(63, 22);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ReSizeButton
            // 
            this.ReSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReSizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReSizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReSizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReSizeButton.BackgroundImage")));
            this.ReSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReSizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.ReSizeButton.Location = new System.Drawing.Point(671, 3);
            this.ReSizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReSizeButton.Name = "ReSizeButton";
            this.ReSizeButton.Size = new System.Drawing.Size(63, 22);
            this.ReSizeButton.TabIndex = 9;
            this.ReSizeButton.UseVisualStyleBackColor = false;
            this.ReSizeButton.Click += new System.EventHandler(this.ReSizeButton_Click);
            // 
            // ToMinButton
            // 
            this.ToMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToMinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToMinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToMinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToMinButton.BackgroundImage")));
            this.ToMinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMinButton.ForeColor = System.Drawing.Color.Transparent;
            this.ToMinButton.Location = new System.Drawing.Point(608, 3);
            this.ToMinButton.Margin = new System.Windows.Forms.Padding(0);
            this.ToMinButton.Name = "ToMinButton";
            this.ToMinButton.Size = new System.Drawing.Size(63, 22);
            this.ToMinButton.TabIndex = 10;
            this.ToMinButton.UseVisualStyleBackColor = false;
            this.ToMinButton.Click += new System.EventHandler(this.ToMinButton_Click);
            // 
            // OuterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReReSizeButton);
            this.Controls.Add(this.ToMinButton);
            this.Controls.Add(this.ReSizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RightButtonSizeChanger);
            this.Controls.Add(this.LeftBottomSizeChanger);
            this.Controls.Add(this.RightTopSizeChanger);
            this.Controls.Add(this.LeftTopSizeChanger);
            this.Controls.Add(this.BottomSizeChanger);
            this.Controls.Add(this.TopSizeChanger);
            this.Controls.Add(this.LeftSizeChenger);
            this.Controls.Add(this.RightSizeChenger);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OuterForm";
            this.Text = "OuterForm";
            this.Load += new System.EventHandler(this.OuterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RightSizeChenger;
        private System.Windows.Forms.Panel LeftSizeChenger;
        private System.Windows.Forms.Panel TopSizeChanger;
        private System.Windows.Forms.Panel BottomSizeChanger;
        private System.Windows.Forms.Panel LeftTopSizeChanger;
        private System.Windows.Forms.Panel RightTopSizeChanger;
        private System.Windows.Forms.Panel LeftBottomSizeChanger;
        private System.Windows.Forms.Panel RightButtonSizeChanger;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ReSizeButton;
        private System.Windows.Forms.Button ToMinButton;
        private System.Windows.Forms.Button ReReSizeButton;
    }
}

