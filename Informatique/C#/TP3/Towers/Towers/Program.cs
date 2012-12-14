using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Towers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le haut de la tour : ");
            string toit = Console.ReadLine();
            Console.WriteLine("Entrez un étage décoré : ");
            string dec = Console.ReadLine();
            Console.WriteLine("Entrez un étage vide : ");
            string vide = Console.ReadLine();
            Console.WriteLine("Entrez le bas de la tour : ");
            string bas = Console.ReadLine();
            string etage = dec + '\n' + vide;


            Console.WriteLine("Entrez le nombre d'etages que vous souhaitez afficher : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Votre tour : ");

            Console.WriteLine(toit + '\n' + vide);
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(etage);
            }


            Console.WriteLine(bas);
            Console.ReadLine();
            /*
             * 
             *  tentatives de bonus...
            // dessin des etages

            string toit = "._________.";
            string vide = "|         |";
            string dec = "|  0   0  |";
            string bas = "|___/" + '"' + "\\___|";



            List<int> etage = new List<int>();
            etage.Add (5);
            int b = etage[0];

            Console.WriteLine("Entrez le nombre de tours à afficher : ");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Entrez le nombre d'etages de la tour " + i+1 + " : ");

            }
            */
        }
    }
}
