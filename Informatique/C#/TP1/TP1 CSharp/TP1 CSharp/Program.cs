using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_sexy(11, 17));
            Console.WriteLine(my_pow(2, 4));
            Console.ReadLine();
        }
        /*3.1 : Approx*/
        public static float approx(float a, int b)
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
        public static float my_sqrt(float a)
        {


            return a;
        }




        /*3.3 : Pow*/
        public static float my_pow(float a, int b)
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
        public static float pow_aux(float a, int b, float c)
        {
            int i = 1;
            if (i < b)
                a = a * c;
            if (i == b)
            return (a);
            return (pow_aux(a, b - 1, c));
        }




        /*3.4 : SexyPrime*/
        /*www.haypocalc.com/wiki/Algorithmes_pour_nombres_premiers*/
        public static bool a_premier(int a)
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
        public static bool b_premier(int b)
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

        public static bool is_sexy(int a, int b)
        {
            if (a_premier(a) && b_premier(b))
                if (a - b != 6)
                    return false;
                else return true;


            /*if (a < 2 || b < 2)
                return false;
            else if (a == 2 && b == 2)
                return true;
            else if ((a % 2) == 0 || (b % 2) == 0)
                return false;
            else if (a < 2)
            {
                for (int i = 3; i * i <= a; i += 2)
                {
                    if ((a % i) == 0)
                        return false;

                }
            }
            if (b < 2)
                for (int i = 3; i * i <= b; i += 2)
                {
                    if ((b % i) == 0)
                        return false;

                }*/
        }




        /*3.5 : Factorielle*/
        public static int facto(int a)
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
        public static float deg_to_rad(float a)
        {


            return a;
        }

        public static float rad_to_deg(float a)
        {


            return a;
        }




        /*3.7 : Trigo*/
        public static float my_cos(float a)
        {


            return a;
        }


        public static float my_sin(float a)
        {


            return a;
        }


        public static float my_tan(float a)
        {


            return a;
        }
    }
}
