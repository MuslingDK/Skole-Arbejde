using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellullar_automaton_playground
{
    internal class grid
    {
        public int size;
        List<List<string>> cells = new List<List<string>>();

        public grid(int size)
        {
             this.size = size;
        }

        public void genGrid() 
        {
            for (int i = 0; i < size; i++)
            {
                cells.Add(new List<string>());
                for (int j = 0; j < size; j++)
                {
                    cells[i].Add(".");
                } 
            }
            showGrid();
        }

        public void showGrid()
        {
            Console.Clear();
            for (int i = 0; i < cells.Count; i++)
            {
                for (int j = 0;j < cells[i].Count; j++ )
                {
                    Console.Write(cells[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void setCell(int y, int x, string newValue)
        {
            cells[y][x] = newValue;
            showGrid();
        }

        public void simSand()
        {
            for (int i = 0; i < cells.Count; i++)
            {
                for (int j = 0; j < cells.Count; j++)
                {
                    if (cells[i][j] == "█")
                    {
                        setCell(i, j, ".");
                        setCell(i + 1, j, "█");
                    }
                }
            }
        }
    }
}
