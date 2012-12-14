using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int tot = 0;

            Console.WriteLine("Combien de nombres?");
            int n = Int32.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.Write("Moyenne : ");
                Console.WriteLine("0");
                Console.ReadLine();
            }
            else
            {

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nombre ");
                    Console.Write(i + 1);
                    Console.WriteLine(" :");
                    int a = Int32.Parse(Console.ReadLine());

                    if (a < 0)
                        a = 0;
                        
                    tot = tot + a;
                }
                Console.Write("Moyenne : ");
                Console.WriteLine(tot / n);
                Console.ReadLine();
            }
        }
    }
}
