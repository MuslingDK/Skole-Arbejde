using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);

            if (age < 10)
            {
                Console.WriteLine("Du er et barn");
            }
            else if (age < 20)
            {
                Console.WriteLine("Du er en teenager");
            }
            else if (age < 65)
            {
                Console.WriteLine("Du er voksen");
            }
            else if ( age < 80)
            {
                Console.WriteLine("Du er gammel");
            }
            else
            {
                Console.WriteLine("Du er død");
            }
        }
    }
}
