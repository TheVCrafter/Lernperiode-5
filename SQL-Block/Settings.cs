using NAudio.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_experiment
{
    public partial class Settings : Form
    {
        TextBox lastClicked;
        private Form parentform;

        public Settings(Form parent)
        {
            InitializeComponent();
            Volume.Maximum = 100;
            Volume.Minimum = 0;
            parentform = parent;
            this.KeyPreview = true;
            this.KeyDown += Settings_KeyDown;
            Volume.Scroll += volumeSlider_Scroll;

            // Tastenbelegung anzeigen
            Move_Right.Text = Convert.ToString(Wintris_Gameplay.GoRightKey);
            Move_Left.Text = Convert.ToString(Wintris_Gameplay.GoLeftKey);
            Turn_Left.Text = Convert.ToString(Wintris_Gameplay.LeftRotateKey);
            Turn_Right.Text = Convert.ToString(Wintris_Gameplay.RightRotateKey);
            Boost.Text = Convert.ToString(Wintris_Gameplay.BoostKey);
            Pause.Text = Convert.ToString(Wintris_Gameplay.PauseKey);

            // Lautstärke initial setzen
            Volume.Value = (int)Wintris.Volume;

            // Textfelder vorbereiten
            foreach (Control controls in this.Controls)
            {
                if (controls is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    textBox.Click += TextBox_Clicked;
                }
            }
        }

        private void TextBox_Clicked(object sender, EventArgs e)
        {
            lastClicked = (TextBox)sender;
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (lastClicked != null && Convert.ToString(e.KeyCode) != lastClicked.Text)
            {
                lastClicked.Text = Convert.ToString(e.KeyCode);
            }
        }

        private void SaveKeybinds_Click(object sender, EventArgs e)
        {
            Keys newKey;
            if (Enum.TryParse(Move_Right.Text, out newKey)) Wintris_Gameplay.GoRightKey = newKey;
            if (Enum.TryParse(Move_Left.Text, out newKey)) Wintris_Gameplay.GoLeftKey = newKey;
            if (Enum.TryParse(Turn_Left.Text, out newKey)) Wintris_Gameplay.LeftRotateKey = newKey;
            if (Enum.TryParse(Turn_Right.Text, out newKey)) Wintris_Gameplay.RightRotateKey = newKey;
            if (Enum.TryParse(Boost.Text, out newKey)) Wintris_Gameplay.BoostKey = newKey;
            if (Enum.TryParse(Pause.Text, out newKey)) Wintris_Gameplay.PauseKey = newKey;

            Wintris.Volume = Volume.Value;
            this.Hide();
            parentform.Show();
        }

        private void volumeSlider_Scroll(object sender, EventArgs e)
        {
            Wintris.Volume = Volume.Value;
            MusicPlayer.Instance.Volume=Wintris.Volume / 100f;
        }
    }
}
