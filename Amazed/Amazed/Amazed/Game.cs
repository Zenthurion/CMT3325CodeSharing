using Amazed.Core;
using Amazed.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazed
{
    public partial class Game : Form
    {
        public Map map;
        public Player p1;
        public Game()
        {
            InitializeComponent();
            map = new Map();
            ReDraw();
            p1 = new Player(this, 32, 24);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            p1.MoveNorth();
        }

        private void btnMoveSouth_Click(object sender, EventArgs e)
        {
            p1.MoveSouth();
        }

        private void btnMoveWest_Click(object sender, EventArgs e)
        {
            p1.MoveWest();
        }

        private void btnMoveEast_Click(object sender, EventArgs e)
        {
            p1.MoveEast();
        }


        public void ReDraw()
        {
            textBox2.Lines = map.GetMapLines(p1.x, p1.y);
        }


    }
}
