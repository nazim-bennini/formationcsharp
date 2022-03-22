using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class ElementaryOperations
    {
        public static void BasicOperation(int a, int b, char operation)
        {
            int computation;

            switch (operation)
            {
                case '+':  // if (operation == '+')   remarque attention simple quote ' 'pour un caracter et double quotes " " pour chqine de caractere.
                    computation = a + b;
                    Console.WriteLine($" resultat {a} {operation} {b} = {computation}");
                    break;


                case '-':  // if (operation == '-')
                    computation = a - b;
                    Console.WriteLine($" resultat {a} {operation} {b} = {computation}");
                    break;


                case '*':  // if (operation == '*')
                    computation = a * b;
                    Console.WriteLine($" resultat {a} {operation} {b} = {computation}");
                    break;


                case '/':  // if (operation == '/')
                    if (b != 0)
                    {
                        computation = a / b;
                        Console.WriteLine($" resultat de la division entiere {a} {operation} {b} = {computation}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($" result {a} {operation} {b} impossible ");
                    }
                    break;


                default:

                    Console.WriteLine($" l'argument {operation} ne correspond pas a une operation elementaire ");
                    break;

            }

        }

        public static void IntegerDivision(int a, int b)
        {
            int result_division;
            int reste;


            if (b != 0)
            {
                result_division = a / b;
                reste = result_division * b - a;  // j'aurais pu faire avec modulo %
                Console.WriteLine($" resultat de la division entiere {a} = {b} * {result_division} + {reste} ");
                break;
            }
            else
            {
                Console.WriteLine($" result {a} {operation} {b} impossible ");
            }
            
            
        }

        public static void Pow(int a, int b)
        {
            double puissance;
            if (b > 0)
            {
                puissance = a^b;
                Console.WriteLine($" {a} ^ {b} = {puissance} ");
            }
            else 
            {
                Console.WriteLine($" Operation {a} ^ {b} est invalide ");
                    }
    }
}
}


