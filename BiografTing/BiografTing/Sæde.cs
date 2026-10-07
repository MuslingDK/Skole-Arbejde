using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Sæde
    {
        public bool isSeatAvailable { get; set; } = true;
        public int seatNumber { get; set; }

        public Sæde(bool isSeatAvailble, int seatNumber)
        {
            this.isSeatAvailable = isSeatAvailable;
            this.seatNumber = seatNumber;
        }

    }
}
