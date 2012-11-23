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
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(my_pow(5, 2));
        }


        /*3.1 : Approx*/
        float approx(float a, int b)
        {
            int mult = 10; /* Je définis un multiplicateur = 10*/
            int x; /* J'instancie un entier qui va me permettre de prendre a avec le nombre de valeurs décimales voulues, afin de supprimer celles après*/
            for (int i = 1; i < b; i++) /* Je fais une boucle*/
                    mult = mult * 10;

            a = mult * a;
            x = (int)a;
            a = (float)x;
            a = a / mult;
            return a;
        }



        /*3.2 : Sqrt*/
        float my_sqrt(float a)
        {


            return a;
        }




        /*3.3 : Pow*/            
        float my_pow(float a, int b)
        {
            /* 2 manières de faire la fonction pow ici. 
             * La première récursive (selon moi elle l'est)
             * La seconde avec une boucle (récursive aussi selon moi)
             */


            int i = 1;
            float c = a;

            if (i < b)
                a = a * c;

            if (c == b)
            i = i + 1;
            return (a);

            /*
            float c = a;
            for (int i = 1; i < b; i++)
                a = a * c;
            return a;*/
        }




        /*3.4 : SexyPrime*/
        bool is_sexy(int a, int b)
        {

            
            return true;
        }




        /*3.5 : Factorielle*/
        int facto(int a)
        {


            return a;
        }




        /*3.6 : Degrés et Radians*/
        float deg_to_rad(float a)
        {


            return a;
        }

        float rad_to_deg(float a)
        {


            return a;
        }




        /*3.7 : Trigo*/
        float my_cos(float a)
        
        {


            return a;
        }


        float my_sin(float a)
        
        {


            return a;
        }


        float my_tan(float a)
        {


            return a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
