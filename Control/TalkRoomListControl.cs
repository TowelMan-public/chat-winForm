using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Model;
using chat_winForm.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// トークルームリストコントロール
    /// </summary>
    public partial class TalkRoomListControl : UserControl
    {
        /// <summary>
        /// 友達トークルームリストの見出しのクリックイベント
        /// </summary>
        public event EventHandler DialigueTalkRoomClickEventHandler
        {
            add => DialogueTalkRoomList.TalkRoomClickEventHandler += value;
            remove => DialogueTalkRoomList.TalkRoomClickEventHandler -= value;
        }

        /// <summary>
        /// グループトークルームリストの見出しのクリックイベント
        /// </summary>
        public event EventHandler GroupTalkRoomClickEventHandler
        {
            add => GroupTalkRoomList.TalkRoomClickEventHandler += value;
            remove => GroupTalkRoomList.TalkRoomClickEventHandler -= value;
        }

        /// <summary>
        /// 友達追加申請のトークルームリストの見出しのクリックイベント
        /// </summary>
        public event EventHandler DesireDialogueTalkRoomClickEventHandler
        {
            add => DesireDialogueTalkRoomList.TalkRoomClickEventHandler += value;
            remove => DesireDialogueTalkRoomList.TalkRoomClickEventHandler -= value;
        }

        /// <summary>
        /// グループ勧誘のトーークルームリストの見出しのクリックイベント
        /// </summary>
        public event EventHandler DesireGroupTalkRoomClickEventHandler
        {
            add => DesireGroupTalkRoomList.TalkRoomClickEventHandler += value;
            remove => DesireGroupTalkRoomList.TalkRoomClickEventHandler -= value;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TalkRoomListControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// トークルームリストたちを最新の状態に更新する
        /// </summary>
        public void UpdateTalkRoomList()
        {
            DialogueTalkRoomList.Reset();
            GroupTalkRoomList.Reset();
            DesireDialogueTalkRoomList.Reset();
            DesireGroupTalkRoomList.Reset();

            DialogueTalkRoomListTitle.NoticeCount = 0;
            DialogueTalkRoomListTitle.IsOpend = true;
            GroupTalkRoomListTitle.NoticeCount = 0;
            GroupTalkRoomListTitle.IsOpend = true;
            DesireDialogueTalkRoomListTitle.NoticeCount = 0;
            DesireDialogueTalkRoomListTitle.IsOpend = true;
            DesireGroupTalkRoomListTitle.NoticeCount = 0;
            DesireGroupTalkRoomListTitle.IsOpend = true;

            CreateAllListGroupContents();
        }

        /// <summary>
        /// 読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void TalkRoomListControl_Load(object sender, EventArgs e)
        {
            //各ListGroupにタイトルを指定
            DialogueTalkRoomListTitle.Text = "友達一覧";
            GroupTalkRoomListTitle.Text = "グループ一覧";
            DesireDialogueTalkRoomListTitle.Text = "友達追加申請一覧";
            DesireGroupTalkRoomListTitle.Text = "グループ招待一覧";

            //各ListGroupTitleにクリックイベント
            DialogueTalkRoomListTitle.MyClick += DialogueTalkRoomListTitle_Click;
            GroupTalkRoomListTitle.MyClick += GroupTalkRoomListTitle_Click;
            DesireDialogueTalkRoomListTitle.MyClick += DesireDialogueTalkRoomListTitle_Click;
            DesireGroupTalkRoomListTitle.MyClick += DesireGroupTalkRoomListTitle_Click;

            //高さの初期設定
            DialogueTalkRoomList.Height = 0;
            GroupTalkRoomList.Height = 0;
            DesireDialogueTalkRoomList.Height = 0;
            DesireGroupTalkRoomList.Height = 0;

            //4つのListGroup全て生成・表示
            CreateAllListGroupContents();
        }

        /// <summary>
        /// 各子コントロールの配置をする
        /// </summary>
        private void Placement()
        {
            DialogueTalkRoomListTitle.Location = new Point(0);
            DialogueTalkRoomList.Location = new Point
            {
                Y = DialogueTalkRoomListTitle.Location.Y + DialogueTalkRoomListTitle.Height,
                X = 0
            };

            GroupTalkRoomListTitle.Location = new Point
            {
                Y = DialogueTalkRoomList.Location.Y + (DialogueTalkRoomList.Visible ? DialogueTalkRoomList.Height : 0),
                X = 0
            };
            GroupTalkRoomList.Location = new Point
            {
                X = 0,
                Y = GroupTalkRoomListTitle.Location.Y + GroupTalkRoomListTitle.Height
            };

            DesireDialogueTalkRoomListTitle.Location = new Point
            {
                X = 0,
                Y = GroupTalkRoomList.Location.Y + (GroupTalkRoomList.Visible ? GroupTalkRoomList.Height : 0)
            };
            DesireDialogueTalkRoomList.Location = new Point
            {
                X = 0,
                Y = DesireDialogueTalkRoomListTitle.Location.Y + DesireDialogueTalkRoomListTitle.Height
            };

            DesireGroupTalkRoomListTitle.Location = new Point
            {
                X = 0,
                Y = DesireDialogueTalkRoomList.Location.Y + (DesireDialogueTalkRoomList.Visible ? DesireDialogueTalkRoomList.Height : 0),
            };
            DesireGroupTalkRoomList.Location = new Point
            {
                X = 0,
                Y = DesireGroupTalkRoomListTitle.Location.Y + DesireGroupTalkRoomListTitle.Height
            };

            Height = DesireGroupTalkRoomList.Location.Y + DesireGroupTalkRoomList.Height;
        }

        /// <summary>
        /// 友達トークルームの見出しがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void DialogueTalkRoomListTitle_Click(object sender, EventArgs e)
        {
            DialogueTalkRoomListTitle.IsOpend ^= true;
            DialogueTalkRoomList.Visible = DialogueTalkRoomListTitle.IsOpend;
            Placement();
        }

        /// <summary>
        /// グループトークルームの見出しがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void GroupTalkRoomListTitle_Click(object sender, EventArgs e)
        {
            GroupTalkRoomListTitle.IsOpend ^= true;
            GroupTalkRoomList.Visible = GroupTalkRoomListTitle.IsOpend;
            Placement();
        }

        /// <summary>
        /// 友達追加申請者とのトークルームの見出しがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void DesireDialogueTalkRoomListTitle_Click(object sender, EventArgs e)
        {
            DesireDialogueTalkRoomListTitle.IsOpend ^= true;
            DesireDialogueTalkRoomList.Visible = DesireDialogueTalkRoomListTitle.IsOpend;
            Placement();
        }

        /// <summary>
        /// 勧誘されているグループトークルームの見出しがクリックされたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void DesireGroupTalkRoomListTitle_Click(object sender, EventArgs e)
        {
            DesireGroupTalkRoomListTitle.IsOpend ^= true;
            DesireGroupTalkRoomList.Visible = DesireGroupTalkRoomListTitle.IsOpend;
            Placement();
        }

        /// <summary>
        /// 全てのトークルームリストを読み込んでそれを表示させる
        /// </summary>
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
                ShowDesireDialogueTalkRoomGroupContents(modelLists[2]);
                ShowDesireGroupTalkRoomGroupContents(modelLists[3]);

                //各TalkRoomListGroupを折りたたむ
                DialogueTalkRoomList.Visible = false;
                DialogueTalkRoomListTitle.IsOpend = false;
                GroupTalkRoomList.Visible = false;
                GroupTalkRoomListTitle.IsOpend = false;
                DesireDialogueTalkRoomList.Visible = false;
                DesireDialogueTalkRoomListTitle.IsOpend = false;
                DesireGroupTalkRoomList.Visible = false;
                DesireGroupTalkRoomListTitle.IsOpend = false;

                //配置
                Placement();
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

        /// <summary>
        /// 友達トークルームリストを表示する
        /// </summary>
        /// <param name="modelList">トークルームを格納したクラスのリスト</param>
        private void ShowDialogueTalkRoomGroupContents(List<TalkRoomModel> modelList)
        {
            DialogueTalkRoomListTitle.NoticeCount = 0;

            foreach (TalkRoomModel model in modelList)
            {
                DialogueTalkRoomList.AddTalkRoom(model.Name, model.NoticeCount, model);
                DialogueTalkRoomListTitle.NoticeCount += model.NoticeCount;
            }
        }

        /// <summary>
        /// グループトークルームリストを表示させる
        /// </summary>
        /// <param name="modelList">トークルームを格納したクラスのリスト</param>
        private void ShowGroupTalkRoomGroupContents(List<TalkRoomModel> modelList)
        {
            GroupTalkRoomListTitle.NoticeCount = 0;

            foreach (TalkRoomModel model in modelList)
            {
                GroupTalkRoomList.AddTalkRoom(model.Name, model.NoticeCount, model);
                GroupTalkRoomListTitle.NoticeCount += model.NoticeCount;
            }
        }

        /// <summary>
        /// 勧誘されているグループトークルームリストを表示させる
        /// </summary>
        /// <param name="modelList">トークルームを格納したクラスのリスト</param>
        private void ShowDesireGroupTalkRoomGroupContents(List<TalkRoomModel> modelList)
        {
            DesireGroupTalkRoomListTitle.NoticeCount = modelList.Count;

            foreach (TalkRoomModel model in modelList)
            {
                DesireGroupTalkRoomList.AddTalkRoom(model.Name, model.NoticeCount, model);
            }
        }

        /// <summary>
        /// 友達追加申請者とのトークルームリストを表示させる
        /// </summary>
        /// <param name="modelList">トークルームを格納したクラスのリスト</param>
        private void ShowDesireDialogueTalkRoomGroupContents(List<TalkRoomModel> modelList)
        {
            DesireDialogueTalkRoomListTitle.NoticeCount = modelList.Count;
            foreach (TalkRoomModel model in modelList)
            {
                DesireDialogueTalkRoomList.AddTalkRoom(model.Name, model.NoticeCount, model);
            }
        }

        /// <summary>
        /// スピナーを表示させる
        /// </summary>
        private void StartSpinnerMode()
        {
            SpinnerBox.Visible = true;
            UseWaitCursor = true;
        }

        /// <summary>
        /// スピナーを非表示にする
        /// </summary>
        private void FinishSpinnerMode()
        {
            SpinnerBox.Visible = false;
            UseWaitCursor = false;
        }
    }
}
