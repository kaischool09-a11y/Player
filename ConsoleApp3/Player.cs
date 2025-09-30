using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    internal class Player
    {

        public string name { get; set; }
        public int hp { get; set; }
        public int strength { get; set; }

        public Player(string name)
        {
            this.name = name;
            this.hp = 10;
            this.strength = 100;
        }
        public virtual void attack(Player p2)
        {
            Console.WriteLine("heeeyaaa");
            p2.hp -= 1;
        }
        public override string ToString()
        {
            return $"name: {name}, hp: {hp}, strength: {strength}";
        }   
    }
   
}
