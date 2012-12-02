using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    class Program
    {

        // J'ai été jusqu'à la partie 3 et 4, sans gérer la temps, mais les couleurs.

        static void Main(string[] args)
        {
            Sapin(9);
        }

        
        static void Sapin(int n)
        {
            //le fond en couleur
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();


            int x;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                //affichage des espaces, du feuillage, et des boules
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int j = 0; j < n-1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i*2 + 1; j++)
                {

                    x = rnd.Next(1, 10);

                    if (x == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("O");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("*");
                    }
                }


                Console.WriteLine("");
                //affichage des espaces, et des troncs
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("#");
                Console.WriteLine("");

            }



            Console.ReadLine();

        }
    }
}
