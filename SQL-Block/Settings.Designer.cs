namespace Winforms_experiment
{
    partial class Settings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            label1 = new Label();
            Volume = new TrackBar();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Move_Right = new TextBox();
            Move_Left = new TextBox();
            Pause = new TextBox();
            Boost = new TextBox();
            Turn_Left = new TextBox();
            Turn_Right = new TextBox();
            SaveKeybinds = new Button();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(197, 178);
            label1.Name = "label1";
            label1.Size = new Size(112, 27);
            label1.TabIndex = 5;
            label1.Text = "Settings:";
            // 
            // Volume
            // 
            Volume.BackColor = Color.Black;
            Volume.Cursor = Cursors.Hand;
            Volume.Location = new Point(197, 489);
            Volume.Maximum = 100;
            Volume.Name = "Volume";
            Volume.RightToLeft = RightToLeft.No;
            Volume.Size = new Size(130, 56);
            Volume.TabIndex = 15;
            Volume.TickStyle = TickStyle.None;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(151, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 337);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 220);
            label2.Name = "label2";
            label2.Size = new Size(156, 266);
            label2.TabIndex = 6;
            label2.Text = "Move right:\r\n\r\nMove left:\r\n\r\nTurn right:\r\n\r\nTurn left:\r\n\r\nBoost:\r\n\r\nPause:\r\n\r\n\r\n        Music Volume";
            // 
            // Move_Right
            // 
            Move_Right.Location = new Point(290, 218);
            Move_Right.Name = "Move_Right";
            Move_Right.Size = new Size(50, 27);
            Move_Right.TabIndex = 16;
            // 
            // Move_Left
            // 
            Move_Left.Location = new Point(290, 256);
            Move_Left.Name = "Move_Left";
            Move_Left.Size = new Size(50, 27);
            Move_Left.TabIndex = 17;
            // 
            // Pause
            // 
            Pause.Location = new Point(290, 409);
            Pause.Name = "Pause";
            Pause.Size = new Size(50, 27);
            Pause.TabIndex = 18;
            // 
            // Boost
            // 
            Boost.Location = new Point(290, 370);
            Boost.Name = "Boost";
            Boost.Size = new Size(50, 27);
            Boost.TabIndex = 19;
            // 
            // Turn_Left
            // 
            Turn_Left.Location = new Point(290, 332);
            Turn_Left.Name = "Turn_Left";
            Turn_Left.Size = new Size(50, 27);
            Turn_Left.TabIndex = 20;
            // 
            // Turn_Right
            // 
            Turn_Right.Location = new Point(290, 294);
            Turn_Right.Name = "Turn_Right";
            Turn_Right.Size = new Size(50, 27);
            Turn_Right.TabIndex = 21;
            // 
            // SaveKeybinds
            // 
            SaveKeybinds.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveKeybinds.BackColor = SystemColors.ControlText;
            SaveKeybinds.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveKeybinds.ForeColor = SystemColors.ButtonHighlight;
            SaveKeybinds.Location = new Point(367, 878);
            SaveKeybinds.Name = "SaveKeybinds";
            SaveKeybinds.Size = new Size(119, 49);
            SaveKeybinds.TabIndex = 22;
            SaveKeybinds.Text = "Save";
            SaveKeybinds.UseVisualStyleBackColor = false;
            SaveKeybinds.Click += SaveKeybinds_Click;
            // 
            // Settings
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Firebrick;
            ClientSize = new Size(510, 952);
            Controls.Add(SaveKeybinds);
            Controls.Add(Turn_Right);
            Controls.Add(Turn_Left);
            Controls.Add(Boost);
            Controls.Add(Pause);
            Controls.Add(Move_Left);
            Controls.Add(Move_Right);
            Controls.Add(Volume);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;

        private TrackBar Volume;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox Move_Right;
        private TextBox Move_Left;
        private TextBox Pause;
        private TextBox Boost;
        private TextBox Turn_Left;
        private TextBox Turn_Right;
        private Button SaveKeybinds;
    }
}
