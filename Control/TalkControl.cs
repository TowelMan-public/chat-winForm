using chat_winForm.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    /// <summary>
    /// トークコントロール（1件のトーク）
    /// </summary>
    public partial class TalkControl : UserControl
    {
        private const int TALK_WIDTH_ONE_MERGIN = 130;
        private bool alreadyAdaptWide;
        private int oldWidth;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TalkControl()
        {
            InitializeComponent();
            alreadyAdaptWide = false;
            oldWidth = -1;
        }

        /// <summary>
        /// このコントロールで使うデータセット
        /// </summary>
        public TalkModel Model
        {
            get => Inner.Model;
            set
            {
                Inner.Model = value;
                AdaptWide();
            }
        }

        /// <summary>
        /// トークをクリックしたときのイベントのセット・取得
        /// </summary>
        public event EventHandler TalkClickEventHandler
        {
            add => Inner.TalkClickEventHandler += value;
            remove => Inner.TalkClickEventHandler -= value;
        }

        /// <summary>
        /// 幅によるサイズ、位置の調節
        /// </summary>
        private void AdaptWide()
        {
            Inner.Width = Width - TALK_WIDTH_ONE_MERGIN;
            Inner.PaintAll();

            if (Model.IsMyTake)
            {
                Inner.Location = new Point(Width - Inner.Width, 0);
            }
            else
            {
                Inner.Location = new Point(0, 0);
            }

            Height = Inner.Height;
            alreadyAdaptWide = true;
        }

        /// <summary>
        /// サイズが変更されたときのイベント
        /// </summary>
        /// <param name="sender">イベント発生主</param>
        /// <param name="e">イベントで使うデータ等</param>
        private void TalkControl_SizeChanged(object sender, EventArgs e)
        {
            if (alreadyAdaptWide && oldWidth != Width)
            {
                AdaptWide();
                oldWidth = Width;
            }
        }
    }
}
