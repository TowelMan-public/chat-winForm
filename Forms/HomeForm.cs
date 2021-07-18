using chat_winForm.Client.Exception;
using chat_winForm.Control;
using chat_winForm.Forms.Commons;
using chat_winForm.Model;
using chat_winForm.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    /// <summary>
    /// ホーム画面
    /// </summary>
    public partial class HomeForm : chat_winForm.OuterForm
    {
        private TalkListInTalkRoomControl TalkListInTalkRoom;
        private GroupDetailsForm GroupDetailsForm;
        private TalkEditorForm TalkEditorForm;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HomeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// この画面が読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            Thread.GetDomain().UnhandledException += NoneCatchedEception_Throw;

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

        /// <summary>
        /// 友達トークルームがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
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

        /// <summary>
        /// グループトークルームがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
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

        /// <summary>
        /// 友達追加申請者とのトークルームがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
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

        /// <summary>
        /// 勧誘されているグループトークルームがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
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

        /// <summary>
        /// 友達追加ボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void ShowAddDialogueButton_Click(object sender, EventArgs e)
        {
            AddDialogueForm addDialogueForm = new AddDialogueForm();
            addDialogueForm.AddDialogue_After = UpdateTalkRoomList;
            addDialogueForm.Show();
        }

        /// <summary>
        /// グループ作成ボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void ShowMakeGroupButton_Click(object sender, EventArgs e)
        {
            MakeGroupForm makeGroupForm = new MakeGroupForm();
            makeGroupForm.MakeGroup_After = UpdateTalkRoomList;
            makeGroupForm.Show();
        }

        /// <summary>
        /// ユーザー設定ボタンが押されたときのときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void ShowUserConfingButton_Click(object sender, EventArgs e)
        {
            UserConfingForm userConfingForm = new UserConfingForm();
            userConfingForm.Show();
        }

        /// <summary>
        /// 定期更新の時間が来たときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (TalkListInTalkRoom == null)
            {
                UpdateTalkRoomList();
            }
            else
            {
                ReCreateTalkListInTalkRoom();
            }
        }

        /// <summary>
        /// この画面が閉じられたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*////////////////// 動的なクリックイベント //////////////////////////////////////*/

        /// <summary>
        /// 友達トークルームのトーク送信ボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DialogueSendButton_Click(object sender, EventArgs e)
        {
            //バリデーションチェック
            if (new Validater(SendTextBox.Text)
                    .NotBlank()
                    .MaxString(2000)
                    .Check())
            {
                return;
            }

            try
            {
                StartSpinnerMode();

                DialogueTalkRoomModel dialogueTalkRoomModel = TalkListInTalkRoom.Model as DialogueTalkRoomModel;
                await Task.Run(() => TalkService.SendDialogueTalk(dialogueTalkRoomModel.HaveUserIdName, SendTextBox.Text));

                SendTextBox.Text = "";
            }
            finally
            {
                FinishSpinnerMode();
                UpdateTalkListInTalkRoom();
            }
        }

        /// <summary>
        /// グループトークルームのトーク送信ボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void GroupSendButton_Click(object sender, EventArgs e)
        {
            //バリデーションチェック
            if (new Validater(SendTextBox.Text)
                    .NotBlank()
                    .MaxString(2000)
                    .Check())
            {
                return;
            }

            try
            {
                StartSpinnerMode();

                GroupTalkRoomModel groupTalkRoomModel = TalkListInTalkRoom.Model as GroupTalkRoomModel;
                await Task.Run(() => TalkService.SendGroupTalk(groupTalkRoomModel.GroupTalkRoomId, SendTextBox.Text));

                SendTextBox.Text = "";
            }
            finally
            {
                FinishSpinnerMode();
                UpdateTalkListInTalkRoom();
            }
        }

        /// <summary>
        /// トークがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void Talk_Click(object sender, EventArgs e)
        {
            CloseTalkEditorForm();

            TalkControl talkControl;

            System.Windows.Forms.Control control = sender as System.Windows.Forms.Control;
            while (!(control is TalkControl))
            {
                control = control.Parent;
            }

            talkControl = control as TalkControl;

            TalkEditorForm talkEditorForm = new TalkEditorForm
            {
                Model = talkControl.Model,
                Action_After = ReCreateTalkListInTalkRoom
            };
            talkEditorForm.Show();

            TalkEditorForm = talkEditorForm;
        }

        /// <summary>
        /// グループ詳細ボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void ShowGroupDetailsButton_Click(object sender, EventArgs e)
        {
            CloseGroupDetailsForm();

            GroupDetailsForm groupDetailsForm = new GroupDetailsForm
            {
                Model = TalkListInTalkRoom.Model as GroupTalkRoomModel,
                DeleteAction_After = () =>
                {
                    UpdateTalkRoomList();
                    DeleteTalkListInTalkRoom();
                }
            };
            groupDetailsForm.OtherThanDeleteAction_After = () =>
            {
                UpdateTalkRoomList();
                ReCreateTalkListInTalkRoom(groupDetailsForm.Model.Name);
            };

            groupDetailsForm.Show();
            GroupDetailsForm = groupDetailsForm;
        }

        /// <summary>
        /// 友達ブロックボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DialogueBrockButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                DialogueTalkRoomModel dialogueModel = TalkListInTalkRoom.Model as DialogueTalkRoomModel;
                await Task.Run(() => { DialogueService.BrockDialogueTalkRoom(dialogueModel.HaveUserIdName); });

                FinishSpinnerMode();
            }
            finally
            {
                DeleteTalkListInTalkRoom();
                UpdateTalkRoomList();
            }
        }

        /// <summary>
        /// 友達追加申請を断るボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DesireDialogueBrockButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                DesireDialogueTalkRoomModel desireDialogueModel = TalkListInTalkRoom.Model as DesireDialogueTalkRoomModel;
                await Task.Run(() => { DialogueService.BrockDesireDialogueTalkRoom(desireDialogueModel.HaveUserIdName); });

            }
            finally
            {
                FinishSpinnerMode();
                DeleteTalkListInTalkRoom();
                UpdateTalkRoomList();
            }
        }

        /// <summary>
        /// 友達追加申請を受け入れるボタンがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DesireDialogueAcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                DesireDialogueTalkRoomModel desireDialogueModel = TalkListInTalkRoom.Model as DesireDialogueTalkRoomModel;
                await Task.Run(() => { DialogueService.AcceptDesireDialogueTalkRoom(desireDialogueModel.HaveUserIdName); });
            }
            finally
            {
                FinishSpinnerMode();
                DeleteTalkListInTalkRoom();
                UpdateTalkRoomList();
            }
        }

        /// <summary>
        /// グループからの勧誘を断るボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DesireGroupBrockButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                DesireGroupTalkRoomModel desireGroupModel = TalkListInTalkRoom.Model as DesireGroupTalkRoomModel;
                await Task.Run(() => { GroupService.BrockDesireGroupTalkRoom(desireGroupModel.GroupTalkRoomId); });
            }
            finally
            {
                FinishSpinnerMode();
                DeleteTalkListInTalkRoom();
                UpdateTalkRoomList();
            }
        }

        /// <summary>
        /// グループからの勧誘を受け入れるボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DesireGroupAcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                DesireGroupTalkRoomModel desireGroupModel = TalkListInTalkRoom.Model as DesireGroupTalkRoomModel;
                await Task.Run(() => { GroupService.AcceptDesireGroupTalkRoom(desireGroupModel.GroupTalkRoomId); });
            }
            finally
            {
                FinishSpinnerMode();
                DeleteTalkListInTalkRoom();
                UpdateTalkRoomList();
            }
        }
        /*////////////////////////// 例外ハンドラー/////////////////////////////////////////////////////////////*/

        /// <summary>
        /// ホーム画面の管理下で投げられた例外のうち、キャッチされなかった例外を処理するイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void NoneCatchedEception_Throw(object sender, UnhandledExceptionEventArgs e)
        {
            switch (e.ExceptionObject)
            {
                case AlreadyHaveUserException _:
                    {
                        MessageBox.Show("既に友達のユーザーが何らかの形で不正に指定されました。このエラーはほかの機種等でユーザーを友達に登録すると発生することがあります。" +
                            "この現象が心当たりなく続く場合は開発者に報告してください。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case AlreadyInsertedGroupDesireException _:
                    {
                        MessageBox.Show("既にグループに招待されているユーザーが何らかの形で不正に指定されました。このエラーはほかの機種等でグループに勧誘すると発生することがあります。" +
                            "この現象が心当たりなく続く場合は開発者に報告してください。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case AlreadyInsertedGroupException _:
                    {
                        MessageBox.Show("既にグループに加入したユーザーが何らかの形で不正に指定されました。このエラーはほかの機種等でそのユーザーがそのグループに加入（受け入れる）すると発生することがあります。" +
                            "この現象が心当たりなく続く場合は開発者に報告してください。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case AlreadyUsedUserIdNameException _:
                    {
                        MessageBox.Show("既に使われているユーザーIDが予期せずに指定されました。バリデーションチェック等で実装漏れがある可能性があるので" +
                            "開発者にこのエラーが発生したことを、状況等を細かく伝えてください。",
                            "重大なエラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case BadRequestFormException _:
                    {
                        MessageBox.Show("予期せずに不正なリクエストをしたときに発生します。" +
                            "開発者にこのエラーが発生したことを、状況等を細かく伝えてください。",
                            "重大なエラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case InvalidLoginException _:
                    {
                        MessageBox.Show("認証の期間が過ぎてしまいました。今あなたが行った操作は反映されません。大変申し訳ございませんが、" +
                            "再度ログインしていただきますようお願い申し上げます。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case NotFoundException exception:
                    {
                        MessageBox.Show($"指定された{exception.GetErrorFieldName()}が何らかの理由で不正に指定されました。このエラーはほかの機種で対象の{exception.GetErrorFieldName()}にまつわる操作をすると発生することがあります。" +
                            "この現象が心当たりなく続く場合は開発者に報告してください。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case NotHaveUserException _:
                    {
                        MessageBox.Show("友達に指定されていないユーザーが何らかの形で不正に指定されました。このエラーはほかの機種で対象のユーザーを友達からブロックしたときに発生することがあります。" +
                            "この現象が心当たりなく続く場合は開発者に報告してください。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case NotInsertedGroupDesireException _:
                    {
                        MessageBox.Show("あなたが勧誘されていないグループが何らかの理由で不正に指定されました。このエラーはほかの機種で対象のグループからの勧誘を断ると発生することがあります。" +
                            "この現象が心当たりなく続く場合は開発者に報告してください。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                case NotJoinGroupException _:
                    {
                        MessageBox.Show("あなたが加入していないグループが何らかの形で不正に指定されました。このエラーはほかの機種で対象のグループから脱退したときに発生することがあります。" +
                            "この現象が心当たりなく続く場合は開発者に報告してください。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        DeleteTalkListInTalkRoom();
                        CloseTalkEditorForm();
                        CloseGroupDetailsForm();
                        break;
                    }
                default: //Exception
                    {
                        CommonMessageBoxs.UnexpectedErrorMessageBox();
                        break;
                    }
            }
        }

        /*///////////////////// 部品（デリゲーター）として使うもの ////////////////////////////////////////////*/

        /// <summary>
        /// 友達トークリストを読み込む
        /// </summary>
        /// <param name="startIndex">読み始めのトークルームインデックス</param>
        /// <param name="maxSize">読み込む最大件数</param>
        /// <param name="haveUserIdName">友達のユーザーID名</param>
        /// <returns>友達トークリスト</returns>
        private List<TalkModel> LoadDialogueTalkList(int startIndex, int maxSize, String haveUserIdName)
        {
            return TalkService.GetDialogueTalkList(haveUserIdName, startIndex, maxSize);
        }

        /// <summary>
        /// グループトークリストを読み込む
        /// </summary>
        /// <param name="startIndex">読み始めのトークルームインデックス</param>
        /// <param name="maxSize">読み込む最大件数</param>
        /// <param name="GroupTalkRoomId">グループトークルームID</param>
        /// <returns>グループトークリスト</returns>
        private List<TalkModel> LoadGroupTalkList(int startIndex, int maxSize, int GroupTalkRoomId)
        {
            return TalkService.GetGroupTalkList(GroupTalkRoomId, startIndex, maxSize);
        }

        /*///////////////// 小部品 /////////////////////////////////////////////////////*/

        /// <summary>
        /// トークルームリストを更新する
        /// </summary>
        private void UpdateTalkRoomList()
        {
            TalkRoomList.UpdateTalkRoomList();
        }

        /// <summary>
        /// トークリストにもっと新しいトークを読み込ませる
        /// </summary>
        private void UpdateTalkListInTalkRoom()
        {
            TalkListInTalkRoom.UpdateTalkList();
            UpdateTalkRoomList();
        }

        /// <summary>
        /// トークリストを作り直させる
        /// </summary>
        private void ReCreateTalkListInTalkRoom()
        {
            if (TalkListInTalkRoom.NewestTalkIndex != -1)
            {
                TalkListInTalkRoom.Model.LastTalkIndex = TalkListInTalkRoom.NewestTalkIndex;
            }

            TalkListInTalkRoomControl talkListInTalkRoom = new TalkListInTalkRoomControl
            {
                Location = new Point(0),
                Width = TalkListInTalkRoomPanel.Width,
                Height = TalkListInTalkRoomPanel.Height,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Model = TalkListInTalkRoom.Model,
                SubContentControl = TalkListInTalkRoom.SubContentControl,
                TalkClickEventHandler = TalkListInTalkRoom.TalkClickEventHandler,
                TalkListLoader = TalkListInTalkRoom.TalkListLoader
            };

            TalkListInTalkRoomPanel.Controls.Clear();
            TalkListInTalkRoom.Dispose();

            TalkListInTalkRoom = talkListInTalkRoom;
            TalkListInTalkRoomPanel.Controls.Add(TalkListInTalkRoom);

            UpdateTalkRoomList();
            CloseGroupDetailsForm();
            CloseTalkEditorForm();
        }

        /// <summary>
        /// トークリストを作り直させる
        /// </summary>
        /// <param name="newName">新しいトークルーム名</param>
        private void ReCreateTalkListInTalkRoom(String newName)
        {
            TalkListInTalkRoom.Model.Name = newName;
            ReCreateTalkListInTalkRoom();
        }

        /// <summary>
        /// トークルームリスト（GUI）を壊す
        /// </summary>
        private void DeleteTalkListInTalkRoom()
        {
            SendPanel.Visible = false;
            TalkListInTalkRoomPanel.Controls.Remove(TalkListInTalkRoom);
            TalkListInTalkRoom.Dispose();
            TalkListInTalkRoom = null;
        }

        /// <summary>
        /// 送信ボタンのイベントをセットする
        /// </summary>
        /// <param name="eventHandler">クリックイベントハンドラー</param>
        private void SetSendButtonClickEvent(EventHandler eventHandler)
        {
            SendButton.Click -= DialogueSendButton_Click;
            SendButton.Click -= GroupSendButton_Click;
            SendButton.Click += eventHandler;
        }

        /// <summary>
        /// トーク編集画面を閉じる
        /// </summary>
        private void CloseTalkEditorForm()
        {
            if (TalkEditorForm != null)
            {
                TalkEditorForm.Dispose();
                TalkEditorForm = null;
            }
        }

        /// <summary>
        /// グループ詳細画面を閉じる
        /// </summary>
        private void CloseGroupDetailsForm()
        {
            if (GroupDetailsForm != null)
            {
                GroupDetailsForm.Dispose();
                GroupDetailsForm = null;
            }
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
