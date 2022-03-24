using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public struct SortData
    {
        /// <summary>
        /// Moyenne pour le tri par insertion
        /// </summary>
        public long InsertionMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri par insertion
        /// </summary>
        public long InsertionStd { get; set; }
        /// <summary>
        /// Moyenne pour le tri rapide
        /// </summary>
        public long QuickMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri rapide
        /// </summary>
        public long QuickStd { get; set; }

        public void Display()
        {
            Console.WriteLine("Je suis une méthode thomas");
        }
    }

    public static class SortingPerformance
    {
        public static void DisplayPerformances(List<int> sizes, int count)
        {
            //TODO
        }

        public static List<SortData> PerformancesTest(List<int> sizes, int count)
        {
            //TODO
            return new List<SortData>();
        }

        public static SortData PerformanceTest(int size, int count)
        {
            long moyenne1 = 0;
            long moyenne2 = 0;

            List<int[]> tablist = ArraysGenerator(size);

            for (int i = 1; i <= count; i++)
            {
                moyenne1 = moyenne1 + UseInsertionSort(tablist[0]);
                moyenne2 = moyenne2 + UseQuickSort(tablist[1]);
            }

            moyenne1 = moyenne1 / count;
            moyenne2 = moyenne2 / count;

            SortData resultat = new SortData();
            resultat.InsertionMean = moyenne1;
            resultat.QuickMean = moyenne2;

            resultat.Display();
            //methode

            return resultat;
        }

        private static List<int[]> ArraysGenerator(int size)
        {

            Random aleatoire = new Random();

            int entier = aleatoire.Next();
            //Génère un entier aléatoire positif

            int entier_table = aleatoire.Next(-1000, 1001);
            //Génère un entier compris entre 0 et 1000

            new List<int[]>()
                int[];

            return new List<int[]> { Array,arr};
        }

        public static long UseInsertionSort(int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort(array);
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        public static long UseQuickSort(int[] array)
        {
            int right;
            int left;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(array, left, right);
            // QuickSort(array, 0, Length - 1);
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            };
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            int tmp = array[i];
            array[i] = array[right];
            array[right] = tmp;
            return i;
        }
    }
}
