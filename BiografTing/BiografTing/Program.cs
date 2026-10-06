using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BiografTing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde Cust = new Kunde();
            Film Hal1 = new Film("Kung Fu Kasper!");
            Film Hal2 = new Film("50 Shades of Monster");
            Film Hal3 = new Film("Munkeren Munk");
            
            Sæde s1 = new Sæde();
            Sæde s2 = new Sæde();
            Sæde s3 = new Sæde();
            Sæde s4 = new Sæde();
            Sæde s5 = new Sæde();

            Hal1.sæder.Add(s1);Hal1.sæder.Add(s2);Hal1.sæder.Add(s3);Hal1.sæder.Add(s4);Hal1.sæder.Add(s5);
            Hal2.sæder.Add(s1);Hal2.sæder.Add(s2);Hal2.sæder.Add(s3);Hal2.sæder.Add(s4);Hal2.sæder.Add(s5);
            Hal3.sæder.Add(s1);Hal3.sæder.Add(s2);Hal3.sæder.Add(s3);Hal3.sæder.Add(s4);Hal3.sæder.Add(s5);

        }
    }
}
