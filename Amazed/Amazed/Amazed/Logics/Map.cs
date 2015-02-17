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
        public MapSpace[,] grid = new MapSpace[50, 25];

        public Map()
        {

            StreamReader fileStream = new StreamReader("Map.txt");

            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 50; x++)
                {

                    char c = (char)fileStream.Read();
                    if (c == '\r')
                    {
                        c = (char)fileStream.Read();
                    }

                    if (c == '\n')
                    {
                        c = (char)fileStream.Read();
                    }

                    grid[x, y] = new MapSpace();
                    grid[x, y].Value = c;
                    grid[x, y].IsVisited = true;
                }
            }
        }


        public MapSpace[,] GetMapSpace()
        {
            return grid;
        }

        public string[] GetMapLines()
        {
            string[] lines = new string[25];

            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    lines[x] += grid[y, x].Value;
                }
            }

            return lines;
        }

    }
}
