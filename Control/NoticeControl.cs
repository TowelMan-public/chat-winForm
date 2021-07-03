using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_winForm.Control
{
    public partial class NoticeControl : UserControl
    {
        public float FontSize
        {
            get
            {
                return NoticeLabel.Font.Size;
            }
            set
            {

                NoticeLabel.Font = new Font("MS UI Gothic", value, FontStyle.Regular, GraphicsUnit.Point, 128);
            }
        }

        public new String Text
        {
            get
            {
                return NoticeLabel.Text;
            }
            set
            {
                NoticeLabel.Text = value;
            }
        }

        public NoticeControl()
        {
            InitializeComponent();
        }

        private void NoticeControl_Load(object sender, EventArgs e)
        {
            (BackgroundImage as Bitmap).MakeTransparent();
        }
    }
}
