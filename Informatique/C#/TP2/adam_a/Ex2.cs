using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class Program
    {

        //Fonction main pour gérer les entrées
        static void Main(string[] args)
        {
            string entree = Console.ReadLine();
            Console.WriteLine(Rotation(int.Parse(args[0]) , entree));
        }



        //Fonction rotation pour gérer la rotation du string entree. Chaque character est converti en int et subit une rotation grâce à la table ASCII
        static string Rotation(int rotation, string chars)
        {
            string sortie = "";

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ')
                {
                    //Cas de nombre

                    if (chars[i] >= 48 && chars[i] <= 57)
                    {
                        if (chars[i] + rotation > 57)
                            sortie += (char)(((chars[i] + rotation) % 58) + 48);
                        else
                            sortie += (char)(chars[i] + rotation);
                    }
                    


                    //Cas de minuscule

                    else if (chars[i] >= 97 && chars[i] <= 122)
                    {
                        if (chars[i] + rotation > 122)
                            sortie += (char)(((chars[i] + rotation) % 123) + 97);
                        else
                            sortie += (char)(chars[i] + rotation);
                    }



                    //Cas de majuscule

                    else if (chars[i] >= 65 && chars[i] <= 90) 
                    {
                        if (chars[i] + rotation > 90)
                            sortie += (char)(((chars[i] + rotation) % 91) + 65);
                        else
                            sortie += (char)(chars[i] + rotation);
                    }
                    else
                        sortie += (char)(chars[i] + rotation);

                }
                else sortie += chars[i];

            }
            //la sortie est l'entrée qui a subit la rotation
            return sortie;
        }
    }
}
