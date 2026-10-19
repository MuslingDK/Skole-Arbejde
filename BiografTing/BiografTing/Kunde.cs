using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Kunde
    {
        public string name { get; set; }
        public List<Sæde> reservationer { get; set; }

        public Kunde(string name, List<Sæde> reservationer)
        {
            this.name = name;
            this.reservationer = reservationer;
        }
    }
}
