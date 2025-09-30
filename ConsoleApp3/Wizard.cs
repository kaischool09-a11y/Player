using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    internal class Wizard:Player
    {
   private int spellPower;
        public int SpellPower { 
        get { return spellPower; }
            set { if (value < 1 || value > 10)

                    throw new ArgumentOutOfRangeException("not in range, must be between 1-10 ") ;
            }

        }

        public Wizard (string name) : base(name)
        {
            spellPower = 1;
        }
        public void castSpell(Player enemy)
        {
            Console.WriteLine("Abracadabra!!!!!!!");
            enemy.strength -= 3;
        }
        public override void attack(Player enemy)
        {
            castSpell(enemy);
        }
    }
}
