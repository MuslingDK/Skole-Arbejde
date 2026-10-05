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
        public string password { get; set; }
        public List<Kunde> reservationer { get; set; }
    }
}
