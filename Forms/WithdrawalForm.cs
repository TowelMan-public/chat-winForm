using chat_winForm.Registry;
using chat_winForm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    public partial class WithdrawalForm : chat_winForm.OuterForm
    {
        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();

        public WithdrawalForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserService.Exit();
            userCredentialsProvider.DeleteOuthToken();
            userCredentialsProvider.AllDelete();
            Application.Exit();
        }

        private void WithdrawalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
