using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Pyramid
    {
        public static void PyramidConstruction(int n, bool isSmooth)
        {
            int ispace;
            int iplus;
            int i;
            int j;
            int k;
            int nb_blocs_par_ligne;
            //nb_blocs_par_ligne = 2 * k - 1;
            //ispace = n - k;
            //iplus = k;
            // ligne intermediaire
            int number_of_layers = n;
            // nombre de couches de la pyramide





            for (k = 1; k <= n; k++)
            {
                for (i = 1; i <= n - k; i++)

                {
                    Console.Write(" ");
                }

    
                for (j = 1; j <= k; j++)
                {
                    if ((k % 2 == 0) && (isSmooth == true))
                    {
                        if (isSmooth)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("+");
                        }
                    
                    }
                    else
                    {
                        Console.Write("+");
                    }
                }

                ////
                for (i = n + k; i <= n; i++)

                {
                    Console.Write(" ");
                }


                for (j = 1; j <= k; j++)
                {
                    if ((k % 2 == 0) && (isSmooth == true))
                    {
                        if (isSmooth)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("+");
                        }

                    }
                    else
                    {
                        Console.Write("+");
                    }
                }
                ////






                //   for k = 1; k <= (2 * n - 1), k++;
                //int[] gauche = new int[100];
                //int gauche
                //nb_blocs(n) = 1 + 2 * (n - 1)
                Console.WriteLine();
            }

            Console.WriteLine(" pyramide ci-dessus");

        }
    }
}
