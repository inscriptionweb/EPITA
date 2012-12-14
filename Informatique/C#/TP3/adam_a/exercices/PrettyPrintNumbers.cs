using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyPrintNumbers
{
    class Program
    {
        static string Pretty(int a, int b, int c)
        {

            for (int i = a; i < b; i = i + c)
            {
                Console.Write(i);
                if (i + c !=  b)
                    Console.Write(", ");
                if (i + c == b)
                    Console.Write(" et ");
            }
            return Convert.ToString(b);

        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Entrez le premier nombre");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le dernier nombre");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le pas");
            c = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Pretty(a, b, c));
            Console.ReadLine();
        }

    }
}
