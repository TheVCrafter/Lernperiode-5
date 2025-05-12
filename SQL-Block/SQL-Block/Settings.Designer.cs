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
            this.label1 = new Label();
            this.label2 = new Label();
            this.pictureBox1 = new PictureBox();
            this.Move_left = new ComboBox();
            this.Boost = new ComboBox();
            this.Turn_Left = new ComboBox();
            this.Turn_right = new ComboBox();
            this.Move_right = new ComboBox();
            this.Pause = new ComboBox();
            this.Volume = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.ForeColor = SystemColors.ButtonHighlight;
            this.label1.Location = new Point(187, 73);
            this.label1.Name = "label1";
            this.label1.Size = new Size(112, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Settings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Black;
            this.label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(149, 125);
            this.label2.Name = "label2";
            this.label2.Size = new Size(141, 266);
            this.label2.TabIndex = 6;
            this.label2.Text = "Move right:\r\n\r\nMove left:\r\n\r\nTurn right:\r\n\r\nTurn left:\r\n\r\nBoost:\r\n\r\nPause:\r\n\r\n\r\n     Music Volume";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = Color.Black;
            this.pictureBox1.Location = new Point(130, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(194, 426);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Move_left
            // 
            this.Move_left.AllowDrop = true;
            this.Move_left.FormattingEnabled = true;
            this.Move_left.Location = new Point(253, 153);
            this.Move_left.Name = "Move_left";
            this.Move_left.Size = new Size(56, 28);
            this.Move_left.TabIndex = 10;
            // 
            // Boost
            // 
            this.Boost.AllowDrop = true;
            this.Boost.FormattingEnabled = true;
            this.Boost.Location = new Point(253, 267);
            this.Boost.Name = "Boost";
            this.Boost.Size = new Size(56, 28);
            this.Boost.TabIndex = 11;
            // 
            // Turn_Left
            // 
            this.Turn_Left.AllowDrop = true;
            this.Turn_Left.FormattingEnabled = true;
            this.Turn_Left.Location = new Point(253, 229);
            this.Turn_Left.Name = "Turn_Left";
            this.Turn_Left.Size = new Size(56, 28);
            this.Turn_Left.TabIndex = 12;
            // 
            // Turn_right
            // 
            this.Turn_right.AllowDrop = true;
            this.Turn_right.FormattingEnabled = true;
            this.Turn_right.Location = new Point(253, 191);
            this.Turn_right.Name = "Turn_right";
            this.Turn_right.Size = new Size(56, 28);
            this.Turn_right.TabIndex = 13;
            // 
            // Move_right
            // 
            this.Move_right.AllowDrop = true;
            this.Move_right.FormattingEnabled = true;
            this.Move_right.Location = new Point(253, 115);
            this.Move_right.Name = "Move_right";
            this.Move_right.Size = new Size(56, 28);
            this.Move_right.TabIndex = 9;
            // 
            // Pause
            // 
            this.Pause.AllowDrop = true;
            this.Pause.FormattingEnabled = true;
            this.Pause.Location = new Point(253, 305);
            this.Pause.Name = "Pause";
            this.Pause.Size = new Size(56, 28);
            this.Pause.TabIndex = 14;
            // 
            // Volume
            // 
            this.Volume.BackColor = Color.Black;
            this.Volume.Cursor = Cursors.Hand;
            this.Volume.Location = new Point(169, 394);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.RightToLeft = RightToLeft.Yes;
            this.Volume.Size = new Size(130, 56);
            this.Volume.TabIndex = 15;
            this.Volume.TickStyle = TickStyle.None;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Firebrick;
            this.ClientSize = new Size(482, 903);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Turn_right);
            this.Controls.Add(this.Turn_Left);
            this.Controls.Add(this.Boost);
            this.Controls.Add(this.Move_left);
            this.Controls.Add(this.Move_right);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Name = "Settings";
            this.StartPosition = FormStartPosition.WindowsDefaultBounds;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;

        private ComboBox Move_left;
        private ComboBox Move_right;
        private ComboBox Turn_Left;
        private ComboBox Turn_right;
        private ComboBox Boost;
        private ComboBox Pause;

        private TrackBar Volume;
    }
}
