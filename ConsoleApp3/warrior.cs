using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    internal class warrior : Player
    {
        public warrior(string name) : base(name)
        {
            hasShield = true;
            hasSword = true;
        }
        public bool hasShield { get; set; }
        public bool hasSword { get; set; }


        public override void attack(Player enemy)
        {
            if (hasSword)
            {
                Console.WriteLine("For honor!!!!");
                enemy.hp -= 3;
            }
            else
            {
                base.attack(enemy);
            }
        }
        public override string ToString()
        {
            return $"{ base.ToString()} hasShield : {hasShield}, hasSword : {hasSword}" ;
        }

    }
}
