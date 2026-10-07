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



            Kunde Cust = new Kunde("Børge");
            Hal Hal1 = new Hal(5, "Kung Fu Kasper");
            Hal Hal2 = new Hal(5, "Munkeren Munk");
            Hal Hal3 = new Hal(5, "Emil Stabil");

            List<Hal> Haller = new List<Hal>() { Hal1, Hal2, Hal3 };
            int valgtHal = 0;

            double Interval = 0.4; //In Seconds

            void Typewriter(string s) //Typewriter effect for console output
            {
                List<char> tp = s.ToList();
                for (int i = 0; i < tp.Count; i++)
                {
                    Console.Write(tp[i]);
                    Thread.Sleep((int)Math.Round(100 * Interval));
                }
                Console.WriteLine("");
            }

            Typewriter("Velkommen til Pillers Bio!");
            Typewriter("Vi har følgende film i dag:");

            Console.WriteLine("");

            Typewriter("1. " + Hal1.name);
            Typewriter("2. " + Hal2.name);
            Typewriter("3. " + Hal3.name);

            Typewriter("Tryk 1, 2 eller 3 for at vælge en film.");


            while (true)
            {
                
                ConsoleKeyInfo Keyinfo = Console.ReadKey();
                string input = Keyinfo.KeyChar.ToString();
                Console.WriteLine("");
                valgtHal = int.Parse(input) - 1;


                if (input == "1")
                {
                    Typewriter("Du har valgt " + Hal1.name);
                    break;
                }
                else if (input == "2")
                {
                    Typewriter("Du har valgt " + Hal2.name);
                    break;
                }
                else if (input == "3")
                {
                    Typewriter("Du har valgt " + Hal3.name);
                    break;
                }
                else
                {
                    Typewriter("Ugyldigt valg. Prøv igen.");
                }

            }

            Reservation();

            void Reservation()
            {
                Typewriter("Her er de sæderne:");
                Haller[valgtHal].PrintSæder();
                Console.WriteLine("");
                Typewriter("Skriv nummeret på det sæde du vil reservere.");

                if (Haller[valgtHal].sæder[int.Parse(Console.ReadLine()) - 1].isSeatAvailable)
                {
                    Haller[valgtHal].sæder[int.Parse(Console.ReadLine()) - 1].isSeatAvailable = false;
                    Typewriter("Du har reserveret sæde " + (int.Parse(Console.ReadLine()) - 1) + " i " + Haller[valgtHal].name);
                    
                }
                else
                {
                    Typewriter("Sædet er allerede optaget. Prøv igen.");
                    Reservation();
                }
            }
        }
    }
}


