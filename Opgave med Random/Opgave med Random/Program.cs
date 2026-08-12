using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_med_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            /*Random terning = new Random();
            int resultat = terning.Next(1, 6);
            Console.WriteLine(resultat);

            if (resultat <= 2)
            {
                Console.WriteLine("lav");
            }
            else if (resultat <= 4)
            {
                Console.WriteLine("middel");
            }
            else
            {
                Console.WriteLine("høj");
            }

            if (resultat % 2 == 0) 
            {
                Console.WriteLine("lige");
            }
            else
            {
                Console.WriteLine("ulige");
            }*/


            // Opgave 2
            double tal = double.Parse(Console.ReadLine());

            double helTal = Math.Floor(tal);

            if (tal - helTal <= 0.49)
            {
                Console.WriteLine("Rund ned");
            }
            else
            {
                Console.WriteLine("Rund op");
            }

            Console.WriteLine(tal - helTal);
        }
    }
}
