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
    public partial class AddDialogueForm : chat_winForm.OuterForm
    {
        public AddDialogueForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddDialogueErrorProvider.GetError(UserIdNameTextBox) == null)
                return;

            StartSpinnerMode();

            DialogueService.AddUserInDialogue(UserIdNameTextBox.Text);
            //TODO

            FinishSpinnerMode();
        }

        private void UserIdNameTextBox_Validated(object sender, EventArgs e)
        {
            AddDialogueErrorProvider.SetError(UserIdNameTextBox,
                new Validater(UserIdNameTextBox.Text)
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
    }
}
