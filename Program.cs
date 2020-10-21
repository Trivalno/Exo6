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
                Console.Write("grosse merdeca pu la merde");

            }
            else
            {
                if(moyenne < 12)
                {
                    Console.WriteLine("ok");
                }
                else
                {
                    if(moyenne < 14)
                    {
                        Console.WriteLine("cool");
                    }
                    else
                    {
                        if (moyenne < 16)
                        {
                            Console.WriteLine("giga bien");
                        }
                        else
                        {
                            Console.WriteLine("enorme");
                        }
                    }
                        
                }
            }

            Console.ReadLine();
            
        }
    }
}
