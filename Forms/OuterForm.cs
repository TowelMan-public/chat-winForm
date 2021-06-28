using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm
{
    public partial class OuterForm : Form
    {
        private Point pointWhenLastMouseDown;
        private Size sizeWhenLastMouseDown;

        public OuterForm()
        {
            InitializeComponent();

        }

        private void OuterForm_Load(object sender, EventArgs e)
        {
            this.MouseDown +=
                new MouseEventHandler(OuterForm_MouseDown);
            this.MouseMove +=
                new MouseEventHandler(OuterForm_MouseMove);
        }

        private void OuterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                pointWhenLastMouseDown = new Point(e.X, e.Y);
                sizeWhenLastMouseDown = this.Size;
                
            }
        }

        private void OuterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - pointWhenLastMouseDown.X;
                this.Top += e.Y - pointWhenLastMouseDown.Y;
            }
        }

        private void TopSizeChanger_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int h = this.Height;
                this.Height -= e.Y - pointWhenLastMouseDown.Y;
                this.Top += h - this.Height;
            }
        }

        private void BottomSizeChanger_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Height += e.Y - pointWhenLastMouseDown.Y;
            }
        }

        private void RightSizeChanger_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Width += e.X - pointWhenLastMouseDown.X;
            }
        }

        private void LeftSizeChanger_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int w = this.Width;
                this.Width -= e.X - pointWhenLastMouseDown.X;
                this.Left += w - this.Width;
            }
        }
    }
}
