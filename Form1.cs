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
        int dog = 0, cat = 1, pig = 2;
        int randomSound;

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void imgCat_Click(object sender, EventArgs e)
        {
            if (randomSound == cat)
            {
                score += 1;
                lblResults.Text = "Score: " + score + ".  You are correct!";
            }
            else
            {
                score -= 1;
                lblResults.Text = "Score: " + score + ".  You are incorrect!";
            }
            DisableAnimalSelection();
        }

        private void imgPig_Click(object sender, EventArgs e)
        {
            if (randomSound == pig)
            {
                score += 1;
                lblResults.Text = "Score: " + score + ".  You are correct!";
            }
            else
            {
                score -= 1;
                lblResults.Text = "Score: " + score + ".  You are incorrect!";
            }
            DisableAnimalSelection();
        }

        private void imgDog_Click(object sender, EventArgs e)
        {
            if (randomSound == dog)
            {
                score += 1;
                lblResults.Text = "Score: " + score + ".  You are correct!";
            }
            else
            {
                score -= 1;
                lblResults.Text = "Score: " + score + ".  You are incorrect!";
            }
            DisableAnimalSelection();
        }

        public Form1()
        {
            InitializeComponent();
        }


        // User will be able to select an animal
        public void EnableAnimalSelection()
        {
            imgCat.Enabled = true;
            imgDog.Enabled = true;
            imgPig.Enabled = true;
        }

        // User will be unable to select an animal
        public void DisableAnimalSelection()
        {
            imgCat.Enabled = false;
            imgDog.Enabled = false;
            imgPig.Enabled = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            randomSound = generator.Next(3); // Pick a sound to play
            
            // Assigns the correct sound based on random generator
            if (randomSound == dog)
            {
                player = new SoundPlayer(Resources.woof);
            }
            else if (randomSound == cat)
            {
                player = new SoundPlayer(Resources.meow);
            }
            else if (randomSound == pig) 
            {
                player = new SoundPlayer(Resources.oink);
            }
            player.Play();
            EnableAnimalSelection(); // Sound has played, enables guessing
        }
    }
}
