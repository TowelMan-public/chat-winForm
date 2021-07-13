using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Model;
using chat_winForm.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class TalkRoomListControl : UserControl
    {
        public EventHandler DialigueTalkRoomClickEventHandler { get; set; }
        public EventHandler GroupTalkRoomClickEventHandler { get; set; }
        public EventHandler DesireDialogueTalkRoomClickEventHandler { get; set; }
        public EventHandler DesireGroupTalkRoomClickEventHandler { get; set; }

        public TalkRoomListControl()
        {
            InitializeComponent();
        }

        private void TalkRoomListControl_Load(object sender, EventArgs e)
        {
            //各ListGroupにタイトルを指定
            DialogueTalkRoomListTitle.Text = "友達一覧";
            GroupTalkRoomListTitle.Text = "グループ一覧";
            DesireDialogueTalkRoomListTitle.Text = "友達追加申請一覧";
            DesireGroupTalkRoomListTitle.Text = "グループ招待一覧";

            //各ListGroupTitleにクリックイベント
            DialogueTalkRoomListTitle.MyClick += TalkRoomListTitle_Click;
            GroupTalkRoomListTitle.MyClick += TalkRoomListTitle_Click;
            DesireDialogueTalkRoomListTitle.MyClick += TalkRoomListTitle_Click;
            DesireGroupTalkRoomListTitle.MyClick += TalkRoomListTitle_Click;

            //各ListGroupにクリックイベントを設定
            DialogueTalkRoomList.TalkRoomClickEventHandler = DialigueTalkRoomClickEventHandler;
            GroupTalkRoomList.TalkRoomClickEventHandler = GroupTalkRoomClickEventHandler;
            DesireDialogueTalkRoomList.TalkRoomClickEventHandler = DesireDialogueTalkRoomClickEventHandler;
            DesireGroupTalkRoomList.TalkRoomClickEventHandler = DesireGroupTalkRoomClickEventHandler;

            //4つのListGroup全て生成・表示
            CreateAllListGroupContents();
        }

        private void TalkRoomListTitle_Click(object sender, EventArgs e)
        {

        }

        private async void CreateAllListGroupContents()
        {
            try
            {
                StartSpinnerMode();

                //データの取得
                Task<List<TalkRoomModel>> dialogueTask = Task.Run(() => TalkRoomService.GetDialogueTalkRoomModelList());
                Task<List<TalkRoomModel>> groupTask = Task.Run(() => TalkRoomService.GetGroupTalkRoomModelList());
                Task<List<TalkRoomModel>> desireDialogueTask = Task.Run(() => TalkRoomService.GetDesireDialogueTalkRoomModelList());
                Task<List<TalkRoomModel>> desireGroupTask = Task.Run(() => TalkRoomService.GetDesireGroupTalkRoomModelList());
                List<TalkRoomModel>[] modelLists = await Task.WhenAll(
                    new Task<List<TalkRoomModel>>[] { dialogueTask, groupTask, desireDialogueTask, desireGroupTask });

                //コントロール作成
                ShowDialogueTalkRoomGroupContents(modelLists[0]);
                ShowGroupTalkRoomGroupContents(modelLists[1]);
                ShowDesireGroupTalkRoomGroupContents(modelLists[2]);
                ShowDesireDialogueTalkRoomGroupContents(modelLists[3]);
            }
            catch (InvalidLoginException)
            {
                CommonMessageBoxs.InvalidLoginExceptionMessageBox();
                FindForm().Close();
                Forms.LoginForm loginForm = new Forms.LoginForm();
                loginForm.Show();
            }
            catch (Exception)
            {
                CommonMessageBoxs.UnexpectedErrorMessageBox();
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        private void ShowDialogueTalkRoomGroupContents(List<TalkRoomModel> modelList)
        {
            foreach (TalkRoomModel model in modelList)
            {
                DialogueTalkRoomList.AddTalkRoom(model.Name, model.NoticeCount, model);
            }
        }

        private void ShowGroupTalkRoomGroupContents(List<TalkRoomModel> modelList)
        {
            foreach (TalkRoomModel model in modelList)
            {
                GroupTalkRoomList.AddTalkRoom(model.Name, model.NoticeCount, model);
            }
        }

        private void ShowDesireGroupTalkRoomGroupContents(List<TalkRoomModel> modelList)
        {
            foreach (TalkRoomModel model in modelList)
            {
                DesireGroupTalkRoomList.AddTalkRoom(model.Name, model.NoticeCount, model);
            }
        }

        private void ShowDesireDialogueTalkRoomGroupContents(List<TalkRoomModel> modelList)
        {
            foreach (TalkRoomModel model in modelList)
            {
                DialogueTalkRoomList.AddTalkRoom(model.Name, model.NoticeCount, model);
            }
        }

        private void StartSpinnerMode()
        {
            SpinnerBox.Visible = true;
            UseWaitCursor = true;
        }

        private void FinishSpinnerMode()
        {
            SpinnerBox.Visible = false;
            UseWaitCursor = false;
        }
    }
}
