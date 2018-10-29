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
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FallingRocks.level1().Show();
            Hide();
        }

        private void levelselectbutton_Click(object sender, EventArgs e)
        {
            new LevelSelect().Show();
            Hide();
        }
    }
}
