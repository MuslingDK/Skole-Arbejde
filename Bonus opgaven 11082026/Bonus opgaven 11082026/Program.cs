using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_opgaven_11082026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double year = 0.0;
            double LeapYeap = 0.0;

            year = int.Parse(Console.ReadLine());

            LeapYeap = year % 4;

            if (LeapYeap == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }*/
            double Year = 0.0;
            double QuarterYear = 0.0;

            Year = int.Parse(Console.ReadLine());

            QuarterYear = Year % 4;
            
            if (QuarterYear == 0)
            {
                Console.WriteLine("Det er et skudår");
            }
            else
            {
                Console.WriteLine("Det er ikke et skudår");
            }
            Console.ReadLine();
        }
    }
}
