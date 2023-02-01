namespace Game_Frogs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);

            if ((PictureBox)sender != emptyPictureBox)
            {
                scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
            }

            if (IsWin())
            {
                if (Convert.ToInt32(scoreLabel.Text) == 24)
                {
                    var winForm = new WinForm();
                    winForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Congratulations! You won for the {Convert.ToInt32(scoreLabel.Text)} amount! \nBut, this is not the minimum number of moves, you can improve your result by clicking File - Start over");
                }
            }
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("You can't move like that!");
            }
            else
            {
                var location = clickedPicture.Location;

                clickedPicture.Location = emptyPictureBox.Location;

                emptyPictureBox.Location = location;
            }
        }

        private bool IsWin()
        {
            var middleLine = ClientSize.Width / 2;

            return leftPictureBox1.Location.X > middleLine && leftPictureBox2.Location.X > middleLine && leftPictureBox3.Location.X > middleLine && leftPictureBox4.Location.X > middleLine
                && rightPictureBox1.Location.X < middleLine && rightPictureBox2.Location.X < middleLine && rightPictureBox3.Location.X < middleLine && rightPictureBox4.Location.X < middleLine;
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