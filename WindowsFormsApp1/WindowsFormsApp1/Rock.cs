using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Rock : PictureBox
    {
        private int locationX = 0;
        private int locationY = 0;
        private string shape;
        private bool fallingActive = false;

        //array of rocks
        //application starts, then set location on each rock
        //220, 100    340, 100   540,100
        public Rock()
        {
            this.Tag = "rock";
            this.Location = new Point(0, 0);
            this.BackColor = Color.FromArgb(128, 0, 0);
            this.Size = new Size(60, 60);
            //shape = objShape;
            //locationY = locY;
            //this.pictureBox.Location = new Point(locX, locY);
            // PictureBox p = new PictureBox();
            //p.Location = new Point(0, 0);
            //p.Size = new Size(100, 400);
            //p.BorderStyle = BorderStyle.FixedSingle;
            //this.Controls.Add(p);
        }

        public int LocationX { get; set; }

        public int LocationY { get; set; }

        public string Shape { get; set; }

        public bool FallingActive { get; set; }

        public void SetLocation(Point vals)
        {
            this.Location = vals;
        }
    }
}
