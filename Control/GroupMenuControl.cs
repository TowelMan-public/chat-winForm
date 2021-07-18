using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// グループトークルームリスト画面のメニュー画面
    /// </summary>
    public partial class GroupMenuControl : UserControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GroupMenuControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// グループ詳細画面表示ボタンクリック時のイベントのセット・取得
        /// </summary>
        public EventHandler ShowGroupDetailsButtonClick
        {
            set => ShowGroupDetailsButton.Click += value;
        }

    }
}
