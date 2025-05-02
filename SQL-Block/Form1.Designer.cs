﻿namespace Winforms_experiment
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(57, 404);
            button1.Name = "button1";
            button1.Size = new Size(119, 49);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 954);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = SystemColors.ControlText;
            button2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(337, 404);
            button2.Name = "button2";
            button2.Size = new Size(119, 49);
            button2.TabIndex = 2;
            button2.Text = "Quit Game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // usernameInput
            // 
            usernameInput.BackColor = SystemColors.ControlText;
            usernameInput.ForeColor = SystemColors.ControlLightLight;
            usernameInput.Location = new Point(195, 426);
            usernameInput.Margin = new Padding(0);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(130, 27);
            usernameInput.TabIndex = 3;
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.AutoSize = true;
            enterUsernameLabel.BackColor = SystemColors.ControlText;
            enterUsernameLabel.BorderStyle = BorderStyle.Fixed3D;
            enterUsernameLabel.ForeColor = Color.Crimson;
            enterUsernameLabel.Location = new Point(195, 406);
            enterUsernameLabel.Margin = new Padding(0);
            enterUsernameLabel.Name = "enterUsernameLabel";
            enterUsernameLabel.Size = new Size(130, 22);
            enterUsernameLabel.TabIndex = 4;
            enterUsernameLabel.Text = "Enter a Username:";
            // 
            // displayHighscores
            // 
            displayHighscores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            displayHighscores.BackColor = SystemColors.ControlText;
            displayHighscores.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayHighscores.ForeColor = SystemColors.ButtonHighlight;
            displayHighscores.Location = new Point(200, 404);
            displayHighscores.Name = "displayHighscores";
            displayHighscores.Size = new Size(119, 49);
            displayHighscores.TabIndex = 5;
            displayHighscores.Text = "Highscores";
            displayHighscores.UseVisualStyleBackColor = false;
            displayHighscores.Click += displayHighscores_Click;
            // 
            // Wintris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(510, 952);
            ControlBox = false;
            Controls.Add(displayHighscores);
            Controls.Add(enterUsernameLabel);
            Controls.Add(usernameInput);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Wintris";
            Text = "Wintris";
            Load += Form1_Load;
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
    }
}
