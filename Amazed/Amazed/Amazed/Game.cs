using Amazed.Core;
using Amazed.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazed
{
    public partial class Game : Form
    {
        public Map map;
        public Player p1;

        public bool isPlaying = true;
        public float fps = 6f;

        public bool movingNorth, movingSouth, movingEast, movingWest;

        public Game()
        {
            InitializeComponent();
            KeyPreview = true;

            map = new Map();
            p1 = new Player(this, 32, 24);

            GameLoop();
        }

        private void GameLoop()
        {
            
            new Thread(() =>
            {
                while (isPlaying)
                {
                    if (movingNorth)
                    {
                        p1.MoveNorth();
                    }
                    else if (movingSouth)
                    {
                        p1.MoveSouth();
                    }
                    else if (movingEast)
                    {
                        p1.MoveEast();
                    }
                    else if (movingWest)
                    {
                        p1.MoveWest();
                    }
                    ReDraw();
                    Thread.Sleep((int)(1000 / fps));
                }
            }).Start();
        }

        public void ReDraw()
        {
            textBox2.Invoke(new Action(delegate() { textBox2.Lines = map.GetMapLines(p1.x, p1.y); }));
        }


        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:

                case Keys.Left:
                    movingWest = true;
                    break;
                case Keys.D:

                case Keys.Right:
                    movingEast = true;
                    break;
                case Keys.W:

                case Keys.Up:
                    movingNorth = true;
                    break;
                case Keys.S:

                case Keys.Down:
                    movingSouth = true;
                    break;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:

                case Keys.Left:
                    movingWest = false;
                    break;
                case Keys.D:

                case Keys.Right:
                    movingEast = false;
                    break;
                case Keys.W:

                case Keys.Up:
                    movingNorth = false;
                    break;
                case Keys.S:

                case Keys.Down:
                    movingSouth = false;
                    break;
            }
        }

        private void Game_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Console.WriteLine("Closing");
            isPlaying = false;
        }



        // Press mouse
        private void button3_Click(object sender, EventArgs e)
        {
            movingNorth = true;
        }

        private void btnMoveSouth_Click(object sender, EventArgs e)
        {
            movingSouth = true;
        }

        private void btnMoveWest_Click(object sender, EventArgs e)
        {
            movingWest = true;
        }

        private void btnMoveEast_Click(object sender, EventArgs e)
        {
            movingEast = true;
        }

        // Release mouse
        private void button3_Up(object sender, EventArgs e)
        {
            movingNorth = false;
        }

        private void btnMoveSouth_Up(object sender, EventArgs e)
        {
            movingSouth = false;
        }

        private void btnMoveWest_Up(object sender, EventArgs e)
        {
            movingWest = false;
        }

        private void btnMoveEast_Up(object sender, EventArgs e)
        {
            movingEast = false;
        }



    }
}
