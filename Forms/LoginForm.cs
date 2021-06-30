using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    public partial class LoginForm : chat_winForm.OuterForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Width = 300;
            this.Height = 500;
        }
    }
}
