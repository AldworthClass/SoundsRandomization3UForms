using SoundsRandomization.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        SoundPlayer player;
        int score = 0;
        int dog = 0, cat = 1, pig = 2, sound;

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void imgCat_Click(object sender, EventArgs e)
        {
            if (sound == cat)
            {
                score += 1;
                lblResults.Text = "Score: " + score + " - You are correct!";
            }
            else
                lblResults.Text = "Score: " + score + " - You are incorrect!";

        }

        private void imgPig_Click(object sender, EventArgs e)
        {
            if (sound == pig)
            {
                score += 1;
                lblResults.Text = "Score: " + score + " - You are correct!";
            }
            else
                lblResults.Text = "Score: " + score + " - You are incorrect!";

        }

        private void imgDog_Click(object sender, EventArgs e)
        {
            if (sound == dog)
            {
                score += 1;
                lblResults.Text = "Score: " + score + " - You are correct!";
            }
            else
                lblResults.Text = "Score: " + score + " - You are incorrect!";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            sound = generator.Next(3); // Pick a sound to play
            if (sound == dog)
            {
                player = new SoundPlayer(Resources.woof);
            }
            else if (sound == cat)
            {
                player = new SoundPlayer(Resources.meow);
            }
            else if (sound == pig) 
            {
                player = new SoundPlayer(Resources.oink);
            }
            player.Play();

        }
    }
}
