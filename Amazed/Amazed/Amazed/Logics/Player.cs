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
        private Game game;
        private char character = MapCharacters.Player;
        private char[,] map;
        public int x, y;

        private int keys = 0;

        public Player(Game game, int x, int y)
        {
            this.game = game;
            this.x = x;
            this.y = y;
        }

        private void SetMap(int x, int y, char value)
        {
            game.map.grid[x, y].Value = value;
            game.map.grid[x, y].IsVisited = true;

            game.ReDraw();
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
                        SetMap(xAttempt, yAttampt, MapCharacters.Path);
                        return true;
                    }
                }
                else
                {
                    if (target == MapCharacters.Key)
                    {
                        keys++;
                        SetMap(xAttempt, yAttampt, MapCharacters.Path);
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
            if (CheckMove(game.map.grid[x, y + 1].Value, x, y + 1))
            {
                SetMap(x, y, MapCharacters.Path);
                y += 1;
                SetMap(x, y, MapCharacters.Player);

            }
        }
        public void MoveEast()
        {
            if (CheckMove(game.map.grid[x + 1, y].Value, x + 1, y))
            {
                SetMap(x, y, MapCharacters.Path);
                x += 1;
                SetMap(x, y, MapCharacters.Player);
            }
        }
        public void MoveWest()
        {
            if (CheckMove(game.map.grid[x - 1, y].Value, x - 1, y))
            {
                SetMap(x, y, MapCharacters.Path);
                x -= 1;
                SetMap(x, y, MapCharacters.Player);
            }
        }
        public void MoveSouth()
        {
            if (CheckMove(game.map.grid[x, y - 1].Value, x, y - 1))
            {
                SetMap(x, y, MapCharacters.Path);
                y -= 1;
                SetMap(x, y, MapCharacters.Player);
            }
        }

        private void Update()
        {

        }

    }
}
