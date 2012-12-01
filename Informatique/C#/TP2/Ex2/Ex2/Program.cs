using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            string entree = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < entree.Length; i++)
            {
                string mot = Convert.ToString(entree[i]);
                


            }


            /*
            string rotatestr = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < rotatestr.Length; i++)
            {
                string word = Convert.ToString(rotatestr[i]);
                for (int j = 0; j < word.Length; j++)
                {
                    char c = word[j];
                    char minus = ' ';
                    char maj = ' ';
                    bool Rotate = true;
                    if (c >= 'A' && c <= 'Z')
                    {
                        minus = 'A';
                        maj = 'Z';
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        minus = 'a';
                        maj = 'z';
                    }
                    else if (c >= '0' && c <= '9')
                    {

                    }
                    else
                    {
                        Rotate = false;
                    }
                    if (Rotate)
                    {
                        for (int k = 0; k < 13; k++)
                        {
                            char nextchar = Convert.ToChar(Convert.ToInt32(c) + 1);
                            if (nextchar > maj)
                                c = minus;
                        }
                    }
                    rotatestr[i][j] = c;
                }
            }*/
        }
    }
}
