using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toturial8_6
{
    enum spectrum
    {
        Red, Orange, Yellow, Green,
        Blue, Indigo, Violet
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //The DisplayColor method displays the name of a color.
        private void DisplayColor(spectrum color)
        {
            colorLabel.Text = color.ToString();
        }

        private void redLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(spectrum.Red);
        }

        private void orangeLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(spectrum.Orange);
        }

        private void yellowLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(spectrum.Yellow);
        }

        private void greenLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(spectrum.Green);
        }

        private void blueLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(spectrum.Blue);
        }

        private void indigoLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(spectrum.Indigo);
        }

        private void violetLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(spectrum.Violet);
        }
    }
}
