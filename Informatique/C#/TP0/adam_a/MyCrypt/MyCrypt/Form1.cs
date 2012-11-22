using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cacher_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';

        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            String text = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                text += (char)(textBox1.Text[i] + 13);
            }
            textBox1.Text = text;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = (char)0;
        }


    }
}
