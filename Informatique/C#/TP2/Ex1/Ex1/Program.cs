using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =Int32.Parse(args[0]);

            for (int i = 1; i < args.Length; i += 2)
            {
                if (args[i] == "*")
                {
                    n *= Int32.Parse(args[i+1]);
                }
                if (args[i] == "/")
                {
                    n /= Int32.Parse(args[i + 1]);
                }
                if (args[i] == "+")
                {
                    n += Int32.Parse(args[i+1]);
                }
                if (args[i] == "-")
                {
                    n -= Int32.Parse(args[i+1]);
                }
            }

            Console.WriteLine(n);
            Console.ReadLine();


        }
    }
}
