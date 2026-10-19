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
            Kunde Cust = new Kunde("Børge", new List<Sæde>());
            Hal Hal1 = new Hal(5, "Kung Fu Kasper");
            Hal Hal2 = new Hal(5, "Munkeren Munk");
            Hal Hal3 = new Hal(5, "Emil Stabil");

            List<Hal> Haller = new List<Hal>() { Hal1, Hal2, Hal3 };
            int valgtHal;

            double Interval = 0.1; //In Seconds

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

            Typewriter("Velkommen til Pillers Biograf.");
            Console.WriteLine("");
            Typewriter("Du kan vælge imellem.");
            Console.WriteLine("");
            Typewriter("1. Kung Fu Kasper");
            Typewriter("2. Munkeren Munk");
            Typewriter("3. Emil Stabil");
            Typewriter("Tryk 1, 2, eller 3 for at vælge.");

            bool harValgtFilm = false;
            while (harValgtFilm == false)
            {
                ConsoleKeyInfo Keyinfo = Console.ReadKey();
                string input = Keyinfo.KeyChar.ToString();
                Console.WriteLine("");
                valgtHal = int.TryParse(input, out int parsedValgtHal) ? parsedValgtHal - 1 : -1;


                if (input == "1")
                {
                    Typewriter("Du har valgt " + Hal1.name);
                    harValgtFilm = true;
                    Reservation(1);
                }
                else if (input == "2")
                {
                    Typewriter("Du har valgt " + Hal2.name);
                    harValgtFilm = true;
                    Reservation(2);
                }
                else if (input == "3")
                {
                    Typewriter("Du har valgt " + Hal3.name);
                    harValgtFilm = true;
                    Reservation(3);
                }
                else
                {
                    Typewriter("Ugyldigt valg. Prøv igen.");
                }

            }

            for (int i = 0; i < Cust.reservationer.Count; i++)
            {
                Cust.reservationer[i].printSæde();
            }

            void Reservation(int halNumber)
            {
                Typewriter("Her er sæderne:");
                Haller[valgtHal].PrintSæder();
                Console.WriteLine("");

                Typewriter("Hvor mange sæder vil du reservere?");
                ConsoleKeyInfo KeyinfoAntalSæder = Console.ReadKey();
                string antalSæderInput = KeyinfoAntalSæder.KeyChar.ToString();
                Console.WriteLine("");
                if (int.TryParse(antalSæderInput, out int antalSæder) && antalSæder > 0 && antalSæder <= Haller[valgtHal].antalSæder)
                {
                    Typewriter("Du har valgt at reservere " + antalSæder + " sæder.");
                }
                else
                {
                    Typewriter("Ugyldigt antal sæder. Prøv igen.");
                    Reservation(halNumber);
                    return;
                }

                Typewriter("Skriv nummeret på det/de sæder du vil reservere.");

                for (int i = 0; i < antalSæder; i++)
                {
                    ConsoleKeyInfo KeyinfoValgtSæde = Console.ReadKey();
                    string valgtSædeInput = KeyinfoValgtSæde.KeyChar.ToString();
                    Console.WriteLine("");
                    if (int.TryParse(valgtSædeInput, out int valgtSæde) && valgtSæde >= 1 && valgtSæde <= Haller[valgtHal].antalSæder)
                    {

                    }
                    else
                    {
                        Typewriter("Ugyldigt sædenummer. Prøv igen.");
                        i--;
                        continue;
                    }

                

                    if (Haller[valgtHal].sæder[valgtSæde-1].isSeatAvailable == true)
                    {
                        Typewriter("Du har reserveret sæde " + Haller[valgtHal].sæder[valgtSæde-1].seatNumber + " til " + Haller[valgtHal].name);
                        Haller[valgtHal].sæder[valgtSæde-1].isSeatAvailable = false;
                        Cust.reservationer.Add(Haller[valgtHal].sæder[valgtSæde-1]);
                    }
                    else
                    {
                        Typewriter("Sædet er allerede optaget. Prøv igen.");
                        i--;
                    }
                }
            }
        }
    }
}

