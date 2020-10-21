/**
 * mention de la moyenne 
 * tristan haquenoph 
 * 09/10/2020
 */
using System;


namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration 
            float moyenne;

            //saisie de la moyenne
            Console.Write("Entrez votre moyenne = ");
            moyenne = float.Parse(Console.ReadLine());

            //boucle test moyenne affichege mention
            if(moyenne < 10)
            {
                Console.Write("Recallé");

            }
            else
            {
                if(moyenne < 12)
                {
                    Console.WriteLine("Passable");
                }
                else
                {
                    if(moyenne < 14)
                    {
                        Console.WriteLine("Assez bien");
                    }
                    else
                    {
                        if (moyenne < 16)
                        {
                            Console.WriteLine("Bien");
                        }
                        else
                        {
                            Console.WriteLine("Tres bien");
                        }
                    }
                        
                }
            }

            Console.ReadLine();
            
        }
    }
}
