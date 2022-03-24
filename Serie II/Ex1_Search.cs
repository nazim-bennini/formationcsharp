using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Search
    {
        public static int LinearSearch(int[] tableau, int valeur)
        {
            int N=7;
            int i=0;
            int state = -1;
            float temp = tableau[0];
            float nouvelle;

            do
            {    
                Console.WriteLine("i =", i);
                    if (tableau[i] == valeur)
                    {
                    state = i;
                    }
                i++;

            } while (tableau[i] != valeur && i <= N );

            return state;
        }

        public static int BinarySearch(int[] tableau, int valeur)
        {
            //int[][] t = new int[2][];
            //t[0].Length

            int debut;
            int fin;
            int milieu=0;
            bool found = false;
            int size_t = tableau.Length;
          

       
            if (size_t != 0)
            {
                debut = 0;
                fin   = size_t-1;

                while (found == false && debut<=fin)
                {
                    milieu = (debut + fin) / 2;
                        if (tableau[milieu] == valeur)
                        {
                            found = true;
                        }
                        else
                        {
                            if (valeur > tableau[milieu])
                            {
                                debut = milieu + 1;
                            }
                            else
                            {
                                fin = milieu - 1;
                            }

                        }
                        //Console.WriteLine("i =", i);
                        //if (tableau[i] == valeur)
                        //{
                        //   state = i;
                        //}
                    
                }

                // afficher les resultat

                if (found == true)
                {
                    Console.WriteLine($" la valeur recherchée  { valeur}  est au rang  {milieu} ");
                }
                else
                {
                    Console.WriteLine($" la valeur recherchée  {valeur}  est absente du tableau " );
                }
            }
            else
            {
                Console.WriteLine(" Ce tableau semble avoir une table nulle ");
            }

            return (valeur);

        }
    }
}
/*           do
                       {   
                           Console.WriteLine("i =", i);
                           if (tableau[i] == valeur)
                           {
                               state = i;
                           }
                           else 
                           {
                               if (tableau[i] < valeur)
                               {
                                   i++;
                                   nouvelle = tableau[i];
                               }
                               if (tableau[i] > valeur)
                               {
                                   i--;
                                   nouvelle = tableau[i];
                               }

                           }
            


                       } while (tableau[i] != valeur && i <= N);
            */
