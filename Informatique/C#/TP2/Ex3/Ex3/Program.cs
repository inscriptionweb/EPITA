using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sapin(14);
        }


        static void Sapin(int n)
        {
            string ligne = "";
            string tronc = "";
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n-1 - i; j++)
                {
                    ligne += " ";
                }

                for (int j = 0; j < i*2 + 1; j++)
                {
                    ligne += "*";
                }


                Console.WriteLine(ligne);
                ligne = "";
            }

            for (int i = 0; i < n/2; i++)
            {

                for (int j = 0; j < n-1; j++)
                {
                    tronc += " ";
                }

                    tronc += "#";
                Console.WriteLine(tronc);

                tronc = "";
            }



            Console.ReadLine();
        }
    }
}
