using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// 友達トークリスト画面のメニュー画面
    /// </summary>
    public partial class DialogueMenuControl : UserControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DialogueMenuControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ブロックボタンが押されたときのクリックイベントのセット・取得をする
        /// </summary>
        public EventHandler BrockButtonClick
        {
            set => BrockButton.Click += value;
        }

        /// <summary>
        /// メニュー画面に表示されるユーザーID名
        /// </summary>
        public String UserIdNameText
        {
            get => UserIdNameLabel.Text;
            set => UserIdNameLabel.Text = "ユーザーID：" + value;
        }

        /// <summary>
        /// メニュー画面に表示されるユーザー名
        /// </summary>
        public String UserNameText
        {
            get => UserNameLabel.Text;
            set => UserNameLabel.Text = "ユーザー名：" + value;
        }

    }
}
