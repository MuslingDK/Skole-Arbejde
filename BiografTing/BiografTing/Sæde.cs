using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Sæde : Film
    {
        public bool erSædeLedig { get; set; } = true;
        public int sædeNummer { get; set; }
        public string filmNavn { get; set; }

        public Sæde(bool erSædeLedig, int sædeNummer,string navn) : base(navn)
        {
            this.erSædeLedig = erSædeLedig;
            this.sædeNummer = sædeNummer;
            this.navn = navn;

        }

        public void printSæde()
        {
            Console.WriteLine(this.navn + ", " + this.sædeNummer + ", " + this.erSædeLedig);
        }
    }
}
