using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = colorDialog1.Color;
            button1.Text = comboBox1.Text + " " + textBox1.Text + ' ' + textBox2.Text;
        }
    }
}
