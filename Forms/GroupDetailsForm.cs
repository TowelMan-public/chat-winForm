using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Model;
using chat_winForm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    /// <summary>
    /// グループ詳細画面
    /// </summary>
    public partial class GroupDetailsForm : chat_winForm.OuterForm
    {
        public delegate void Prosess();

        /// <summary>
        /// この画面で使われるデータが格納されているクラスのセット・取得
        /// </summary>
        public GroupTalkRoomModel Model { get; set; }

        /// <summary>
        /// グループから脱退するのとグループを削除したとき以外の処理の時の後処理のセット・取得
        /// </summary>
        public Prosess OtherThanDeleteAction_After { get; set; }

        /// <summary>
        /// グループから脱退するのとグループを削除したときの後処理のセット・取得
        /// </summary>
        public Prosess DeleteAction_After { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GroupDetailsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// この画面が読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void GroupDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                GroupNameTextBox.Text = Model.Name;

                UserInGroupList.SuspendLayout();
                UserInGroupList.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

                //グループ加入者の取得
                List<UserInGroupModel> userInGroupModelList = await Task.Run(() => { return GroupService.GetUserInGroupList(Model.GroupTalkRoomId); });
                foreach (UserInGroupModel userInGroupModel in userInGroupModelList)
                {
                    UserInGroupList.RowCount++;
                    Label userIdNameLabel = new Label
                    {
                        Text = userInGroupModel.UserIdName,
                        AutoSize = false,
                        Font = new Font(FontFamily.GenericMonospace, 12),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                        ForeColor = Color.White
                    };
                    Label userNameLabel = new Label
                    {
                        Text = userInGroupModel.UserName,
                        AutoSize = false,
                        Font = new Font(FontFamily.GenericMonospace, 12),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                        ForeColor = Color.White
                    };
                    Button deleteButton = new Button
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
            }
            finally
            {
                UserInGroupList.ResumeLayout();
                FinishSpinnerMode();
                ValidateChildren();
            }
        }

        /// <summary>
        /// グループ削除ボタンがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                await Task.Run(() => { GroupService.DeleteGroup(Model.GroupTalkRoomId); });
            }
            finally
            {
                FinishSpinnerMode();
                DeleteAction_After();
                Close();
            }
        }

        /// <summary>
        /// グループ名変更ボタンがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void ChangeGroupNameButton_Click(object sender, EventArgs e)
        {
            if (GroupErrorProvider.GetError(GroupNameTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();

                await Task.Run(() => { GroupService.UpdateGroupName(Model.GroupTalkRoomId, GroupNameTextBox.Text); });
                Model.Name = GroupNameTextBox.Text;
            }
            finally
            {
                FinishSpinnerMode();
                OtherThanDeleteAction_After();
            }
        }

        /// <summary>
        /// ユーザーをグループに勧誘するボタンがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void InvitationUserButton_Click(object sender, EventArgs e)
        {
            if (GroupErrorProvider.GetError(InvitationUserIdNameTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();

                await Task.Run(() => { GroupService.InvitationUserInGroup(Model.GroupTalkRoomId, InvitationUserIdNameTextBox.Text); });

                InvitationUserIdNameTextBox.Text = "";
            }
            catch (NotFoundException exception)
            {
                if (!exception.IsErrorFieldUserIdName())
                {
                    throw exception;
                }

                string ERROR_MESSAGE = "あなたが入力したユーザーIDは存在しません。もう一度ご確認ください。";

                MessageBox.Show(ERROR_MESSAGE,
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                GroupErrorProvider.SetError(InvitationUserIdNameTextBox, ERROR_MESSAGE);
            }
            catch (AlreadyInsertedGroupException)
            {
                string ERROR_MESSAGE = "あなたが指定したユーザーは既にグループに加入しています。もう一度ご確認ください。";

                MessageBox.Show(ERROR_MESSAGE,
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                GroupErrorProvider.SetError(InvitationUserIdNameTextBox, ERROR_MESSAGE);
            }
            catch (AlreadyInsertedGroupDesireException)
            {
                string ERROR_MESSAGE = "あなたが指定したユーザーは既にこのグループに勧誘中です。もう一度ご確認ください。";

                MessageBox.Show(ERROR_MESSAGE,
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                GroupErrorProvider.SetError(InvitationUserIdNameTextBox, ERROR_MESSAGE);
            }
            finally
            {
                FinishSpinnerMode();
                OtherThanDeleteAction_After();
            }
        }

        /// <summary>
        /// グループから脱退するボタンがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void BrockGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                await Task.Run(() => { GroupService.BrockGroupTalkRoom(Model.GroupTalkRoomId); });
            }
            finally
            {
                FinishSpinnerMode();
                DeleteAction_After();
                Close();
            }
        }

        /// <summary>
        /// グループ加入者を脱退させるボタンがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DeleteUserInGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                int rowNumber = UserInGroupList.GetRow(sender as Button);
                string userIdName = (UserInGroupList.GetControlFromPosition(1, rowNumber) as Label).Text;
                await Task.Run(() => { GroupService.DeleteUserInGroup(Model.GroupTalkRoomId, userIdName); });

                for (int i = 0; i < 3; i++)
                {
                    UserInGroupList.Controls.Remove(UserInGroupList.GetControlFromPosition(1, rowNumber));
                }

                UserInGroupList.RowStyles[rowNumber].Height = 0;
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// グループ名のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void GroupNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            GroupErrorProvider.SetError(GroupNameTextBox,
                new Validater(GroupNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        /// <summary>
        /// 勧誘するユーザーIDのバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void InvitationUserIdNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            GroupErrorProvider.SetError(InvitationUserIdNameTextBox,
                new Validater(InvitationUserIdNameTextBox.Text)
                .NotBlank()
                .MaxString(100)
                .GetErrorMessage());
        }

        /// <summary>
        /// グループ名のバリデーションチェックのイベントハンドラーの後処理
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void GroupNameTextBox_Validated(object sender, EventArgs e)
        {
            if (GroupErrorProvider.GetError(GroupNameTextBox) == "")
                GroupNameTextBox.BackColor = Color.White;
            else
                GroupNameTextBox.BackColor = Color.Red;
        }

        /// <summary>
        /// 勧誘するユーザーIDのバリデーションチェックのイベントハンドラーの後処理
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void InvitationUserIdNameTextBox_Validated(object sender, EventArgs e)
        {
            if (GroupErrorProvider.GetError(InvitationUserIdNameTextBox) == "")
                InvitationUserIdNameTextBox.BackColor = Color.White;
            else
                InvitationUserIdNameTextBox.BackColor = Color.Red;
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
