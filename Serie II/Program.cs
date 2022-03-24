using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100;
            int[] X= new int [N];
            int[] array = new int[] { 1, -5, 10, 3, 0, 4, 2, -7 };
            int[] array_order = new int[] { -7, -5, 0, 1, 2, 3, 4, 10 };

            //int[] tableau = new int[100];
            //Random random = new Random();

            //for (int j = 0; j < numbers.length; j++)
            //{
            //    tableau[j] = random.nextInt(100);
            //}

            Search.BinarySearch(array_order, 10);


            X=Eratosthene.EratosthenesSieve(N);



            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
