using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloworldBN
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstname = Console.ReadLine();
            //Console.WriteLine("Hello world ! test OK " + firstname + "!");
            Console.WriteLine($"Hello {firstname} !");
            //maniere alternative d'ecrire l'instruction d'avant et donc de faire un concatenation.

            // Fin du programme
            Console.ReadLine();
            //Bon de laisser cette instruction pour que la fenetre console ne se ferme pas et donc verifier mon affichage console

            #region MyRegion

            int r = new Random().Next(1, 100);
            bool isFound = false;
            int tries = 0;

            while (!isFound)
            {
                Console.WriteLine("saisissez un nombre");
                String input = Console.ReadLine();
                int i = int.Parse(input);

                tries++;
                if (i < r)
                {
                    Console.WriteLine("Plus grand !");
                }
                else if (i > r)
                {
                    Console.WriteLine("Plus petit !");
                }
            
                
                
                
                
                
                
                
                
                
                
                
                
                
                else
                {
                    isFound = true;
                    Console.WriteLine($"GG ! Vous avez eu besoin de {tries} essais");
                }
            }

            #endregion MyRegion
            Console.ReadLine();


        }





    }
}
