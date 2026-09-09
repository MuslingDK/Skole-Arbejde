using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cellullar_automaton_playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            grid gridCells = new grid(20);
            gridCells.genGrid();
            gridCells.setCell(5, 6, "█");

            while (true)
            {
                gridCells.simSand();
                Thread.Sleep(2000);
            }
        }
    }
}
