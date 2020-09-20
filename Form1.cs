using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here we go!");
            Hero.Visible = true;
            Enemy.Visible = true;
            Food.Visible = true;
            buttonStart.Visible = false;
            Hero.Top = 200;
            Hero.Left = 150;
        }
    }
}
