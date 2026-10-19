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
                sæder.Add(new Sæde(RandomBool(), i + 1, name));
                Console.WriteLine(RandomBool());
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

        public bool RandomBool()
        {
            int RandomNumber = new Random().Next(100);
            return RandomNumber < 50;
        }
    }
}
