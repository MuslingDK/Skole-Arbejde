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
            this.name = name;
            for (int i = 0; i < antalSæder; i++)
            {
                sæder.Add(new Sæde(true, i + 1, name));
            }
        }

        public void PrintSæder()
        {
            for (int i = 0; i < sæder.Count; i++)
            {
                if (sæder[i].isSeatAvailable == true)
                {
                    Console.WriteLine("Sæde " + sæder[i].seatNumber + ": Ledig");
                }
                else
                {
                    Console.WriteLine("Sæde " + sæder[i].seatNumber + ": Optaget");
                }
            }
        }

        private bool RandomBool()
        {
            int RandomNumber = new Random().Next(2);
            return RandomNumber < 1;
        }

        public int AntalLedigeSæder()
        {
            int antalLedigeSæder = 0;
            for (int i = 0; i < sæder.Count; i++)
            {
                if (sæder[i].isSeatAvailable == true)
                {
                    antalLedigeSæder++;
                }
            }
            return antalLedigeSæder;
        }
    }
}
