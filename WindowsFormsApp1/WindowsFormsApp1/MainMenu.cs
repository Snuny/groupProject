﻿using System;
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
            new level1().Show();
            Hide();
        }

        private void levelselectbutton_Click(object sender, EventArgs e)
        {
            new LevelSelect().Show();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)//restartbutton
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
