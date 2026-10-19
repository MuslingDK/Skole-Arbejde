using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Sæde : Film
    {
        public bool isSeatAvailable { get; set; }
        public int seatNumber { get; set; }
        public string filmNavn { get; set; }

        public Sæde(bool isSeatAvailble, int seatNumber,string name) : base(name)
        {
            this.isSeatAvailable = isSeatAvailable;
            this.seatNumber = seatNumber;
            this.name = name;

        }

        public void printSæde()
        {
            Console.WriteLine(this.name + ", " + this.seatNumber + ", " + this.isSeatAvailable);
        }
    }
}
