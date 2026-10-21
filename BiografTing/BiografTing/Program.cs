using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BiografTing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opretter kunde og haller
            Kunde Kunde1 = new Kunde("Børge", new List<Sæde>());
            Hal Hal1 = new Hal(5, "Kung Fu Kasper");
            Hal Hal2 = new Hal(5, "Munkeren Munk");
            Hal Hal3 = new Hal(5, "The Last Sunil Samurai");

            List<Hal> Haller = new List<Hal>() { Hal1, Hal2, Hal3 };
            int valgtHal;

            double Interval = 0.1; //I sekunder

            //Typewriter funktion, som printer en string med et interval mellem hvert bogstav
            void Typewriter(string s)
            {
                List<char> tp = s.ToList();
                for (int i = 0; i < tp.Count; i++)
                {
                    Console.Write(tp[i]);
                    Thread.Sleep((int)Math.Round(100 * Interval));
                }
                Console.WriteLine("");
            }

            // Viser filmne
            Typewriter("Velkommen til Pillers Biograf.");
            Console.WriteLine("");
            Typewriter("Du kan vælge imellem.");
            Console.WriteLine("");
            Typewriter("1. " + Hal1.navn);
            Typewriter("2. " + Hal2.navn);
            Typewriter("3. " + Hal3.navn);
            Typewriter("Tryk 1, 2, eller 3 for at vælge.");
            Console.WriteLine("");
            VælgFilm();
            PrintReservationer();


            //Vælger film
            void VælgFilm()
            {
                ConsoleKeyInfo KeyinfoValgtFilm = Console.ReadKey();
                string valgtFilmInput = KeyinfoValgtFilm.KeyChar.ToString();
                Console.WriteLine("");
                if (int.TryParse(valgtFilmInput, out int valgtFilm) && valgtFilm >= 1 && valgtFilm <= Haller.Count)
                {
                    valgtHal = valgtFilm - 1;
                    Typewriter("Du har valgt " + Haller[valgtHal].navn);
                    Reservation(valgtHal);
                }
                else
                {
                    Typewriter("Ugyldigt valg. Prøv igen.");
                    VælgFilm();
                }
            }

            //Reservation funktion
            void Reservation(int halNumber)
            {
                //Tjekker om der er ledige sæder
                if (Haller[valgtHal].AntalLedigeSæder() == 0)
                {
                    Typewriter("Ingen ledige sæder tilgængelige.");
                    return;
                }

                //Printer sæderne
                Typewriter("Her er sæderne:");
                Haller[valgtHal].PrintSæder();
                Console.WriteLine("");

                //Spørger hvor mange sæder man vil reservere
                Typewriter("Hvor mange sæder vil du reservere?");
                ConsoleKeyInfo KeyinfoAntalSæder = Console.ReadKey();
                string antalSæderInput = KeyinfoAntalSæder.KeyChar.ToString();
                Console.WriteLine("");
                if (int.TryParse(antalSæderInput, out int antalSæder) && antalSæder > 0 && antalSæder <= Haller[valgtHal].AntalLedigeSæder())
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

                //Løkker for at vælge sæder
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


                    //Tjekker om sædet er ledigt og reserverer det
                    if (Haller[valgtHal].sæder[valgtSæde - 1].erSædeLedig == true)
                    {
                        Typewriter("Du har reserveret sæde " + Haller[valgtHal].sæder[valgtSæde - 1].sædeNummer + " til " + Haller[valgtHal].navn);
                        Haller[valgtHal].sæder[valgtSæde - 1].erSædeLedig = false;
                        Kunde1.reservationer.Add(Haller[valgtHal].sæder[valgtSæde - 1]);
                    }
                    else
                    {
                        Typewriter("Sædet er allerede optaget. Prøv igen.");
                        i--;
                    }
                }
            }

            //Printer reservationer
            void PrintReservationer()
            {
                Typewriter("Dine reservationer:");
                Console.WriteLine("");
                foreach (var sæde in Kunde1.reservationer)
                {
                    Typewriter("Sæde " + sæde.sædeNummer + " i " + Haller[valgtHal].navn);
                }
            }
        }
    }
}

