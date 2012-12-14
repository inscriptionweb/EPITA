using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Print_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string mid = "*";
            string ext = "";

            Console.WriteLine("Entrez la largeur");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la hauteur");
            int h = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                ext += "*";
            }

            Console.WriteLine(ext);
            
            for (int i = 0; i < l-2; i++)
			{
                mid += " ";
            }
            mid += "*";

            for (int i = 0; i < h-2; i++)
            {
                Console.WriteLine(mid);
            }

            Console.WriteLine(ext);

            Console.ReadLine();
        }
    }
}
