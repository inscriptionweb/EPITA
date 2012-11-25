using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculatrice
{
    class Fonctions
    {
        /*3.1 : Approx*/
        public float approx(float a, int b)
        {
            if (b == 0)
                return 0;
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
        //j'utilise la formule...
        public float my_sqrt(float a)
        {
            float Xn = 0;

            for (int i = 0; i * i < a; i++)
                Xn = i;
            for (int j = 1; j < 3; j++)
                Xn = (Xn + a / Xn) / 2;

            return Xn;
        }




        /*3.3 : Pow*/


        public float my_pow(float a, int b)
        {
            /* 2 manières de faire la fonction pow ici. 
             * La première récursive (selon moi elle l'est)
             * La seconde avec une boucle (récursive aussi selon moi)
             */

            float c = a;
            return pow_aux(a, b, c);
            /*
            float c = a;
            for (int i = 1; i < b; i++)
                a = a * c;
            return a;*/
        }
        public float pow_aux(float a, int b, float c)
        {
            int i = 1;

            if (b == 0)
                c = 1;
            else
            {

                if (i < b)
                    c *= a;
                if (i == b)
                    return (pow_aux(a, b - 1, c));
            }
            return c;
        }


        //Pow2 est définie pour la partie calculatrice, car même si my_pow marche dans les calculs, pour les virgules, je l'utilise, et elle marche pas.
        public float my_pow2(float a, int b)
        {
            float c = a;

            if (b == 0)
                c = 1;
            else
            {
                for (int i = 1; i < b; i++)
                    c *= a;
            }
            return c;
        }



        /*3.4 : SexyPrime*/
        //www.haypocalc.com/wiki/Algorithmes_pour_nombres_premiers
        // J'aurais pu faire une fonction est_premier, est la faire pour a et b, mais j'avais fait ça, et j'ai pas eu l'envie de modifier... Ne me tuez pas!!
        // Je fais donc deux fonctions auxiliaires pour définir si ils sont premiers, ensuite j'applique l'opération
        public bool a_premier(int a)
        {
            if (a < 2)
                return false;
            else if (a == 2)
                return true;
            else if ((a % 2) == 0)
                return false;
            for (int i = 3; i * i <= a; i += 2)
            {
                if ((a % i) == 0)
                    return false;
            }

            return true;

        }
        public bool b_premier(int b)
        {
            if (b < 2)
                return false;
            else if (b == 2)
                return true;
            else if ((b % 2) == 0)
                return false;
            for (int i = 3; i * i <= b; i += 2)
            {
                if ((b % i) == 0)
                    return false;
            }
            return true;

        }

        public bool is_sexy(int a, int b)
        {
            if (a >= 1000 || b >= 1000)
                return false;
            if (a_premier(a) && b_premier(b))
                if (a - b != 6)
                    return false;
                else return true;
            else return false;
        }




        /*3.5 : Factorielle*/
        public int facto(int a)
        {
            int x = a;
            for (int i = 0; i < x; i++)
            {
                x = x - 1;
                a = x * a;
            }

            return a;
        }




        /*3.6 : Degrés et Radians*/
        public float deg_to_rad(float a)
        {
            float pi = 3.14159265F;
            a = pi * a / 180;

            return a;
        }

        public float rad_to_deg(float a)
        {
            float pi = 3.14159265F;
            a = 180 * a / pi;
            return a;
        }




        /*3.7 : Trigo*/
        public float my_cos(float a)
        {


            return a;
        }


        public float my_sin(float a)
        {


            return a;
        }


        public float my_tan(float a)
        {


            return a;
        }
    }
}
