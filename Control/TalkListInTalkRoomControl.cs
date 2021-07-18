using chat_winForm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// １つのトークルームのメニューとトークリスト画面のコントロール
    /// </summary>
    public partial class TalkListInTalkRoomControl : UserControl
    {
        public delegate List<TalkModel> LoadTalkList(int startIndex, int maxSize);

        /// <summary>
        /// 一番新しいトークインデックスの取得のセット・取得
        /// </summary>
        public int NewestTalkIndex
        {
            get => BodyControl.NewestTalkIndex;
        }

        /// <summary>
        /// このコントロールで使うデータセットのセット・取得
        /// </summary>
        public TalkRoomModel Model { get; set; }

        /// <summary>
        /// トークリストを読み込む為の処理が書いてあるデリゲーターのセット・取得
        /// </summary>
        public LoadTalkList TalkListLoader { get; set; }

        /// <summary>
        /// トークをクリックしたときのイベント
        /// </summary>
        public EventHandler TalkClickEventHandler
        {
            get => BodyControl.TalkControlClick;
            set => BodyControl.TalkControlClick = value;
        }

        /// <summary>
        /// メニュー画面のコントロールクラスのセット・取得
        /// </summary>
        public UserControl SubContentControl
        {
            get => _subContentControl;
            set
            {
                if (_subContentControl != null)
                {
                    Controls.Remove(_subContentControl);
                    _subContentControl.Dispose();
                }

                _subContentControl = value;
                _subContentControl.Visible = false;
                Controls.Add(_subContentControl);
                SubContentControl.Width = Width;
                SubContentControl.Location = new Point
                {
                    X = 0,
                    Y = SwitchButton.Height
                };
                SubContentControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                SubContentControl.BringToFront();
            }
        }

        private UserControl _subContentControl;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TalkListInTalkRoomControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新しいトークリストを読み込む
        /// </summary>
        public async void UpdateTalkList()
        {
            try
            {
                StartSpinnerMode();

                int startIndex = BodyControl.NewestTalkIndex + 1;
                List<TalkModel> talkModelList = await Task.Run(() => TalkListLoader(startIndex, 25));
                BodyControl.AddNewerTalkList(talkModelList);

            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// このコントロールが読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void TalkListInTalkRoomControl_Load(object sender, EventArgs e)
        {
            TalkRoomListPanel.Controls.Remove(SpinnerBox);
            Controls.Add(SpinnerBox);
            SpinnerBox.BringToFront();

            try
            {
                StartSpinnerMode();

                SwitchButton.Text = Model.Name;
                List<TalkModel> talkModelList = await Task.Run(() => TalkListLoader(Model.LastTalkIndex - 25, 50));
                BodyControl.ShowTalkList(talkModelList);
                BodyControl.LoadNewerTalkButtonClick += BodyControl_LoadNewerTalkButtonClick;
                BodyControl.LoadOlderTalkButtonClick += BodyControl_LoadOlderTalkButtonClick;

            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// メニュー画面を表示する活かしないかを切り替えているボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void SwitchButton_Click(object sender, EventArgs e)
        {
            if (SubContentControl != null)
            {
                SubContentControl.Visible ^= true;
            }
        }

        /// <summary>
        /// もっと新しいトークをロードするボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void BodyControl_LoadNewerTalkButtonClick(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                int startIndex = BodyControl.NewestTalkIndex + 1;
                List<TalkModel> talkModelList = await Task.Run(() => TalkListLoader(startIndex, 25));
                BodyControl.AddNewerTalkList(talkModelList);
            }
            finally
            {
                FinishSpinnerMode();
            }
        }

        /// <summary>
        /// もっと古いトークをロードするボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void BodyControl_LoadOlderTalkButtonClick(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                int startIndex = BodyControl.OldestTalkIndex - 25;
                List<TalkModel> talkModelList = await Task.Run(() => TalkListLoader(startIndex, 25));
                BodyControl.AddOlderTalkList(talkModelList);
            }
            finally
            {
                FinishSpinnerMode();
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
