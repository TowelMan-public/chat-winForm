using System;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class DesireMenuControl : UserControl
    {
        public EventHandler BrockButtonClick
        {
            set => BrockButton.Click += value;
        }

        public EventHandler AcceptButtonClick
        {
            set => AcceptButton.Click += value;
        }

        public DesireMenuControl()
        {
            InitializeComponent();
        }

        private void DesireMenuControl_Load(object sender, EventArgs e)
        {

        }
    }
}
