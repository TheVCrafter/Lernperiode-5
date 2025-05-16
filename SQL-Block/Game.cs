using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Win32;
using NAudio.Utils;
using NAudio.Wave;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Winforms_experiment
{
    public partial class Wintris_Gameplay : Form
    {
        public static Keys LeftRotateKey = Keys.W;
        public static Keys BoostKey = Keys.Space;
        public static Keys GoLeftKey = Keys.A;
        public static Keys GoRightKey = Keys.D;
        public static Keys PauseKey = Keys.Escape;
        public static Keys RightRotateKey = Keys.S;
        int size = 50;
        int startX = 50, startY = 50;
        int movementY = 50;
        int movementseed = 50;
        int timerinterval = 500;
        bool boostactive = false;
        int shapecounter = 0;
        int xoffset = 0;
        int yoffset = 0;
        int score = 0;
        int level = 1;
        bool turningright = false;
        TimeSpan timeForDisplay;
        Stopwatch gameTime = new Stopwatch();
        int[,] nextCoordinates;
        PictureBox[] nextShape = new PictureBox[4];
        PictureBox[] previousShapes = new PictureBox[2048];
        private System.Windows.Forms.Timer fallTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer gameTimeUpdate = new System.Windows.Forms.Timer();
        private Dictionary<string, int[][,]> shapeRotations;

        public Wintris_Gameplay()
        {
            InitializeComponent();
            this.CenterToScreen();
            PauseMenu.Hide();
            Continue.Hide();
            leaveGame.Hide();
            Settings.Hide();
            GameOverScreen.Hide();
            GameOverLeave.Hide();
            GameOverAgain.Hide();
            GameOverScore.Hide();
            GameOverTime.Hide();
            gameTimeUpdate.Interval = 1;
            gameTimeUpdate.Tick += GameTime_Tick;
            fallTimer.Interval = 500;
            fallTimer.Tick += FallTimer_Tick;
            fallTimer.Start();
            gameTime.Start();
            gameTimeUpdate.Start();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Game_KeyDown);
            scoreDisplay.Text = $"Score: {score}";
            levelDisplay.Text = $"Level: {level}";
            this.Controls.Add(scoreDisplay);
            this.Controls.Add(levelDisplay);

            // Formen initialisieren (wie gehabt)
            int[,] oCoordinates = { { -1, 3 }, { -1, 4 }, { 0, 3 }, { 0, 4 } };

            int[,] sCoordinates_0 = { { -1, 3 }, { 0, 3 }, { 0, 2 }, { -1, 4 } };
            int[,] sCoordinates_90 = { { -1, 2 }, { 0, 3 }, { 0, 2 }, { 1, 3 } };

            int[,] zCoordinates_0 = { { -1, 3 }, { -1, 4 }, { 0, 4 }, { 0, 5 } };
            int[,] zCoordinates_90 = { { 0, 3 }, { -1, 4 }, { 1, 3 }, { 0, 4 } };

            int[,] lCoordinates_0 = { { -1, 3 }, { 0, 3 }, { 1, 3 }, { 1, 4 } };
            int[,] lCoordinates_90 = { { 0, 2 }, { 0, 3 }, { -1, 4 }, { 0, 4 } };
            int[,] lCoordinates_180 = { { -1, 2 }, { 0, 3 }, { -1, 3 }, { 1, 3 } };
            int[,] lCoordinates_270 = { { 0, 2 }, { 0, 3 }, { 1, 2 }, { 0, 4 } };

            int[,] jCoordinates_0 = { { -1, 3 }, { 0, 3 }, { 1, 3 }, { 1, 2 } };
            int[,] jCoordinates_90 = { { 0, 2 }, { 0, 3 }, { 0, 4 }, { 1, 4 } };
            int[,] jCoordinates_180 = { { -1, 3 }, { 0, 3 }, { 1, 3 }, { -1, 4 } };
            int[,] jCoordinates_270 = { { -1, 2 }, { 0, 3 }, { 0, 2 }, { 0, 4 } };

            int[,] tCoordinates_0 = { { -1, 3 }, { 0, 3 }, { 0, 2 }, { 0, 4 } };
            int[,] tCoordinates_90 = { { -1, 3 }, { 0, 3 }, { 1, 3 }, { 0, 2 } };
            int[,] tCoordinates_180 = { { 0, 2 }, { 0, 3 }, { 1, 3 }, { 0, 4 } };
            int[,] tCoordinates_270 = { { -1, 3 }, { 0, 3 }, { 1, 3 }, { 0, 4 } };

            int[,] iCoordinates_0 = { { -1, 3 }, { 0, 3 }, { 1, 3 }, { 2, 3 } };
            int[,] iCoordinates_90 = { { 0, 2 }, { 0, 3 }, { 0, 4 }, { 0, 5 } };

            shapeRotations = new Dictionary<string, int[][,]>
            {
                { "S", new int[][,] { sCoordinates_0, sCoordinates_90 } },
                { "Z", new int[][,] { zCoordinates_0, zCoordinates_90 } },
                { "L", new int[][,] { lCoordinates_0, lCoordinates_90, lCoordinates_180, lCoordinates_270 } },
                { "J", new int[][,] { jCoordinates_0, jCoordinates_90, jCoordinates_180, jCoordinates_270 } },
                { "T", new int[][,] { tCoordinates_0, tCoordinates_90, tCoordinates_180, tCoordinates_270 } },
                { "I", new int[][,] { iCoordinates_0, iCoordinates_90 } }
            };
            MusicPlayer.Instance.PlayMusic(@"C:\Users\vince\source\repos\Winforms experiment\bin\Debug\TETRIS PHONK.mp3");
            CreateShape();
        }

        // Restlicher Code bleibt unverändert, außer alle player -> MusicPlayer.Instance

        private void leaveGame_Click(object sender, EventArgs e)
        {
            Wintris mainMenu = new Wintris();
            MusicPlayer.Instance.StopMusic();
            this.Close();
            mainMenu.Show();
            DataBaseManagement.NewScore(score);
            DataBaseManagement.User2Score(score, Wintris.username);
        }

        private void GameOverAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wintris_Gameplay game = new Wintris_Gameplay();
            game.Show();
            MusicPlayer.Instance.StopMusic();
            DataBaseManagement.NewScore(score);
            DataBaseManagement.User2Score(score, Wintris.username);
        }
        void CreateShape()
        {
            scoreDisplay.Text = $"Score: {score}";
            levelDisplay.Text = $"Level: {level}";
            xoffset = 0;
            yoffset = 0;
            Random rnd = new Random();
            List<string> shapeKeys = new List<string>(shapeRotations.Keys);
            string randomShapeKey = shapeKeys[rnd.Next(shapeKeys.Count)];
            currentShape = randomShapeKey; // Setze die aktuelle Form für die Rotation
            nextCoordinates = shapeRotations[randomShapeKey][0];
            NeueForm(nextCoordinates);
        }
        void NeueForm(int[,] koordinaten)
        {
            for (int i = 0; i < koordinaten.GetLength(0); i++)
            {
                int x = koordinaten[i, 1];
                int y = koordinaten[i, 0];

                PictureBox box = new PictureBox
                {
                    Width = size,
                    Height = size,
                    Left = startX + (x * size),
                    Top = startY + (y * size),
                    BackColor = Color.DarkRed,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Image.FromFile("C:\\Users\\vince\\source\\repos\\Winforms experiment\\bin\\Debug\\Wintrisblock.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };



                nextShape[i] = (box);
                this.Controls.Add(box);
            }
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            bool touchingEdge = false;
            if (e.KeyCode == GoLeftKey)
            {
                foreach (PictureBox box in nextShape)
                {
                    if (box.Left == 0)
                    {
                        touchingEdge = true;
                    }
                }
                if (!touchingEdge)
                {
                    for (int i = 0; i < previousShapes.Length; i++)
                    {
                        if (previousShapes[i] == null) continue;

                        foreach (PictureBox box in nextShape)
                        {
                            if (box.Left == previousShapes[i].Right && box.Bottom == previousShapes[i].Bottom)
                            {
                                touchingEdge = true;
                                break;
                            }
                        }
                    }
                }
                if (!touchingEdge)
                {
                    foreach (PictureBox box in nextShape)
                    {
                        box.Left -= movementY;
                    }
                }
            }
            if (e.KeyCode == GoRightKey)
            {
                foreach (PictureBox box in nextShape)
                {
                    if (box.Right >= this.ClientRectangle.Right)
                    {
                        touchingEdge = true;
                    }
                }
                if (!touchingEdge)
                {
                    for (int i = 0; i < previousShapes.Length; i++)
                    {
                        if (previousShapes[i] == null) continue;

                        foreach (PictureBox box in nextShape)
                        {
                            if (box.Right == previousShapes[i].Left && box.Bottom == previousShapes[i].Bottom && previousShapes[i].Visible)
                            {
                                touchingEdge = true;
                                break;
                            }
                        }
                    }
                }
                if (!touchingEdge)
                {
                    foreach (PictureBox box in nextShape)
                    {
                        box.Left += movementY;
                        xoffset = box.Left;
                    }
                }
            }
            if (e.KeyCode == RightRotateKey)
            {
                if (currentShape != previousShape)
                {
                    currentRotationIndex = 0;
                }
                turningright = true;
                RotateShape();
            }
            if (e.KeyCode == LeftRotateKey)
            {
                if (currentShape != previousShape)
                {
                    currentRotationIndex = 0;
                }
                turningright = false;
                RotateShape();
            }
                if (e.KeyCode == BoostKey)
            {
                boostactive = true;
            }
            else
            {
                boostactive = false;
            }
            if (e.KeyCode == PauseKey)
            {
                button1.PerformClick();
            }
        }
        private void GameTime_Tick(object sender, EventArgs e)
        {
            timeForDisplay = gameTime.Elapsed;
            GameTime.Text = $"Time: {timeForDisplay.Minutes}:{timeForDisplay.Seconds:D2}:{timeForDisplay.Milliseconds:D3}";
        }
        private void FallTimer_Tick(object sender, EventArgs e)
        {
            if (boostactive)
            {
                fallTimer.Interval = 50;
            }
            else
            {
                fallTimer.Interval = timerinterval;
            }
            bool touchingBottom = false;
            foreach (PictureBox box in nextShape)
            {
                if (box.Bottom >= this.ClientRectangle.Bottom)
                {
                    touchingBottom = true;
                }
            }
            if (!touchingBottom)
            {
                for (int i = 0; i < previousShapes.Length; i++)
                {
                    if (previousShapes[i] == null) continue;

                    foreach (PictureBox box in nextShape)
                    {
                        if (box.Bottom == previousShapes[i].Top && box.Left == previousShapes[i].Left && previousShapes[i].Visible)
                        {
                            touchingBottom = true;
                            break;
                        }
                    }
                }
            }
            if (!touchingBottom)
            {
                foreach (PictureBox box in nextShape)
                {
                    box.Top += size;
                }
            }
            if (touchingBottom)
            {          
                for (int i = 0; i < nextShape.Length; i++)
                {
                    for (int j = 0; j < previousShapes.Length; j++)
                    {
                        if (previousShapes[j] == null)
                        {
                            previousShapes[j] = nextShape[i];
                            break;
                        }
                    }
                    boostactive = false;
                }
                for (int i = 19; i > 0; i--)
                {
                    int y = i * size;
                    int boxesInLine = 0;
                    foreach (PictureBox box in previousShapes)
                    {
                        if (box != null && box.Top == y && box.Visible)
                        {
                            boxesInLine++;
                        }
                    }
                    if (boxesInLine == 10)
                    {
                        foreach (PictureBox box in previousShapes)
                        {
                            if (box != null && box.Top == y)
                            {
                                box.Hide();
                            }
                            if (box != null && box.Top < y && box.Visible)
                            {
                                box.Top += size;
                            }
                        }
                        score += boxesInLine;
                        if (score % 100 == 0)
                        {
                            timerinterval -= 5;
                            level++;
                        }
                        i = 19;
                    }
                }
                for (int i = 0; i < previousShapes.Length; i++)
                {
                    if (previousShapes[i] != null && !previousShapes[i].Visible)
                    {
                        previousShapes[i] = null;
                    }
                }
                for (int i = 0; i < previousShapes.Length; i++)
                {
                    if (previousShapes[i] != null && previousShapes[i].Top == this.ClientRectangle.Top)
                    {
                        foreach (PictureBox box in previousShapes)
                        {
                            if (box != null)
                            {
                                GameOver();
                            }
                        }
                    }
                }
                CreateShape();

            }
        }
        private string currentShape = "";
        private int currentRotationIndex = 0;
        private string previousShape;
        int previousRotation;
        void RotateShape()
        {
            int rotation;
            previousRotation = currentRotationIndex;
            previousShape = currentShape;

            rotation = turningright ? 1 : -1;

            if (shapeRotations.ContainsKey(currentShape))
            {
                int len = shapeRotations[currentShape].Length;
                currentRotationIndex = (currentRotationIndex + rotation + len) % len;
                int[,] newCoordinates = shapeRotations[currentShape][currentRotationIndex];
                ApplyNewCoordinates(newCoordinates);
            }
        }
        void ApplyNewCoordinates(int[,] newCoordinates)
        {
            bool illegalrotation = false;
            int[] newXCoordinateswithoffset = new int[nextShape.Length];
            int[] newYCoordinateswithoffset = new int[nextShape.Length];
            xoffset = nextShape[1].Left - (newCoordinates[1, 1] * size);
            yoffset = nextShape[1].Top - (newCoordinates[1, 0] * size);
            for (int i = 0; i < nextShape.Length; i++)
            {
                int x = newCoordinates[i, 1] * size + xoffset;
                int y = newCoordinates[i, 0] * size + yoffset;
                foreach (PictureBox box in previousShapes)
                {
                    if (box != null && box.Visible && (box.Left == x && box.Top == y))
                    {
                        illegalrotation = true;
                        break;
                    }
                }
                if (x < 0 || x > this.ClientRectangle.Right - 50 || y > this.ClientRectangle.Bottom - 50)
                {
                    illegalrotation = true;
                }
                newXCoordinateswithoffset[i] = x;
                newYCoordinateswithoffset[i] = y;
            }
            if (illegalrotation)
            {
                currentRotationIndex = previousRotation;
                return;
            }

            for (int i = 0; i < nextShape.Length; i++)
            {
                nextShape[i].Left = newXCoordinateswithoffset[i];
                nextShape[i].Top = newYCoordinateswithoffset[i];
            }
        }
        public void GameOver()
        {
            scoreDisplay.Hide();
            levelDisplay.Hide();
            GameTime.Hide();
            button1.Hide();
            GameOverScreen.Show();
            GameOverLeave.Show();
            GameOverLeave.BringToFront();
            GameOverAgain.Show();
            GameOverAgain.BringToFront();
            GameOverScore.Show();
            GameOverScore.BringToFront();
            GameOverTime.Show();
            GameOverTime.BringToFront();
            GameOverScore.Text = scoreDisplay.Text;
            GameOverTime.Text = GameTime.Text;
            gameTime.Stop();
            fallTimer.Stop();
            gameTimeUpdate.Stop();
            foreach (PictureBox box in previousShapes)
            {
                if (box != null)
                {
                    box.Visible = false;
                }
            }
            foreach (PictureBox box in nextShape)
            {
                box.Visible = false;
            }
        }
        private void Wintris_Gameplay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            PauseMenu.Show();
            Continue.Show();
            Settings.Show();
            leaveGame.Show();
            fallTimer.Stop();
            gameTime.Stop();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            this.Hide();
            settings.Show();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            PauseMenu.Hide();
            Continue.Hide();
            button1.Show();
            leaveGame.Hide();
            Settings.Hide();
            fallTimer.Start();
            gameTime.Start();
        }
        private void GameOverLeave_Click(object sender, EventArgs e)
        {
            leaveGame_Click(sender, e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Unterdrücke Pfeiltasten, damit sie keinen Fokuswechsel auslösen
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                return true; // Fokuswechsel verhindern
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
