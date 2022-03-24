using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Eratosthene
    {
        public static int[] EratosthenesSieve(int n)
        {
                int j;
                int k;
                int[] liste = new int[n];
                for (int a = 0; a < liste.Length; a++)
                {
                    liste[a] = a;
                }

            //int[,] array = new int[n,n];

            //----Supprimer de la liste l'ensemble des multiples----
                for (int i = 2; i < liste.Length; i++)
                {
                    j = 1;
                
                    //----prendre multiples de 2,3,4 ...etc :
                    do
                    {
                        k = i * j;
                            if (k < n)
                            {
                            liste[k] = -1;
                            //array[i,j]=k
                            //liste.Remove(k);
                            //list.RemoveAll( => j == k);
                            }

                        j++;

                    } while (k <= n);
                }

                Console.WriteLine($" resultat {liste}");


                //return new int[0];
           return liste;
        }
    }
}
