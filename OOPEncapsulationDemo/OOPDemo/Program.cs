using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vi kan nu skabe nye køretøjer, som registreres i systemet i variablerne v1, v2 og v3.
            Vehicle v1 = new Vehicle(276, "ikke registrering", 17017);
            Vehicle v2 = new Vehicle(600, "registrering", 5);
            Vehicle v3 = new Vehicle(60, "registrering", 10);
            // For at hente specifikt information frem, så skal vi anvende get-metoder!
            // Hvis vi ikke gør det, og blot skriver 'v1' i vores WriteLine metode, så får vi kun en besked tilbage om,
            // at køretøjet ligger et sted i hukkomelsen (at det rent faktisk eksisterer) uden konkret information tilhørende
            // det pågældende køretøj.
            Console.WriteLine("første bils antal hæstekræfter: " + v1.getHorsePower() + ", antal kr: " + v1.getCost());
            Console.ReadKey();
            // Vi kan sagtens anvende objekter (eller køretøjer) i kollektioner, hvadend vi anvender det i arrays eller lister.
            Vehicle[] vehicleCollection = {v1, v2, v3};
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(v1); 
        }
    }
}
