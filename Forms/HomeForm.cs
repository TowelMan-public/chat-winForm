using chat_winForm.Control;
using chat_winForm.Forms.Commons;
using chat_winForm.Model;
using chat_winForm.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    public partial class HomeForm : chat_winForm.OuterForm
    {
        private TalkListInTalkRoomControl TalkListInTalkRoom;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            //画像の透過処置
            (ShowAddDialogueButton.BackgroundImage as Bitmap).MakeTransparent();
            (ShowMakeGroupButton.BackgroundImage as Bitmap).MakeTransparent();
            (ShowUserConfingButton.BackgroundImage as Bitmap).MakeTransparent();

            //TalkRoomListのクリックイベント登録
            TalkRoomList.DialigueTalkRoomClickEventHandler += new EventHandler(DialigueTalkRoom_Click);
            TalkRoomList.GroupTalkRoomClickEventHandler += new EventHandler(GroupTalkRoom_Click);
            TalkRoomList.DesireDialogueTalkRoomClickEventHandler += new EventHandler(DesireDialigueTalkRoom_Click);
            TalkRoomList.DesireGroupTalkRoomClickEventHandler += new EventHandler(DesireGroupTalkRoom_Click);

            SendPanel.Visible = false;
        }

        /*/////////////////////////// 静的なクリックイベント //////////////////////////////////*/

        private void DialigueTalkRoom_Click(object sender, EventArgs e)
        {
            DialogueTalkRoomModel dialogueTalkRoomModel;

            if (sender is TalkRoomColtrol)
            {
                dialogueTalkRoomModel = (sender as TalkRoomColtrol).Model as DialogueTalkRoomModel;
            }
            else
            {
                dialogueTalkRoomModel = ((sender as System.Windows.Forms.Control).Parent as TalkRoomColtrol).Model as DialogueTalkRoomModel;
            }

            TalkListInTalkRoomControl talkListInTalkRoom = new TalkListInTalkRoomControl
            {
                Location = new Point(0),
                Width = TalkListInTalkRoomPanel.Width,
                Height = TalkListInTalkRoomPanel.Height,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Model = dialogueTalkRoomModel,
                SubContentControl = new DialogueMenuControl
                {
                    UserIdNameText = dialogueTalkRoomModel.HaveUserIdName,
                    UserNameText = dialogueTalkRoomModel.Name,
                    BrockButtonClick = DialogueBrockButton_Click
                },
                TalkClickEventHandler = Talk_Click,
                TalkListLoader = (startIndex, maxSize) => { return LoadDialogueTalkList(startIndex, maxSize, dialogueTalkRoomModel.HaveUserIdName); }
            };

            if (TalkListInTalkRoom != null)
            {
                TalkListInTalkRoomPanel.Controls.Clear();
                TalkListInTalkRoom.Dispose();
            }
            TalkListInTalkRoom = talkListInTalkRoom;
            TalkListInTalkRoomPanel.Controls.Add(TalkListInTalkRoom);

            SendPanel.Visible = true;
            SetSendButtonClickEvent(DialogueSendButton_Click);
        }

        private void GroupTalkRoom_Click(object sender, EventArgs e)
        {
            GroupTalkRoomModel groupTalkRoomModel;

            if (sender is TalkRoomColtrol)
            {
                groupTalkRoomModel = (sender as TalkRoomColtrol).Model as GroupTalkRoomModel;
            }
            else
            {
                groupTalkRoomModel = ((sender as System.Windows.Forms.Control).Parent as TalkRoomColtrol).Model as GroupTalkRoomModel;
            }

            TalkListInTalkRoomControl talkListInTalkRoom = new TalkListInTalkRoomControl
            {
                Location = new Point(0),
                Width = TalkListInTalkRoomPanel.Width,
                Height = TalkListInTalkRoomPanel.Height,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Model = groupTalkRoomModel,
                SubContentControl = new GroupMenuControl
                {
                    ShowGroupDetailsButtonClick = ShowGroupDetailsButton_Click
                },
                TalkClickEventHandler = Talk_Click,
                TalkListLoader = (startIndex, maxSize) => { return LoadGroupTalkList(startIndex, maxSize, groupTalkRoomModel.GroupTalkRoomId); }
            };

            if (TalkListInTalkRoom != null)
            {
                TalkListInTalkRoomPanel.Controls.Clear();
                TalkListInTalkRoom.Dispose();
            }
            TalkListInTalkRoom = talkListInTalkRoom;
            TalkListInTalkRoomPanel.Controls.Add(TalkListInTalkRoom);

            SendPanel.Visible = true;
            SetSendButtonClickEvent(GroupSendButton_Click);
        }

        private void DesireDialigueTalkRoom_Click(object sender, EventArgs e)
        {
            DesireDialogueTalkRoomModel desireDialogueTalkRoomModel;

            if (sender is TalkRoomColtrol)
            {
                desireDialogueTalkRoomModel = (sender as TalkRoomColtrol).Model as DesireDialogueTalkRoomModel;
            }
            else
            {
                desireDialogueTalkRoomModel = ((sender as System.Windows.Forms.Control).Parent as TalkRoomColtrol).Model as DesireDialogueTalkRoomModel;
            }

            TalkListInTalkRoomControl talkListInTalkRoom = new TalkListInTalkRoomControl
            {
                Location = new Point(0),
                Width = TalkListInTalkRoomPanel.Width,
                Height = TalkListInTalkRoomPanel.Height,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Model = desireDialogueTalkRoomModel,
                SubContentControl = new DesireMenuControl
                {
                    BrockButtonClick = DesireDialogueBrockButton_Click,
                    AcceptButtonClick = DesireDialogueAcceptButton_Click
                },
                TalkListLoader = (startIndex, maxSize) => { return LoadDialogueTalkList(startIndex, maxSize, desireDialogueTalkRoomModel.HaveUserIdName); }
            };

            if (TalkListInTalkRoom != null)
            {
                TalkListInTalkRoomPanel.Controls.Clear();
                TalkListInTalkRoom.Dispose();
            }
            TalkListInTalkRoom = talkListInTalkRoom;
            TalkListInTalkRoomPanel.Controls.Add(TalkListInTalkRoom);

            SendPanel.Visible = false;
        }

        private void DesireGroupTalkRoom_Click(object sender, EventArgs e)
        {
            DesireGroupTalkRoomModel desireGroupTalkRoomModel;

            if (sender is TalkRoomColtrol)
            {
                desireGroupTalkRoomModel = (sender as TalkRoomColtrol).Model as DesireGroupTalkRoomModel;
            }
            else
            {
                desireGroupTalkRoomModel = ((sender as System.Windows.Forms.Control).Parent as TalkRoomColtrol).Model as DesireGroupTalkRoomModel;
            }

            TalkListInTalkRoomControl talkListInTalkRoom = new TalkListInTalkRoomControl
            {
                Location = new Point(0),
                Width = TalkListInTalkRoomPanel.Width,
                Height = TalkListInTalkRoomPanel.Height,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Model = desireGroupTalkRoomModel,
                SubContentControl = new DesireMenuControl
                {
                    BrockButtonClick = DesireGroupBrockButton_Click,
                    AcceptButtonClick = DesireGroupAcceptButton_Click
                },
                TalkListLoader = (startIndex, maxSize) => { return LoadGroupTalkList(startIndex, maxSize, desireGroupTalkRoomModel.GroupTalkRoomId); }
            };

            if (TalkListInTalkRoom != null)
            {
                TalkListInTalkRoomPanel.Controls.Clear();
                TalkListInTalkRoom.Dispose();
            }
            TalkListInTalkRoom = talkListInTalkRoom;
            TalkListInTalkRoomPanel.Controls.Add(TalkListInTalkRoom);

            SendPanel.Visible = false;
        }

        private void ShowAddDialogueButton_Click(object sender, EventArgs e)
        {
            var addDialogueForm = new AddDialogueForm();
            addDialogueForm.Show();
        }

        private void ShowMakeGroupButton_Click(object sender, EventArgs e)
        {
            var makeGroupForm = new MakeGroupForm();
            makeGroupForm.Show();
        }

        private void ShowUserConfingButton_Click(object sender, EventArgs e)
        {
            var userConfingForm = new UserConfingForm();
            userConfingForm.Show();
        }

        /*////////////////// 動的なクリックイベント //////////////////////////////////////*/

        private async void DialogueSendButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            //バリデーションチェック
            if (new Validater(SendTextBox.Text)
                    .NotBlank()
                    .MaxString(2000)
                    .Check())
            {
                return;
            }

            DialogueTalkRoomModel dialogueTalkRoomModel = TalkListInTalkRoom.Model as DialogueTalkRoomModel;

            await Task.Run(() => TalkService.SendDialogueTalk(dialogueTalkRoomModel.HaveUserIdName, SendTextBox.Text));

            SendTextBox.Text = "";
            FinishSpinnerMode();

            UpdateTalkListInTalkRoom();
        }

        private async void GroupSendButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            //バリデーションチェック
            if (new Validater(SendTextBox.Text)
                    .NotBlank()
                    .MaxString(2000)
                    .Check())
            {
                return;
            }

            GroupTalkRoomModel groupTalkRoomModel = TalkListInTalkRoom.Model as GroupTalkRoomModel;

            await Task.Run(() => TalkService.SendGroupTalk(groupTalkRoomModel.GroupTalkRoomId, SendTextBox.Text));

            SendTextBox.Text = "";
            FinishSpinnerMode();

            UpdateTalkListInTalkRoom();
        }

        private void Talk_Click(object sender, EventArgs e)
        {
            TalkControl talkControl;

            var control = sender as System.Windows.Forms.Control;
            while(!(control is TalkControl))
                control = control.Parent;

            talkControl = control as TalkControl;

            var talkEditorForm = new TalkEditorForm
            {
                Model = talkControl.Model
            };
            talkEditorForm.Show();

            //TODO
        }

        private void ShowGroupDetailsButton_Click(object sender, EventArgs e)
        {
            var groupDetailsForm = new GroupDetailsForm
            {
                Model = TalkListInTalkRoom.Model as GroupTalkRoomModel
            };
            groupDetailsForm.Show();
        }

        private async void DialogueBrockButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            DialogueTalkRoomModel dialogueModel = TalkListInTalkRoom.Model as DialogueTalkRoomModel;
            await Task.Run(() => { DialogueService.BrockDialogueTalkRoom(dialogueModel.HaveUserIdName); });

            FinishSpinnerMode();

            ResetTalkListInTalkRoom();
            UpdateTalkRoomList();
        }

        private async void DesireDialogueBrockButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            DesireDialogueTalkRoomModel desireDialogueModel = TalkListInTalkRoom.Model as DesireDialogueTalkRoomModel;
            await Task.Run(() => { DialogueService.BrockDesireDialogueTalkRoom(desireDialogueModel.HaveUserIdName); });

            FinishSpinnerMode();

            ResetTalkListInTalkRoom();
            UpdateTalkRoomList();
        }

        private async void DesireDialogueAcceptButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            DesireDialogueTalkRoomModel desireDialogueModel = TalkListInTalkRoom.Model as DesireDialogueTalkRoomModel;
            await Task.Run(() => { DialogueService.AcceptDesireDialogueTalkRoom(desireDialogueModel.HaveUserIdName); });

            FinishSpinnerMode();

            ResetTalkListInTalkRoom();
            UpdateTalkRoomList();
        }

        private async void DesireGroupBrockButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            DesireGroupTalkRoomModel desireGroupModel = TalkListInTalkRoom.Model as DesireGroupTalkRoomModel;
            await Task.Run(() => { GroupService.BrockDesireGroupTalkRoom(desireGroupModel.GroupTalkRoomId); });

            FinishSpinnerMode();

            ResetTalkListInTalkRoom();
            UpdateTalkRoomList();
        }

        private async void DesireGroupAcceptButton_Click(object sender, EventArgs e)
        {
            StartSpinnerMode();

            DesireGroupTalkRoomModel desireGroupModel = TalkListInTalkRoom.Model as DesireGroupTalkRoomModel;
            await Task.Run(() => { GroupService.AcceptDesireGroupTalkRoom(desireGroupModel.GroupTalkRoomId); });

            FinishSpinnerMode();

            ResetTalkListInTalkRoom();
            UpdateTalkRoomList();
        }

        /*///////////////////// 部品（デリゲーター）として使うもの ////////////////////////////////////////////*/

        private List<TalkModel> LoadDialogueTalkList(int startIndex, int maxSize, String haveUserIdName)
        {
            return TalkService.GetDialogueTalkList(haveUserIdName, startIndex, maxSize);
        }

        private List<TalkModel> LoadGroupTalkList(int startIndex, int maxSize, int GroupTalkRoomId)
        {
            return TalkService.GetGroupTalkList(GroupTalkRoomId, startIndex, maxSize);
        }

        /*///////////////// 小部品 /////////////////////////////////////////////////////*/

        void UpdateTalkRoomList()
        {
            TalkRoomList.UpdateTalkRoomList();
        }

        void UpdateTalkListInTalkRoom()
        {
            TalkListInTalkRoom.UpdateTalkList();
        }

        void ResetTalkListInTalkRoom()
        {
            Controls.Remove(TalkListInTalkRoom);
            TalkListInTalkRoom.Dispose();
            TalkListInTalkRoom = null;
        }

        void SetSendButtonClickEvent(EventHandler eventHandler)
        {
            SendButton.Click -= DialogueSendButton_Click;
            SendButton.Click -= GroupSendButton_Click;
            SendButton.Click += eventHandler;
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

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
