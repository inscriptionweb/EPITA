using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Division(2, 0));
            Console.ReadLine();

        }

        static int Multiplication(int a, int b)
        {
            int c = a;
            for (int i = 1; i < c; i++)
            {
                a = a + c;
            }
            return a;
        }


        static int Division(int a, int b)
        {
            if (b == 0)
                Console.WriteLine("SIRIOUS LEE? b=0?");
            int i = 0;
            if (a<0)
                a = -a;
            if (b<0)
                b = -b;
            while (a != 0) 
            {
                a = a - b;
                i++;
            }
            return i;
        }



        static int Factorielle(int n)
        {
            int x = n;
            for (int i = 0; i < x; i++)
            {
                x = x - 1;
                n = x * n;
            }

            return n;
        }

        static int Fibonacci(int n)
        {

            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);


        }

        /*
        static int FibonacciIter(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            for (int i = 0; i < c; i++)
            {
                n = n +  
            }
            return 2;
        }
    */
    }
}
