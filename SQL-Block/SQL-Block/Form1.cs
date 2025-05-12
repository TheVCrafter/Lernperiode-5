namespace Winforms_experiment
{
    public partial class Wintris : Form
    {
        MusicPlayer mainmenumusic = new MusicPlayer();
        bool enterPressed = false;
        public static string username;
        public static int highscore;
        public static int Volume;
        public Wintris()
        {
            InitializeComponent();
            if (username == null)
            {
                button1.Hide();
                button2.Hide();
                displayHighscores.Hide();
                HighscoreDisplay.Hide();
                displayUsername.Hide();
                ChangeUsername.Hide();
            }
            else
            {
                highscore = DataBaseManagement.UserHighscore(username);
                HighscoreDisplay.Text = $"Your Highscore: {highscore}";
                usernameInput.Hide();
                enterUsernameLabel.Hide();
            }
            this.CenterToScreen();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            string path = "C:\\Users\\vince\\source\\repos\\Winforms experiment\\bin\\Debug\\title-101soundboards.mp3";
            mainmenumusic.PlayMusic(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Wintris_Gameplay game = new Wintris_Gameplay();
            game.Show();
            mainmenumusic.StopMusic();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && usernameInput.Text.Length > 0 || username != null)
            {
                username = usernameInput.Text;
                usernameInput.Hide();
                enterUsernameLabel.Hide();
                button1.Show();
                button2.Show();
                displayHighscores.Show();
                DataBaseManagement.NewUser(username);
                highscore = DataBaseManagement.UserHighscore(username);
                HighscoreDisplay.Text = $"Best score: {highscore}";
                HighscoreDisplay.Show();
                displayUsername.Text = $"Logged in as {username}";
                displayUsername.Show();
                ChangeUsername.Show();
            }
        }
        private void displayHighscores_Click(object sender, EventArgs e)
        {
            Highscores highscoresDisplay = new Highscores();
            this.Hide();
            highscoresDisplay.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            username = null;
            this.Hide();
            Wintris wintris = new Wintris();
            wintris.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }
    }
}
