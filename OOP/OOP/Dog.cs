using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Dog : Animal
    {
        private string race;
        private string name;
        private int alder;


        public Dog(string race, string name, int alder, double pris, int antalBen, bool nøgen)
            : base(pris, antalBen, nøgen)
        {
            this.race = race;
            this.name = name;
            this.alder = alder;
        }

        public string getRace() { return race; }

        public string getName() { return name; }

        public int getAlder() { return alder; }

        public void setRace(string race) { this.race = race; }

        public void setName(string name) { this.name = name; }

        public void setAlder(int alder) { this.alder = alder; }

        public override void calcNumLegs()
        {
            setAntalBen(4);
        }

        public override double calcCost()
        {
            return getPris() * 0.95;
        }

        public void printAll()
        {
            Console.WriteLine(this.race + ", " + this.name + ", " + this.alder + " år, " + this.calcCost() + " kr, " + this.getAntalBen() + " ben, " + this.getNøgen());
        }
    }
}
