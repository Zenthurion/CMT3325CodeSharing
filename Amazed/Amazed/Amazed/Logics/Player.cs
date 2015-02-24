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
        private enum Sounds
        {
            PickUp,
            Open,
            Win
        }


        private Game game;
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

            game.keyLabel.Invoke(new Action(delegate() { game.keyLabel.Text = "k: " + keys; }));
            game.ReDraw();
        }


        private void PlaySound(Sounds sound)
        {
            switch (sound)
            {
                case Sounds.Open:

                    break;
                case Sounds.PickUp:

                    break;
                case Sounds.Win:

                    break;
            }
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
                        game.GameOver();
                    }
                    return true;
                }
            }
            return false;
        }

        public void MoveSouth()
        {
            if (game.map.grid.GetLength(1) - 1 > y && CheckMove(game.map.grid[x, y + 1].Value, x, y + 1))
            {
                SetMap(x, y, MapCharacters.Path);
                y += 1;
                //SetMap(x, y, MapCharacters.Player);

            }
        }
        public void MoveEast()
        {
            if (game.map.grid.GetLength(0) - 1 > x && CheckMove(game.map.grid[x + 1, y].Value, x + 1, y))
            {
                SetMap(x, y, MapCharacters.Path);
                x += 1;
               // SetMap(x, y, MapCharacters.Player);
            }
        }
        public void MoveWest()
        {
            if (y > 0 && CheckMove(game.map.grid[x - 1, y].Value, x - 1, y))
            {
                SetMap(x, y, MapCharacters.Path);
                x -= 1;
                //SetMap(x, y, MapCharacters.Player);
            }
        }
        public void MoveNorth()
        {
            if (y > 0 && CheckMove(game.map.grid[x, y - 1].Value, x, y - 1))
            {
                SetMap(x, y, MapCharacters.Path);
                y -= 1;
                //SetMap(x, y, MapCharacters.Player);
            }
        }

        private void Update()
        {

        }

    }
}
