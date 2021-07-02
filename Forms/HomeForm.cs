using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace chat_winForm.Forms
{
    public partial class HomeForm : chat_winForm.OuterForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            //画像の透過処置
            //(MakeGroupButton.BackgroundImage as Bitmap).MakeTransparent();
            //(InsertDialogueButton.BackgroundImage as Bitmap).MakeTransparent();
            //(UserConfingButton.BackgroundImage as Bitmap).MakeTransparent();
        }

        private void HomeForm_Load_1(object sender, System.EventArgs e)
        {

        }
    }
}
