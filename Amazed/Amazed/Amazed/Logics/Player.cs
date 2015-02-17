using Amazed.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazed
{
    public class Player
    {
        private char character = MapCharacters.Player;
        private char[,] map;
        private int x, y;

        private int keys = 0;

        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        private bool CheckMove(char target, int xAttempt, int yAttampt)
        {
            if (target != MapCharacters.Wall)
            {
                if (target == MapCharacters.HDoor || target == MapCharacters.VDoor)
                {
                    if (keys > 0)
                    {
                        keys--;
                        map[xAttempt, yAttampt] = MapCharacters.Path;
                        return true;
                    }
                }
                else
                {
                    if (target == MapCharacters.Key)
                    {
                        keys++;
                        map[xAttempt, yAttampt] = MapCharacters.Path;
                    }
                    else if (target == MapCharacters.Exit)
                    {
                        // TODO end the game
                    }
                    return true;
                }
            }
            return false;
        }

        public void MoveNorth()
        {
            if (CheckMove(map[x, y + 1], x, y + 1))
            {
                y += 1;
            }
        }
        public void MoveEast()
        {
            if (CheckMove(map[x + 1, y], x + 1, y))
            {
                x += 1;
            }
        }
        public void MoveWest()
        {
            if (CheckMove(map[x - 1, y], x - 1, y))
            {
                x -= 1;
            }
        }
        public void MoveSouth()
        {
            if (CheckMove(map[x, y - 1], x, y - 1))
            {
                y -= 1;
            }
        }

    }
}
