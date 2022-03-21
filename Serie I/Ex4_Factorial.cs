using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Factorial
    {
        public static int Factorial_(int n)
        {
            int fact;

            fact = n;

            for (int k=n-1; k>1; k--) 
            {
                fact = fact * k;
            }
            Console.WriteLine($" factorielle = {fact}");

            return fact;
        }

        public static int FactorialRecursive(int n)
        {
            if (n ==0 || n==1) 
            {
                return 1;
            }
            else
            {
                return n * FactorialRecursive(n - 1);
            }
        }
    }
}
