using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Winforms_experiment
{
    public partial class Highscores : Form
    {
        string[] Playernames;
        private ColumnHeader Score;
        int[] Scores;
        public Highscores()
        {
            InitializeComponent();
            this.CenterToScreen();
            object[][] data = DataBaseManagement.AllHighscores();
            foreach ( var row in data )
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                highscoreList.Items.Add(item);
                if (highscoreList.Height < 672)
                highscoreList.Height += 21;
            }
        }

        private void InitializeComponent()
        {
            ColumnHeader Player;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Highscores));
            backToMenu = new Button();
            label1 = new Label();
            highscoreList = new ListView();
            Score = new ColumnHeader();
            Player = new ColumnHeader();
            SuspendLayout();
            // 
            // Player
            // 
            Player.Text = "Player";
            Player.Width = 150;
            // 
            // backToMenu
            // 
            backToMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backToMenu.BackColor = SystemColors.ControlText;
            backToMenu.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToMenu.ForeColor = SystemColors.ButtonHighlight;
            backToMenu.Location = new Point(196, 846);
            backToMenu.Name = "backToMenu";
            backToMenu.Size = new Size(119, 49);
            backToMenu.TabIndex = 3;
            backToMenu.Text = "Back to Mainscreen";
            backToMenu.UseVisualStyleBackColor = false;
            backToMenu.Click += backToMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(149, 73);
            label1.Name = "label1";
            label1.Size = new Size(193, 27);
            label1.TabIndex = 4;
            label1.Text = "All Time Scores:";
            // 
            // highscoreList
            // 
            highscoreList.BackColor = Color.Black;
            highscoreList.Columns.AddRange(new ColumnHeader[] { Player, Score });
            highscoreList.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highscoreList.ForeColor = Color.White;
            highscoreList.FullRowSelect = true;
            highscoreList.Location = new Point(93, 103);
            highscoreList.Name = "highscoreList";
            highscoreList.Size = new Size(304, 28);
            highscoreList.TabIndex = 5;
            highscoreList.UseCompatibleStateImageBehavior = false;
            highscoreList.View = View.Details;
            // 
            // Score
            // 
            Score.Text = "Score";
            Score.Width = 150;
            // 
            // Highscores
            // 
            BackColor = Color.Firebrick;
            ClientSize = new Size(494, 907);
            Controls.Add(highscoreList);
            Controls.Add(label1);
            Controls.Add(backToMenu);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Highscores";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private ListView highscoreList;
        private Button backToMenu;

        private void backToMenu_Click(object sender, EventArgs e)
        {
            Wintris mainMenu = new Wintris();
            this.Hide();
            mainMenu.Show();
        }
    }
}
