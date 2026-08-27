using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Animal
    {
        private bool nøgen;
        private double pris;
        private int antalBen;
        
        public Animal(double pris, int antalBen, bool nøgen)
        {
            this.pris = pris;
            this.antalBen = antalBen;
            this.nøgen = nøgen;
        }

        public bool getNøgen() { return nøgen; }

        public double getPris() { return pris; }

        public int getAntalBen() { return antalBen; }

        public void setNøgen(bool nøgen) { this.nøgen = nøgen;  }

        public void setAntalBen(int antalBen) { this.antalBen = antalBen; } 

        public void setPris(double pris) { this.pris = pris; }

        
    }
}
