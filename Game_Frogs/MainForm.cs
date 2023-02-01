namespace Game_Frogs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void startOverToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rulesOfTheGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var rulesForm = new RulesForm();
            rulesForm.Show();
        }
    }
}