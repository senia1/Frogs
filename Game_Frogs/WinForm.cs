
namespace Game_Frogs
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
