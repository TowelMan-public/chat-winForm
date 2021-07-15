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
    public partial class GroupDetailsForm : chat_winForm.OuterForm
    {
        public GroupTalkRoomModel Model { get; set; }

        public GroupDetailsForm()
        {
            InitializeComponent();
        }

        private async void GroupDetailsForm_Load(object sender, EventArgs e)
        {
            StartSpinnerMode();

            GroupNameTextBox.Text = Model.Name;

            UserInGroupList.SuspendLayout();
            UserInGroupList.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            var userInGroupModelList = await Task.Run(() => { return GroupService.GetUserInGroupList(Model.GroupTalkRoomId); });
            foreach(var userInGroupModel in userInGroupModelList)
            {
                UserInGroupList.RowCount++;
                var userIdNameLabel = new Label
                {
                    Text = userInGroupModel.UserIdName,
                    AutoSize = false,
                    Font = new Font(FontFamily.GenericMonospace, 12),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                    ForeColor = Color.White
                };
                var userNameLabel = new Label
                {
                    Text = userInGroupModel.UserName,
                    AutoSize = false,
                    Font = new Font(FontFamily.GenericMonospace, 12),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                    ForeColor = Color.White
                };
                var deleteButton = new Button
                {
                    Text = "削除",
                    Font = new Font(FontFamily.GenericMonospace, 12),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                    Visible = !userInGroupModel.isMe,
                    ForeColor = Color.White,
                    BackColor = Color.Red
                };
                deleteButton.Click += DeleteUserInGroupButton_Click;

                UserInGroupList.Controls.Add(userNameLabel, 0, UserInGroupList.RowCount - 1);
                UserInGroupList.Controls.Add(userIdNameLabel, 1, UserInGroupList.RowCount - 1);
                UserInGroupList.Controls.Add(deleteButton, 2, UserInGroupList.RowCount - 1);
                UserInGroupList.RowStyles.Add(new RowStyle(SizeType.Absolute, 34));
                UserInGroupList.Height += 34;
            }

            UserInGroupList.ResumeLayout();
            FinishSpinnerMode();
        }

        private async void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            await Task.Run(() => { GroupService.DeleteGroup(Model.GroupTalkRoomId);});

            //TODO
            FinishSpinnerMode();
        }

        private async void ChangeGroupNameButton_Click(object sender, EventArgs e)
        {
            GroupErrorProvider.SetError(GroupNameTextBox,
                new Validater(GroupNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());

            if (GroupErrorProvider.GetError(GroupNameTextBox) == null)
                return;

            StartSpinnerMode();

            await Task.Run(() => { GroupService.UpdateGroupName(Model.GroupTalkRoomId, GroupNameTextBox.Text); });

            FinishSpinnerMode();
        }

        private async void InvitationUserButton_Click(object sender, EventArgs e)
        {
            GroupErrorProvider.SetError(InvitationUserIdNameTextBox,
                new Validater(InvitationUserIdNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());

            if (GroupErrorProvider.GetError(InvitationUserIdNameTextBox) == null)
                return;

            StartSpinnerMode();

            await Task.Run(() => { GroupService.InvitationUserInGroup(Model.GroupTalkRoomId, InvitationUserIdNameTextBox.Text); });

            InvitationUserIdNameTextBox.Text = "";

            FinishSpinnerMode();
        }

        private void GroupNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            GroupErrorProvider.SetError(GroupNameTextBox,
                new Validater(GroupNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        private void InvitationUserIdNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            GroupErrorProvider.SetError(InvitationUserIdNameTextBox,
                new Validater(InvitationUserIdNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        private async void BrockGroupButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            await Task.Run(() => { GroupService.BrockGroupTalkRoom(Model.GroupTalkRoomId); });

            FinishSpinnerMode();
        }

        private async void DeleteUserInGroupButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            var rowNumber = UserInGroupList.GetRow(sender as Button);
            var userIdName = (UserInGroupList.GetControlFromPosition(1, rowNumber) as Label).Text;
            await Task.Run(() => { GroupService.DeleteUserInGroup(Model.GroupTalkRoomId, userIdName); });

            for (int i = 0; i < 3; i++)
                UserInGroupList.Controls.Remove(UserInGroupList.GetControlFromPosition(1, rowNumber));
            UserInGroupList.RowStyles[rowNumber].Height = 0;


            FinishSpinnerMode();
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
