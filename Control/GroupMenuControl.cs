using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class GroupMenuControl : UserControl
    {
        public EventHandler ShowGroupDetailsButtonClick
        {
            set => ShowGroupDetailsButton.Click += value;
        }

        public GroupMenuControl()
        {
            InitializeComponent();
        }

        private void GroupMenuControl_Load(object sender, EventArgs e)
        {

        }
    }
}
