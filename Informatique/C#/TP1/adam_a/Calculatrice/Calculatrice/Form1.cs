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

        float number;
        float number_int;
        float number_float;
        float memory_nb;
        float result;
        bool virgule;
        String operateur;

        public Form1()
        {
            InitializeComponent();
            comboBox.Text = "5";
            fonction = new Fonctions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        // FONCTIONS BASIQUES //


        // Ce sont les fonctions basiques +-*/%

        public void add(float a)
        {
            result = a + memory_nb;
        }

        public void sub(float a)
        {
            result = memory_nb - a;
        }

        public void mul(float a)
        {
            result = a * memory_nb;
        }

        public void div(float a)
        {
            result = memory_nb / a;
        }

        public void mod(float a)
        {
            result = memory_nb % a;
        }

        public void exp(float a)
        {
            result = fonction.my_pow2(2.71f, (int)a);
        }



        // FONCTIONS DE GESTION //


        // Ces fonctions permettent de situer l'action, et de gérer la calculatrice avec les fonctions


        // Statut permet de mettre à jour le statut de la calculatrice
        public void Statut()
        {
            number = number_int + number_float / fonction.my_pow2(10, number_float.ToString().Length);
            Box_stock.Text = number.ToString();

            Box_operateur.Text = operateur;
        }


        // Stock permet de stocker un nombre dans la boxstock pour l'utiliser dans les fonctions

        public void Stock(float nombre)
        {

            if (!virgule)
                number_int = Convert.ToSingle(number_int.ToString() + nombre.ToString());
            else
                number_float = Convert.ToSingle(number_float.ToString() + nombre.ToString());

            Statut();
        }


        // Operateur permet d'afficher un opétateur à l'écran

        public void Operateur(String op)
        {
            memory_nb = number;
            number_int = 0;
            number_float = 0;
            operateur = op;
            virgule = false;

            Statut();
        }


        // Dans Action se trouvent tout le reste des actions, effectuation des opérations, gestion de la virgule, nombres décimaux, ANS, CLEAR, DELETE... Mais également EXE

        public void Action(String action)
        {

            if (action == ",")
                virgule = true;
            else if (action == "ANS")
            {
                number_int = (int)result;
                number_float = result - number_int;
                number_float = number_float * fonction.my_pow2(10, (number_float.ToString().Length - 2));
            }
            else if (action == "CLEAR")
            {
                number = 0;
                number_int = 0;
                number_float = 0;
                memory_nb = 0;
                virgule = false;
                operateur = "";
                result = 0;
                Box_resultat.Text = "";
            }
            else if (action == "DEL")
            {
                if (number.ToString().Length - 1 > 0)
                    number = Convert.ToSingle(number.ToString().Remove(number.ToString().Length - 1));
                else number = 0;

                number_int = (int)number;
                number_float = number - number_int;
                number_float = number_float * fonction.my_pow2(10, (number_float.ToString().Length - 2));
            }
            else if (action == "EXE")
            {
                Console.WriteLine("op : " + operateur + " nb : " + number);

                if (operateur == "")
                    result = number;
                else if (operateur == "+")
                    add(number);
                else if (operateur == "-")
                    sub(number);
                else if (operateur == "*")
                    mul(number);
                else if (operateur == "/")
                    div(number);
                else if (operateur == "%")
                    mod(number);
                else if (operateur == "√")
                    result = fonction.my_sqrt(number);
                else if (operateur == "^")
                    result = fonction.my_pow2(memory_nb, (int)number);
               // else if (operateur == "sexy")
                  //result = fonction.is_sexy((int)memory_nb, (int)number);
                else if (operateur == "!")
                    result = fonction.facto((int)memory_nb);
                else if (operateur == "cos")
                    result = fonction.my_cos(number);
                else if (operateur == "sin")
                    result = fonction.my_sin(number);
                else if (operateur == "cos")
                    result = fonction.my_tan(number);
                else if (operateur == "exp")
                    exp(number);
                else if (operateur == "R to D")
                    result = fonction.rad_to_deg(number);
                else if (operateur == "D to R")
                    result = fonction.deg_to_rad(number);

                number_int = 0;
                number_float = 0;
                operateur = "";

                Box_resultat.Text = fonction.approx(result, Convert.ToInt32(comboBox.Text)).ToString();

                Console.WriteLine(Convert.ToInt32(comboBox.Text));
            }

            Statut();
        }


        // BOUTONS NUMERIQUES //


        //Les Boutons numériques affichent des nombres dans la boxstock

        private void button0_Click(object sender, EventArgs e)
        {
            Stock(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stock(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stock(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stock(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stock(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Stock(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Stock(9);
        }




        // BOUTONS OPERATEURS //


        // Ils affichent l'opérateur dans la boxopérateur

        private void button_plus_Click(object sender, EventArgs e)
        {
            Operateur("+");
        }

        private void button_moins_Click(object sender, EventArgs e)
        {
            Operateur("-");
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            Operateur("*");
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            Operateur("/");
        }
        private void button_mod_Click(object sender, EventArgs e)
        {
            Operateur("%");

        }
        private void button_pi_Click(object sender, EventArgs e)
        {
            Stock(3.14159265F);
        }




        // BOUTONS FONCTIONS //


        // Ils affichent les signes et autres fonctions dans la boxopérateur

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            Operateur("√");
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            Operateur("^");
        }
        private void button_sexy_Click(object sender, EventArgs e)
        {
            Operateur("sexy");
        }
        private void button_facto_Click(object sender, EventArgs e)
        {
            Operateur("!");
        }

        private void buttonDegToRad_Click(object sender, EventArgs e)
        {

            Operateur("D to R");
        }

        private void buttonRadToDeg_Click(object sender, EventArgs e)
        {
            Operateur("R to D");
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            Operateur("cos");
        }

        private void button_tan_Click(object sender, EventArgs e)
        {
            Operateur("tan");
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            Operateur("sin");
        }




        // BOUTONS ACTIONS //


        // Ils permettent de définir une action sur la calculette pour le gérer dans Action
        private void button_EXE_Click(object sender, EventArgs e)
        {
            Action("EXE");

        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            Action("DEL");
        }

        private void buttonAc_Click(object sender, EventArgs e)
        {
            Action("AC");
        }
        private void button_virgule_Click(object sender, EventArgs e)
        {
            Action(",");
        }

        private void button_DEL_Click(object sender, EventArgs e)
        {
            Action("DEL");
        }

        private void button_CLEAR_Click(object sender, EventArgs e)
        {
            Action("CLEAR");
        }

        private void button_ANS_Click(object sender, EventArgs e)
        {
            Action("ANS");
        }
    }
}
