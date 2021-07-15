using chat_winForm.Forms.Commons;
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
    public partial class MakeGroupForm : chat_winForm.OuterForm
    {
        public delegate void Prosess ();

        public Prosess MakeGroup_After { get; set; }

        public MakeGroupForm()
        {
            InitializeComponent();
        }

        private void MakeGrolupButton_Click(object sender, EventArgs e)
        {
            if (MakeGroupErrorProvider.GetError(GroupNameTextBox) == null)
                return;

            StartSpinnerMode();

            GroupService.MakeGroup(GroupNameTextBox.Text);

            FinishSpinnerMode();
            MakeGroup_After();
        }

        private void GroupNameTextBox_Validated(object sender, EventArgs e)
        {
            MakeGroupErrorProvider.SetError(GroupNameTextBox,
                new Validater(GroupNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        /// <summary>
        /// このフォームで、スピナーを表示するモードにする
        /// </summary>
        private void StartSpinnerMode()
        {
            SpinnerBox.Visible = true;
            UseWaitCursor = true;

        }

        /// <summary>
        /// このフォームで、スピナーを表示するモードを終了する
        /// </summary>
        private void FinishSpinnerMode()
        {
            SpinnerBox.Visible = false;
            UseWaitCursor = false;
        }

        private void MakeGroupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
