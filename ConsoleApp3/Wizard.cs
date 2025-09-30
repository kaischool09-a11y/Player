using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    internal class Wizard:Player
    {
        public int level { get; set; }
        public Wizard (string name) : base(name)
        {
            level = 1;
        }
        
    }
}
