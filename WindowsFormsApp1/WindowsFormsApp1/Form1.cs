using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingRocks
{
    public partial class level1 : Form
    {
        bool goLeft = false;
        bool goRight = false;
        bool jumpUp = false;
        bool pause = false;

        int jumpingSpeed = 10;
        int force = 8;
        int score = 0;

        public level1()
        {
            InitializeComponent();
            pauseMenu.Hide();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Space && !jumpUp)
            {
                jumpUp = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                pause = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (jumpUp)
            {
                jumpUp = false;
            }

            if (e.KeyCode == Keys.Escape)
            {
                pause = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpingSpeed;

            //Key Controls
            if (jumpUp && force < 0)
            {
                jumpUp = false;
            }

            if (goLeft)
            {
                player.Left -= 5;
            }

            if (goRight)
            {
                player.Left += 5;
            }

            if (jumpUp)
            {
                jumpingSpeed = -12;
                force -= 1;
            }

            if (pause)
            {
                pauseMenu.Show();
            }

            else
            {
                jumpingSpeed = 12;
            }

            //Timer Controls
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumpUp)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }
            }
        }

        private void level1_Load(object sender, EventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            new level1().Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            new WindowsFormsApp1.MainMenu().Show();
            Hide();
        }
    }
}
