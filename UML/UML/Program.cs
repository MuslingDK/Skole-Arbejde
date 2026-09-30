using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    internal class Program
    {
        public static Kunder havregyn = new Kunder();
        public static List<Sæde> tog = new List<Sæde>();

        static void Main(string[] args)
        {
            havregyn.name = "Solsikke";
            havregyn.reservationer = new List<Sæde>();

            Sæde sæde1 = new Sæde();
            Sæde sæde2 = new Sæde();
            Sæde sæde3 = new Sæde();
            sæde1.erSædeLedig = true;
            sæde2.erSædeLedig = true;
            sæde3.erSædeLedig = true;
            tog.Add(sæde1); tog.Add(sæde2); tog.Add(sæde3);

            
        }

        private static void ReseverSæde()
        {
            Console.WriteLine("Hvor vil du sidde mellem 0 og 2");
            string userInput = Console.ReadLine();
            int userNum = int.Parse(userInput);

            if (tog[userNum].erSædeLedig == true) 
            {
                Console.WriteLine("Ja det sæde er ledigt");

            }
        }
    }
}
