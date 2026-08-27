using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlhåndtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int div = int.Parse(Console.ReadLine());
                Console.WriteLine(10/div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("fejl");
            }
            Console.ReadLine();

            
        }
    }
}
