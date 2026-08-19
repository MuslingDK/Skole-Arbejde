using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_og_Funktioner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tal = Console.ReadLine();
            double[] talArray = SplitterB(tal);
            double resultat = Gennemsnit(talArray);

            Console.WriteLine(resultat);

            /*string input = Console.ReadLine();
            string[] ord = SplitterA(input);

            foreach (string s in ord)
            {
                Console.WriteLine(s);
            }*/

            /*double SideA = double.Parse(Console.ReadLine());
            double SideB = double.Parse(Console.ReadLine());

            double SideC = Phytagoras(SideA, SideB);
            Console.WriteLine(SideC);*/
            Console.ReadLine();
        }

        private static double Phytagoras(double a, double b)
        {
            double resultat = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return resultat;
        }

        private static string[] SplitterA(string s)
        {
            return s.Split(' ');
        }

        private static double[] SplitterB(string s)
        {
            string[] strings = SplitterA(s);
            double[] numbers = new double[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                numbers[i] = double.Parse(strings[i]);
            }
            return numbers;
        }

        private static double Gennemsnit(double[] tal)
        {
            double sum = 0;
            foreach (double d in tal)
            {
                sum += d;
            }
            return sum / tal.Length;
        }
    }
}
