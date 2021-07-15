using chat_winForm.Forms.Commons;
using chat_winForm.Model;
using chat_winForm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    public partial class TalkEditorForm : chat_winForm.OuterForm
    {
        public TalkModel Model { get; set; }

        public delegate void Prosess();

        public Prosess Action_After { get; set; }

        public TalkEditorForm()
        {
            InitializeComponent();
        }

        private void TalkEditorForm_Load(object sender, EventArgs e)
        {
            TalkContentErrorProvider.SetIconAlignment(TalkContentTextBox, ErrorIconAlignment.TopLeft);
            TalkContentTextBox.Text = Model.ContentText;

            if(Model is DialogueTalkModel)
                TitleLabel.Text = $"「{Model.SenderUserName}」さんとのトークを編集します";
            else
                TitleLabel.Text = $"とあるグループでのトークを編集します";
        }

        private async void DeleteTalkButton_Click(object sender, EventArgs e)
        {
            if (TalkContentErrorProvider.GetError(TalkContentTextBox) == null)
                return;

            StartSpinnerMode();

            if (Model is DialogueTalkModel)
            {
                var dialogueTalkModel = Model as DialogueTalkModel;
                await Task.Run(() => { TalkService.DeleteDialogueTalk(dialogueTalkModel.HaveUserIdName, dialogueTalkModel.TalkIndex); });
            }
            else
            {
                var groupTalkModel = Model as GroupTalkModel;
                await Task.Run(() => { TalkService.DeleteGroupTalk(groupTalkModel.GroupTalkRoomId, groupTalkModel.TalkIndex); });
            }

            FinishSpinnerMode();
            Action_After();
            Close();
        }

        private async void UpdateTalkButton_Click(object sender, EventArgs e)
        {
            if (TalkContentErrorProvider.GetError(TalkContentTextBox) == null)
                return;

            StartSpinnerMode();

            if (Model is DialogueTalkModel)
            {
                var dialogueTalkModel = Model as DialogueTalkModel;
                await Task.Run(() => { 
                    TalkService.UpdateDialogueTalk(dialogueTalkModel.HaveUserIdName, dialogueTalkModel.TalkIndex, TalkContentTextBox.Text);
                });
            }
            else
            {
                var groupTalkModel = Model as GroupTalkModel;
                await Task.Run(() => { 
                    TalkService.UpdateGroupTalk(groupTalkModel.GroupTalkRoomId, groupTalkModel.TalkIndex, TalkContentTextBox.Text); 
                });
            }

            FinishSpinnerMode();
            Action_After();
        }

        private void TalkContentTextBox_Validated(object sender, EventArgs e)
        {
            TalkContentErrorProvider.SetError(TalkContentTextBox,
                new Validater(TalkContentTextBox.Text)
                .NotBlank()
                .MaxString(2000)
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
