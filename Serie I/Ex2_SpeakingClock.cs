using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class SpeakingClock
    {
        public static string GoodDay(int heure)
        {
            string message=string.Empty;

            if (heure > 00 && heure < 06)
            {
                message = "Merveilleuse nuit";
                Console.WriteLine($" {message} "); 

            }

            if (heure >= 06 && heure < 12)
            {
                message = "Bonne matinée !";
                Console.WriteLine($" {message} ");
            }

            if (heure == 12)
            {
                message = "Bon appétit !";
                Console.WriteLine($" { message} ");
            }

            if (heure >= 13 && heure < 18)
            {
                message = "Profitez de votre après-midi!";
                Console.WriteLine($" {message} ");
            }

            if (heure > 18)
            {
                message = "Passez une bonne soirée !";
                Console.WriteLine($" {message} ");
            }
            //return string.Empty;
            return $"il est {heure} et {message}" ;

        }
    }
}
