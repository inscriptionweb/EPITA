using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        Fonctions fonction;

        float label_stock_nb;

        public Form1()
        {
            InitializeComponent();
            fonction = new Fonctions();

            Console.WriteLine(fonction.is_sexy(17, 11));
            Console.WriteLine(fonction.my_pow(2, 4));
            Console.WriteLine(fonction.rad_to_deg(3.14159f));
            Console.ReadLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            affiche_labelstock(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            affiche_labelstock(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            affiche_labelstock(3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            affiche_labelstock(4);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            affiche_labelstock(5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            affiche_labelstock(6);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            affiche_labelstock(7);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            affiche_labelstock(8);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            affiche_labelstock(9);

        }




        public void affiche_labelstock(int nombre)
        {
            label_stock_nb =label_stock_nb*10 + nombre;
            label_stock.Text = label_stock_nb.ToString();

        }



    }
}
