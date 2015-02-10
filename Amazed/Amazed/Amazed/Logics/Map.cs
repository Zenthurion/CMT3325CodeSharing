using Amazed.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazed.Logics
{
    public class Map
    {
        private MapSpace[,] grid = new MapSpace[25, 70];

        public Map()
        {

            StreamReader fileStream = new StreamReader("Map.txt");

            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {

                    grid[y,x] = new MapSpace();
                    grid[y, x].Value = (char)fileStream.Read();
                    grid[y, x].IsVisited = true;

                }
            }
        }


        public MapSpace[,] GetMapSpace()
        {
            return grid;
        }

        public string[] GetMapLines()
        {
            string[] lines = new string[grid.GetLength(0)];

            for (int x = 0; x < grid.GetLength(1); x++)
            {
                var xy = grid.GetLength(0);
                for (int y = 0; y < xy; y++)
                {
                    lines[y] += grid[y, x].Value;
                }
            }

            return lines;
        }

    }
}
