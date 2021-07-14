using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class DialogueMenuControl : UserControl
    {
        public EventHandler BrockButtonClick
        {
            set => BrockButton.Click += value;
        }

        public String UserIdNameText
        {
            get => UserIdNameLabel.Text;
            set => UserIdNameLabel.Text = "ユーザーID：" + value;
        }

        public String UserNameText
        {
            get => UserNameLabel.Text;
            set => UserNameLabel.Text = "ユーザー名：" + value;
        }

        public DialogueMenuControl()
        {
            InitializeComponent();
        }

        private void DialogueMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
