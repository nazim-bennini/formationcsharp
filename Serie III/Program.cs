using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("exercice 1 serie II");
            Console.WriteLine("-------------------");

            string path = Directory.GetCurrentDirectory();
            string input = path + @"\class.txt";
            string output = path + @"\result.txt";

            ClassCouncil.SchoolMeans(input, output);

            
            
            
            
            // Keep the console window open

            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
