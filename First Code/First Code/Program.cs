using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int x = 0; hele tal
            float y = 0.4; decimal tal
            string text = "Rikke"; tekst stykke ikke tal forest
            bool isTrue = true; holde på en værdi, der kan gøres brug af. 


            string text = "Rikke";
            modtager bruger input
            text = Console.ReadLine();
            udskriver til konsollen
            Console.WriteLine("Hejsa " + text);
            Gør så programmet venter på at brugeren trykker en tast, før det afsluttes
            Console.ReadKey();

            int d = 0;

            d = int.Parse(Console.ReadLine());
            Console.WriteLine(d * 0.15);

            Array tal = Array();
            Console.WriteLine(Math.Min(tal[1, 3, 1]));

            Math.Min(1, 2);*/

            int max1 = 0;
            int max = 0;
            int tal1 = 0;
            int tal2 = 0;
            int tal3 = 0;
            tal1 = int.Parse(Console.ReadLine());
            tal2 = int.Parse(Console.ReadLine());
            tal3 = int.Parse(Console.ReadLine());

            max = (Math.Max(tal1, tal2));
            max1 = (Math.Max(max, tal3));

            Console.WriteLine("Jeg er " + max1 + " gange stærkere end dig");

             

        } 
    }
}
