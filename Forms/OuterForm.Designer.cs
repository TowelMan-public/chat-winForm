
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
            this.BottomSizeChanger = new System.Windows.Forms.Panel();
            this.LeftTopSizeChanger = new System.Windows.Forms.Panel();
            this.RightTopSizeChanger = new System.Windows.Forms.Panel();
            this.LeftBottomSizeChanger = new System.Windows.Forms.Panel();
            this.RightButtomSizeChanger = new System.Windows.Forms.Panel();
            this.ExitButtom = new System.Windows.Forms.Button();
            this.ReSizeButtom = new System.Windows.Forms.Button();
            this.ToMinButtom = new System.Windows.Forms.Button();
            this.ReReSizeButtom = new System.Windows.Forms.Button();
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
            // BottomSizeChanger
            // 
            this.BottomSizeChanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomSizeChanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomSizeChanger.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            // RightButtomSizeChanger
            // 
            this.RightButtomSizeChanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightButtomSizeChanger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightButtomSizeChanger.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightButtomSizeChanger.Location = new System.Drawing.Point(785, 435);
            this.RightButtomSizeChanger.Name = "RightButtomSizeChanger";
            this.RightButtomSizeChanger.Size = new System.Drawing.Size(15, 15);
            this.RightButtomSizeChanger.TabIndex = 7;
            this.RightButtomSizeChanger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OuterForm_MouseDown);
            
            // 
            // ExitButtom
            // 
            this.ExitButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButtom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButtom.BackgroundImage")));
            this.ExitButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButtom.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButtom.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButtom.Location = new System.Drawing.Point(734, 3);
            this.ExitButtom.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButtom.Name = "ExitButtom";
            this.ExitButtom.Size = new System.Drawing.Size(63, 22);
            this.ExitButtom.TabIndex = 8;
            this.ExitButtom.UseVisualStyleBackColor = false;
            this.ExitButtom.Click += new System.EventHandler(this.ExitButtom_Click);
            this.ExitButtom.MouseEnter += new System.EventHandler(this.ExitButtom_MouseEnter);
            this.ExitButtom.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ReSizeButtom
            // 
            this.ReSizeButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReSizeButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReSizeButtom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReSizeButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReSizeButtom.BackgroundImage")));
            this.ReSizeButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReSizeButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReSizeButtom.ForeColor = System.Drawing.Color.Transparent;
            this.ReSizeButtom.Location = new System.Drawing.Point(671, 3);
            this.ReSizeButtom.Margin = new System.Windows.Forms.Padding(0);
            this.ReSizeButtom.Name = "ReSizeButtom";
            this.ReSizeButtom.Size = new System.Drawing.Size(63, 22);
            this.ReSizeButtom.TabIndex = 9;
            this.ReSizeButtom.UseVisualStyleBackColor = false;
            this.ReSizeButtom.Click += new System.EventHandler(this.ReSizeButtom_Click);
            // 
            // ToMinButtom
            // 
            this.ToMinButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToMinButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToMinButtom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToMinButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToMinButtom.BackgroundImage")));
            this.ToMinButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToMinButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMinButtom.ForeColor = System.Drawing.Color.Transparent;
            this.ToMinButtom.Location = new System.Drawing.Point(608, 3);
            this.ToMinButtom.Margin = new System.Windows.Forms.Padding(0);
            this.ToMinButtom.Name = "ToMinButtom";
            this.ToMinButtom.Size = new System.Drawing.Size(63, 22);
            this.ToMinButtom.TabIndex = 10;
            this.ToMinButtom.UseVisualStyleBackColor = false;
            this.ToMinButtom.Click += new System.EventHandler(this.ToMinButtom_Click);
            // 
            // ReReSizeButtom
            // 
            this.ReReSizeButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReReSizeButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReReSizeButtom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReReSizeButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReReSizeButtom.BackgroundImage")));
            this.ReReSizeButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReReSizeButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReReSizeButtom.ForeColor = System.Drawing.Color.Transparent;
            this.ReReSizeButtom.Location = new System.Drawing.Point(671, 3);
            this.ReReSizeButtom.Margin = new System.Windows.Forms.Padding(0);
            this.ReReSizeButtom.Name = "ReReSizeButtom";
            this.ReReSizeButtom.Size = new System.Drawing.Size(63, 22);
            this.ReReSizeButtom.TabIndex = 11;
            this.ReReSizeButtom.UseVisualStyleBackColor = false;
            this.ReReSizeButtom.Click += new System.EventHandler(this.ReReSizeButtom_Click);
            // 
            // OuterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReReSizeButtom);
            this.Controls.Add(this.ToMinButtom);
            this.Controls.Add(this.ReSizeButtom);
            this.Controls.Add(this.ExitButtom);
            this.Controls.Add(this.RightButtomSizeChanger);
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
        private System.Windows.Forms.Panel RightButtomSizeChanger;
        private System.Windows.Forms.Button ExitButtom;
        private System.Windows.Forms.Button ReSizeButtom;
        private System.Windows.Forms.Button ToMinButtom;
        private System.Windows.Forms.Button ReReSizeButtom;
    }
}

