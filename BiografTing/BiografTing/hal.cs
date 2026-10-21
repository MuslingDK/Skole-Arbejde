using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Hal : Film
    {
        public List<Sæde> sæder { get; set; } = new List<Sæde>();
        public int antalSæder { get; set; }
        
        public Hal(int antalSæder, string navn) : base(navn)
        {
            this.antalSæder = antalSæder;
            this.navn = navn;
            for (int i = 0; i < antalSæder; i++)
            {
                sæder.Add(new Sæde(true, i + 1, navn));
            }
        }

        //Metode til at printe alle sæder i en hal
        public void PrintSæder()
        {
            for (int i = 0; i < sæder.Count; i++)
            {
                if (sæder[i].erSædeLedig == true)
                {
                    Console.WriteLine("Sæde " + sæder[i].seatNumber + ": Ledig");
                }
                else
                {
                    Console.WriteLine("Sæde " + sæder[i].seatNumber + ": Optaget");
                }
            }
        }

        //Metode til at tælle antallet af ledige sæder i en hal
        public int AntalLedigeSæder()
        {
            int antalLedigeSæder = 0;
            for (int i = 0; i < sæder.Count; i++)
            {
                if (sæder[i].erSædeLedig == true)
                {
                    antalLedigeSæder++;
                }
            }
            return antalLedigeSæder;
        }
    }
}
