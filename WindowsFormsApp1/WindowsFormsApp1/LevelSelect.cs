using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LevelSelect : Form
    {
        public LevelSelect()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            Hide();
        }

        private void level1Button_Click(object sender, EventArgs e)
        {
            new FallingRocks.level1().Show();
            Hide();
        }

        private void level2Button_Click(object sender, EventArgs e)
        {

        }

        private void level3Button_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //level4Button
        {

        }

        private void level5Button_Click(object sender, EventArgs e)
        {

        }

        private void userlevelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
