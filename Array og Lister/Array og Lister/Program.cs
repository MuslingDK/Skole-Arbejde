using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_og_Lister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*/ Opgave 1
            int i = 0;

            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();


            // Opgave 2
            List <int> tal = new List<int>();

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    tal.Add(i);
                }
                
            }*/
            // Opgave 3
            string[] arr = {"Jeg", "er", "i", "skole", "og", "har", "faget"};

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == "skole")
                {
                    Console.WriteLine(arr[j]);
                    break;
                }
            }
            
            /*/ Bonus opgave
            List<double> KommaTal = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                KommaTal.Add(double.Parse(Console.ReadLine()));
            }
            double resultat = KommaTal.Sum() / KommaTal.Count;

            Console.WriteLine("Resultat: " + resultat);
            Console.ReadLine();*/
        }
    }
    
}
