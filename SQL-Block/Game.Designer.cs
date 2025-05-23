namespace Winforms_experiment
{
    partial class Wintris_Gameplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wintris_Gameplay));
            imageList1 = new ImageList(components);
            button1 = new Button();
            PauseMenu = new PictureBox();
            scoreDisplay = new Label();
            levelDisplay = new Label();
            GameTime = new Label();
            Settings = new Button();
            Continue = new Button();
            leaveGame = new Button();
            GameOverScreen = new PictureBox();
            GameOverAgain = new Button();
            GameOverLeave = new Button();
            GameOverScore = new Label();
            GameOverTime = new Label();
            iDisplay = new PictureBox();
            tDisplay = new PictureBox();
            lDisplay = new PictureBox();
            jDisplay = new PictureBox();
            oDisplay = new PictureBox();
            sDisplay = new PictureBox();
            zDisplay = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PauseMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GameOverScreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zDisplay).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(454, 15);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(25, 22);
            button1.TabIndex = 10;
            button1.TabStop = false;
            button1.Text = "I I";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PauseMenu
            // 
            PauseMenu.BackColor = Color.Transparent;
            PauseMenu.Image = Properties.Resources.Design_ohne_Titel__5__removebg_preview;
            PauseMenu.Location = new Point(53, 85);
            PauseMenu.Margin = new Padding(3, 2, 3, 2);
            PauseMenu.Name = "PauseMenu";
            PauseMenu.Size = new Size(411, 614);
            PauseMenu.TabIndex = 1;
            PauseMenu.TabStop = false;
            // 
            // scoreDisplay
            // 
            scoreDisplay.AutoSize = true;
            scoreDisplay.BackColor = Color.Transparent;
            scoreDisplay.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreDisplay.Location = new Point(42, 19);
            scoreDisplay.Name = "scoreDisplay";
            scoreDisplay.Size = new Size(50, 18);
            scoreDisplay.TabIndex = 2;
            scoreDisplay.Text = "label1";
            // 
            // levelDisplay
            // 
            levelDisplay.AutoSize = true;
            levelDisplay.BackColor = Color.Transparent;
            levelDisplay.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            levelDisplay.Location = new Point(198, 19);
            levelDisplay.Name = "levelDisplay";
            levelDisplay.Size = new Size(50, 18);
            levelDisplay.TabIndex = 3;
            levelDisplay.Text = "label2";
            // 
            // GameTime
            // 
            GameTime.AutoSize = true;
            GameTime.BackColor = Color.Transparent;
            GameTime.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameTime.Location = new Point(330, 18);
            GameTime.Name = "GameTime";
            GameTime.Size = new Size(50, 18);
            GameTime.TabIndex = 4;
            GameTime.Text = "label3";
            // 
            // Settings
            // 
            Settings.BackColor = Color.Black;
            Settings.Location = new Point(198, 341);
            Settings.Margin = new Padding(3, 2, 3, 2);
            Settings.Name = "Settings";
            Settings.Size = new Size(139, 41);
            Settings.TabIndex = 11;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = false;
            Settings.Click += Settings_Click;
            // 
            // Continue
            // 
            Continue.BackColor = Color.Black;
            Continue.Location = new Point(198, 400);
            Continue.Margin = new Padding(3, 2, 3, 2);
            Continue.Name = "Continue";
            Continue.Size = new Size(139, 41);
            Continue.TabIndex = 12;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // leaveGame
            // 
            leaveGame.BackColor = Color.Black;
            leaveGame.Location = new Point(198, 461);
            leaveGame.Margin = new Padding(3, 2, 3, 2);
            leaveGame.Name = "leaveGame";
            leaveGame.Size = new Size(139, 41);
            leaveGame.TabIndex = 13;
            leaveGame.Text = "leave Game";
            leaveGame.UseVisualStyleBackColor = false;
            leaveGame.Click += leaveGame_Click;
            // 
            // GameOverScreen
            // 
            GameOverScreen.BackColor = Color.Transparent;
            GameOverScreen.Image = Properties.Resources.Game_Over__1__removebg_preview;
            GameOverScreen.Location = new Point(10, 168);
            GameOverScreen.Margin = new Padding(3, 2, 3, 2);
            GameOverScreen.Name = "GameOverScreen";
            GameOverScreen.Size = new Size(486, 380);
            GameOverScreen.TabIndex = 14;
            GameOverScreen.TabStop = false;
            // 
            // GameOverAgain
            // 
            GameOverAgain.BackColor = Color.Black;
            GameOverAgain.Location = new Point(102, 461);
            GameOverAgain.Margin = new Padding(3, 2, 3, 2);
            GameOverAgain.Name = "GameOverAgain";
            GameOverAgain.Size = new Size(139, 41);
            GameOverAgain.TabIndex = 15;
            GameOverAgain.Text = "Play Again";
            GameOverAgain.UseVisualStyleBackColor = false;
            GameOverAgain.Click += GameOverAgain_Click;
            // 
            // GameOverLeave
            // 
            GameOverLeave.BackColor = Color.Black;
            GameOverLeave.Location = new Point(270, 461);
            GameOverLeave.Margin = new Padding(3, 2, 3, 2);
            GameOverLeave.Name = "GameOverLeave";
            GameOverLeave.Size = new Size(139, 41);
            GameOverLeave.TabIndex = 16;
            GameOverLeave.Text = "Leave Game";
            GameOverLeave.UseVisualStyleBackColor = false;
            GameOverLeave.Click += GameOverLeave_Click;
            // 
            // GameOverScore
            // 
            GameOverScore.AutoSize = true;
            GameOverScore.BackColor = Color.Black;
            GameOverScore.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameOverScore.Location = new Point(230, 412);
            GameOverScore.Name = "GameOverScore";
            GameOverScore.Size = new Size(50, 18);
            GameOverScore.TabIndex = 17;
            GameOverScore.Text = "label3";
            // 
            // GameOverTime
            // 
            GameOverTime.AutoSize = true;
            GameOverTime.BackColor = Color.Black;
            GameOverTime.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameOverTime.Location = new Point(230, 384);
            GameOverTime.Name = "GameOverTime";
            GameOverTime.Size = new Size(50, 18);
            GameOverTime.TabIndex = 18;
            GameOverTime.Text = "label3";
            // 
            // iDisplay
            // 
            iDisplay.Image = (Image)resources.GetObject("iDisplay.Image");
            iDisplay.Location = new Point(379, 116);
            iDisplay.Name = "iDisplay";
            iDisplay.Size = new Size(100, 200);
            iDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            iDisplay.TabIndex = 19;
            iDisplay.TabStop = false;
            // 
            // tDisplay
            // 
            tDisplay.Image = (Image)resources.GetObject("tDisplay.Image");
            tDisplay.Location = new Point(379, 116);
            tDisplay.Name = "tDisplay";
            tDisplay.Size = new Size(100, 200);
            tDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            tDisplay.TabIndex = 20;
            tDisplay.TabStop = false;
            // 
            // lDisplay
            // 
            lDisplay.Image = (Image)resources.GetObject("lDisplay.Image");
            lDisplay.Location = new Point(379, 116);
            lDisplay.Name = "lDisplay";
            lDisplay.Size = new Size(100, 200);
            lDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            lDisplay.TabIndex = 21;
            lDisplay.TabStop = false;
            // 
            // jDisplay
            // 
            jDisplay.Image = (Image)resources.GetObject("jDisplay.Image");
            jDisplay.Location = new Point(379, 116);
            jDisplay.Name = "jDisplay";
            jDisplay.Size = new Size(100, 200);
            jDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            jDisplay.TabIndex = 22;
            jDisplay.TabStop = false;
            // 
            // oDisplay
            // 
            oDisplay.Image = (Image)resources.GetObject("oDisplay.Image");
            oDisplay.Location = new Point(379, 116);
            oDisplay.Name = "oDisplay";
            oDisplay.Size = new Size(100, 200);
            oDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            oDisplay.TabIndex = 23;
            oDisplay.TabStop = false;
            // 
            // sDisplay
            // 
            sDisplay.Image = (Image)resources.GetObject("sDisplay.Image");
            sDisplay.Location = new Point(379, 116);
            sDisplay.Name = "sDisplay";
            sDisplay.Size = new Size(100, 200);
            sDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            sDisplay.TabIndex = 24;
            sDisplay.TabStop = false;
            // 
            // zDisplay
            // 
            zDisplay.Image = (Image)resources.GetObject("zDisplay.Image");
            zDisplay.Location = new Point(379, 116);
            zDisplay.Name = "zDisplay";
            zDisplay.Size = new Size(100, 200);
            zDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            zDisplay.TabIndex = 25;
            zDisplay.TabStop = false;
            // 
            // Wintris_Gameplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(500, 950);
            ControlBox = false;
            Controls.Add(zDisplay);
            Controls.Add(sDisplay);
            Controls.Add(oDisplay);
            Controls.Add(jDisplay);
            Controls.Add(lDisplay);
            Controls.Add(tDisplay);
            Controls.Add(iDisplay);
            Controls.Add(GameOverTime);
            Controls.Add(GameOverScore);
            Controls.Add(GameOverLeave);
            Controls.Add(GameOverAgain);
            Controls.Add(GameOverScreen);
            Controls.Add(leaveGame);
            Controls.Add(Continue);
            Controls.Add(Settings);
            Controls.Add(GameTime);
            Controls.Add(levelDisplay);
            Controls.Add(scoreDisplay);
            Controls.Add(PauseMenu);
            Controls.Add(button1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Wintris_Gameplay";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Wintris_Gameplay";
            Load += Wintris_Gameplay_Load;
            ((System.ComponentModel.ISupportInitialize)PauseMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)GameOverScreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)iDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)lDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)jDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)oDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)sDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)zDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        public PictureBox PauseMenu;
        public Label scoreDisplay;
        private Label levelDisplay;
        private Label GameTime;
        public Button button1;
        private Button Settings;
        private Button Continue;
        private Button leaveGame;
        public PictureBox GameOverScreen;
        private Button GameOverAgain;
        private Button GameOverLeave;
        private Label GameOverScore;
        private Label GameOverTime;
        private PictureBox iDisplay;
        private PictureBox tDisplay;
        private PictureBox lDisplay;
        private PictureBox jDisplay;
        private PictureBox oDisplay;
        private PictureBox sDisplay;
        private PictureBox zDisplay;
    }
}