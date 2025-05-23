namespace Winforms_experiment
{
    partial class Wintris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wintris));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            usernameInput = new TextBox();
            enterUsernameLabel = new Label();
            displayHighscores = new Button();
            HighscoreDisplay = new Label();
            displayUsername = new Label();
            ChangeUsername = new Button();
            Settings = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(212, 361);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 37);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 950);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = SystemColors.ControlText;
            button2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(340, 361);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 37);
            button2.TabIndex = 2;
            button2.Text = "Quit Game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // usernameInput
            // 
            usernameInput.BackColor = SystemColors.ControlText;
            usernameInput.ForeColor = SystemColors.ControlLightLight;
            usernameInput.Location = new Point(212, 378);
            usernameInput.Margin = new Padding(0);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(104, 23);
            usernameInput.TabIndex = 3;
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.AutoSize = true;
            enterUsernameLabel.BackColor = SystemColors.ControlText;
            enterUsernameLabel.BorderStyle = BorderStyle.Fixed3D;
            enterUsernameLabel.ForeColor = Color.Crimson;
            enterUsernameLabel.Location = new Point(212, 361);
            enterUsernameLabel.Margin = new Padding(0);
            enterUsernameLabel.Name = "enterUsernameLabel";
            enterUsernameLabel.Size = new Size(104, 17);
            enterUsernameLabel.TabIndex = 4;
            enterUsernameLabel.Text = "Enter a Username:";
            // 
            // displayHighscores
            // 
            displayHighscores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            displayHighscores.BackColor = SystemColors.ControlText;
            displayHighscores.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayHighscores.ForeColor = SystemColors.ButtonHighlight;
            displayHighscores.Location = new Point(132, 415);
            displayHighscores.Margin = new Padding(3, 2, 3, 2);
            displayHighscores.Name = "displayHighscores";
            displayHighscores.Size = new Size(108, 37);
            displayHighscores.TabIndex = 5;
            displayHighscores.Text = "Highscores";
            displayHighscores.UseVisualStyleBackColor = false;
            displayHighscores.Click += displayHighscores_Click;
            // 
            // HighscoreDisplay
            // 
            HighscoreDisplay.AutoSize = true;
            HighscoreDisplay.BackColor = Color.Brown;
            HighscoreDisplay.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HighscoreDisplay.ForeColor = SystemColors.ButtonFace;
            HighscoreDisplay.Location = new Point(21, 32);
            HighscoreDisplay.Name = "HighscoreDisplay";
            HighscoreDisplay.Size = new Size(96, 15);
            HighscoreDisplay.TabIndex = 6;
            HighscoreDisplay.Text = "Your Highscore:";
            // 
            // displayUsername
            // 
            displayUsername.AutoSize = true;
            displayUsername.BackColor = Color.Brown;
            displayUsername.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayUsername.ForeColor = Color.White;
            displayUsername.Location = new Point(21, 7);
            displayUsername.Name = "displayUsername";
            displayUsername.Size = new Size(11, 15);
            displayUsername.TabIndex = 7;
            displayUsername.Text = "-";
            // 
            // ChangeUsername
            // 
            ChangeUsername.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChangeUsername.BackColor = SystemColors.ControlText;
            ChangeUsername.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeUsername.ForeColor = SystemColors.ButtonHighlight;
            ChangeUsername.Location = new Point(271, 415);
            ChangeUsername.Margin = new Padding(3, 2, 3, 2);
            ChangeUsername.Name = "ChangeUsername";
            ChangeUsername.Size = new Size(108, 37);
            ChangeUsername.TabIndex = 8;
            ChangeUsername.Text = "Change User";
            ChangeUsername.UseVisualStyleBackColor = false;
            ChangeUsername.Click += button3_Click;
            // 
            // Settings
            // 
            Settings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Settings.BackColor = SystemColors.ControlText;
            Settings.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settings.ForeColor = SystemColors.ButtonHighlight;
            Settings.Location = new Point(68, 361);
            Settings.Margin = new Padding(3, 2, 3, 2);
            Settings.Name = "Settings";
            Settings.Size = new Size(108, 37);
            Settings.TabIndex = 9;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = false;
            Settings.Click += Settings_Click;
            // 
            // Wintris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(500, 950);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(Settings);
            Controls.Add(ChangeUsername);
            Controls.Add(displayUsername);
            Controls.Add(HighscoreDisplay);
            Controls.Add(displayHighscores);
            Controls.Add(enterUsernameLabel);
            Controls.Add(usernameInput);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Wintris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wintris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private TextBox usernameInput;
        private Label enterUsernameLabel;
        private Button displayHighscores;
        private Label HighscoreDisplay;
        private Label displayUsername;
        private Button ChangeUsername;
        private Button Settings;
    }
}
