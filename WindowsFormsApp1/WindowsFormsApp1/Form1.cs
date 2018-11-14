using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using System.Diagnostics;

namespace FallingRocks
{
    public partial class level1 : Form
    {
        bool goLeft = false;
        bool goRight = false;
        bool jumpUp = false;

        int jumpingSpeed = 10;
        int force = 8;
        int score = 0;
        int fallingSpeed = 2;
        int activeRock = 0;

        List<Rock> Rocks = new List<Rock>()
            {
                new Rock(),
                new Rock(),
                new Rock(),
                new Rock(),
                new Rock(),
                new Rock(),
                new Rock(),
                new Rock(),
                new Rock()
            };

        public level1()
        {
            InitializeComponent();
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpingSpeed;
            pictureBox3.Top += fallingSpeed;
            if (Rocks[activeRock].FallingActive = true)
                Rocks[activeRock].Top += fallingSpeed;

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

                    if (pictureBox3.Bounds.IntersectsWith(x.Bounds))
                    {
                        pictureBox3.Top = x.Top - pictureBox3.Height;
                    }

                    foreach (Rock rock in Rocks)
                    {
                        //Add falling active and counter for rock list
                        if (rock is Rock && rock.Tag == "rock" && rock.FallingActive == true)
                        {

                            if (rock.Bounds.IntersectsWith(player.Bounds))
                            {
                                rock.Top = player.Top - rock.Height;
                            }
                            //Rocks[activeRock].FallingActive = true;
                            if (rock.Bounds.IntersectsWith(x.Bounds))
                            {
                                rock.Top = x.Top - rock.Height;
                                activeRock++;
                                Rocks[activeRock].FallingActive = true;
                                Rocks[activeRock].Visible = true;
                            }
                        }
                    }
                }
            }

            ////foreach (Rock x in this.Controls.OfType<Rock>())
            //foreach (Rock rock in Rocks)
            //{
            //    //Add falling active and counter for rock list
            //    if (x is Rock && x.Tag == "rock" && x.FallingActive == true)
            //    {

            //        if (rock.Bounds.IntersectsWith(x.Bounds))
            //        {
            //            rock.Top = x.Top - rock.Height;
            //        }
            //        //Rocks[activeRock].FallingActive = true;
            //        if (x.Bounds.IntersectsWith(player.Bounds))
            //        {
            //            x.Top = player.Top - x.Height;
            //            activeRock++;
            //        }
            //    }
            //}
        }

        private void fallOnLoad(object sender, AsyncCompletedEventArgs e)
        {
            //PictureBox p = new PictureBox();
            //p.Location = new Point(0, 0);
            //p.Size = new Size(100, 400);
            //p.BorderStyle = BorderStyle.FixedSingle;
            //this.Controls.Add(p);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        //private void Form1_Load(object sender, AsyncCompletedEventArgs e)
        {

            Point[] locations = new Point[]
            {
                new Point(100, 100),
                new Point(340, 100),
                new Point(540, 100),
                new Point(100, 100),
                new Point(340, 100),
                new Point(540, 100),
                new Point(100, 100),
                new Point(340, 100),
                new Point(540, 100)
            };

            for (int i = 0; i < Rocks.Count; i++)
            {
                Rocks[i].SetLocation(locations[i]);
                Rocks[i].Visible = false;
                this.Controls.Add(Rocks[i]);
            }

            Rocks[0].FallingActive = true;
            Rocks[0].Visible = true;
            WaitSomeTime();
        }

        public async void WaitSomeTime()
        {
            await Task.Delay(1000);
            label1.Text = "2";
            await Task.Delay(1000);
            label1.Text = "1";
            await Task.Delay(1000);
            label1.Visible = false;

            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
