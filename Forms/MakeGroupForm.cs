using chat_winForm.Forms.Commons;
using chat_winForm.Service;
using System;
using System.Drawing;

namespace chat_winForm.Forms
{
    /// <summary>
    /// グループ作成画面
    /// </summary>
    public partial class MakeGroupForm : chat_winForm.OuterForm
    {
        public delegate void Prosess();

        /// <summary>
        /// グループを作成した後の後処理
        /// </summary>
        public Prosess MakeGroup_After { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MakeGroupForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// このフォームが読み込まれたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void MakeGroupForm_Load(object sender, EventArgs e)
        {
            //バリデーション 
            ValidateChildren();
        }

        /// <summary>
        /// グループ作成ボタンが押されたときのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void MakeGrolupButton_Click(object sender, EventArgs e)
        {
            if (MakeGroupErrorProvider.GetError(GroupNameTextBox) != "")
            {
                CommonMessageBoxs.ValidationMessageBox();
                return;
            }

            try
            {
                StartSpinnerMode();

                GroupService.MakeGroup(GroupNameTextBox.Text);
            }
            finally
            {
                FinishSpinnerMode();
                MakeGroup_After();
            }
        }

        /// <summary>
        /// グループ名のバリデーションチェックのイベントハンドラー
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使われる情報</param>
        private void GroupNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MakeGroupErrorProvider.SetError(GroupNameTextBox,
                new Validater(GroupNameTextBox.Text)
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
            if (MakeGroupErrorProvider.GetError(GroupNameTextBox) == "")
                GroupNameTextBox.BackColor = Color.White;
            else
                GroupNameTextBox.BackColor = Color.Red;
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
