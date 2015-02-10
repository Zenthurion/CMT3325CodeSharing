using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazed.Core
{
    public partial class MapSpace
    {
        private string value;
        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        private bool isVisited;
        public bool IsVisited
        {
            get { return isVisited; }
            set { isVisited = value; }
        }

    }
}
