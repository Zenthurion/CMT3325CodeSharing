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

        public Game()
        {
            InitializeComponent();
            map = new Map();
            textBox2.Lines = map.GetMapLines();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
