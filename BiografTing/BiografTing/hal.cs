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
        
        public Hal(int antalSæder, string name) : base(name)
        {
            this.antalSæder = antalSæder;
            for (int i = 0; i < antalSæder; i++)
            {
                bool rng = new Random().Next(2) == 0;
                sæder.Add(new Sæde(rng, i + 1));
            }
        }

        public void PrintSæder()
        {
            for (int i = 0; i < sæder.Count; i++)
            {
                if (sæder[i].isSeatAvailable)
                {
                    Console.WriteLine("Sæde " + sæder[i].seatNumber + ": Ledig");
                }
                else
                {
                    Console.WriteLine("Sæde " + sæder[i].seatNumber + ": Optaget");
                }
            }
        } 
    }
}
