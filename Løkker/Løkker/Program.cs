using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Løkker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();

            bool IsRunning = false;
            for (int k = 5; !IsRunning; k--)
            {
                if (k == 0)
                {
                    IsRunning = true;
                }
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
