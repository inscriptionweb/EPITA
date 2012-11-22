using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTinyDemineur
{
    public partial class Form1 : Form
    {
        int Bombe;
        Random rand = new Random();
        bool Gagne;
        bool EnCours;
        int Boutons;

        public Form1()
        {
            InitializeComponent();

            Bombe = rand.Next(1, 4);

            EnCours = true;

            Boutons = 0;

            button1.Text = "_";
            button2.Text = "_";
            button3.Text = "_";
            button4.Text = "_";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            Statut();
        }


        public void Statut()
        {

            if (Boutons == 4)
            {
                EnCours = false;
                Gagne = true;
            }

            if (EnCours)
                buttonDebut.Text = "-";
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                if (Gagne)
                    buttonDebut.Text = ":)";
                else if (!Gagne)
                    buttonDebut.Text = ":(";
            }

        }


        private void buttonDebut_Click(object sender, EventArgs e)
        {
            Bombe = rand.Next(1, 5);

            Console.WriteLine(Bombe);

            EnCours = true;
            Boutons = 0;

            button1.Text = "_";
            button2.Text = "_";
            button3.Text = "_";
            button4.Text = "_";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            Statut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Bombe != 1)
                button1.Text = "O";
            else
            {
                button1.Text = "X";
                EnCours = false;
                Gagne = false;
            }
            Boutons++;
            button1.Enabled = false;
            Statut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Bombe != 2)
                button2.Text = "O";
            else
            {
                button2.Text = "X";
                EnCours = false;
                Gagne = false;
            }
            Boutons++;
            button2.Enabled = false;
            Statut();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Bombe != 3)
                button3.Text = "O";
            else
            {
                button3.Text = "X";
                EnCours = false;
                Gagne = false;
            }
            Boutons++;
            button3.Enabled = false;
            Statut();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Bombe != 4)
                button4.Text = "O";
            else
            {
                button4.Text = "X";
                EnCours = false;
                Gagne = false;
            }
            Boutons++;
            button4.Enabled = false;
            Statut();
        }


    }
}
