using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Kunde Cust = new Kunde();
            Hal Hal1 = new Hal(5, "Kung Fu Kasper");
            Hal Hal2 = new Hal(5, "Munkeren Munk");
            Hal Hal3 = new Hal(5, "Emil Stabil");

            double Interval = 0.5; //In Seconds

            void typewriter(string s) //Typewriter effect for console output
            {
                List<char> tp = s.ToList();
                for (int i = 0; i < tp.Count; i++)
                {
                    Console.Write(tp[i]);
                    Thread.Sleep((int)Math.Round(100 * Interval));
                }
                Console.ReadKey();
                Console.WriteLine("");
            }

            typewriter("Hej Daniella");


           

        
        }

    }
}


