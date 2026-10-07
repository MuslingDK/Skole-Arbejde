using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Hal : Film
    {
        private List<Sæde> sæder { get; set; } = new List<Sæde>();
        private int antalSæder { get; set; }
        
        public Hal(int antalSæder, string name) : base(name)
        {
            this.antalSæder = antalSæder;
            for (int i = 0; i < antalSæder; i++)
            {
                sæder.Add(new Sæde(true));
            }
        }
    }
}
