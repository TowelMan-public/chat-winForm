using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// グループ勧誘・友達追加申請のトークリスト画面に表示するメニュー画面
    /// </summary>
    public partial class DesireMenuControl : UserControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DesireMenuControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ブロックボタンがクリックされたときのイベントをセット・取得する
        /// </summary>
        public EventHandler BrockButtonClick
        {
            set => BrockButton.Click += value;
        }

        /// <summary>
        /// 受け入れるボタンが押されたときのイベントをセット・取得する
        /// </summary>
        public EventHandler AcceptButtonClick
        {
            set => AcceptButton.Click += value;
        }
    }
}
