using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Kunde
    {
        public string navn { get; set; }
        public List<Sæde> reservationer { get; set; }

        public Kunde(string navn, List<Sæde> reservationer)
        {
            this.navn = navn;
            this.reservationer = reservationer;
        }
    }
}
