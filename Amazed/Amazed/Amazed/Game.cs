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
        Map map;
        Player p1;
        public Game()
        {
            InitializeComponent();
            map = new Map();
            textBox2.Lines = map.GetMapLines();

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
    }
}
