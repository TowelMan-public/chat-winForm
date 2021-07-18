using chat_winForm.Forms.Commons;
using chat_winForm.Model;
using chat_winForm.Service;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    /// <summary>
    /// トーク編集画面
    /// </summary>
    public partial class TalkEditorForm : chat_winForm.OuterForm
    {
        public delegate void Prosess();

        /// <summary>
        /// この画面で使われるデータが格納されているクラスのセット・取得
        /// </summary>
        public TalkModel Model { get; set; }

        /// <summary>
        /// この画面で、ユーザー操作による処理の後処理のセット・取得
        /// </summary>
        public Prosess Action_After { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TalkEditorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// この画面が読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void TalkEditorForm_Load(object sender, EventArgs e)
        {
            TalkContentErrorProvider.SetIconAlignment(TalkContentTextBox, ErrorIconAlignment.TopLeft);
            TalkContentTextBox.Text = Model.ContentText;

            if (Model is DialogueTalkModel)
            {
                TitleLabel.Text = $"「{(Model as DialogueTalkModel).HaveUserIdName}」さんとのトークを編集します";
            }
            else
            {
                TitleLabel.Text = $"とあるグループでのトークを編集します";
            }
        }

        /// <summary>
        /// トークを削除するボタンがクリックされたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void DeleteTalkButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartSpinnerMode();

                if (Model is DialogueTalkModel)
                {
                    DialogueTalkModel dialogueTalkModel = Model as DialogueTalkModel;
                    await Task.Run(() => { TalkService.DeleteDialogueTalk(dialogueTalkModel.HaveUserIdName, dialogueTalkModel.TalkIndex); });
                }
                else
                {
                    GroupTalkModel groupTalkModel = Model as GroupTalkModel;
                    await Task.Run(() => { TalkService.DeleteGroupTalk(groupTalkModel.GroupTalkRoomId, groupTalkModel.TalkIndex); });
                }
            }
            finally
            {
                FinishSpinnerMode();
                Action_After();
                Close();
            }
        }

        /// <summary>
        /// トークを変更するボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private async void UpdateTalkButton_Click(object sender, EventArgs e)
        {
            if (TalkContentErrorProvider.GetError(TalkContentTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();

                if (Model is DialogueTalkModel)
                {
                    DialogueTalkModel dialogueTalkModel = Model as DialogueTalkModel;
                    await Task.Run(() =>
                    {
                        TalkService.UpdateDialogueTalk(dialogueTalkModel.HaveUserIdName, dialogueTalkModel.TalkIndex, TalkContentTextBox.Text);
                    });
                }
                else
                {
                    GroupTalkModel groupTalkModel = Model as GroupTalkModel;
                    await Task.Run(() =>
                    {
                        TalkService.UpdateGroupTalk(groupTalkModel.GroupTalkRoomId, groupTalkModel.TalkIndex, TalkContentTextBox.Text);
                    });
                }
            }
            finally
            {
                FinishSpinnerMode();
                Action_After();
            }
        }

        /// <summary>
        /// トークの内容のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
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
