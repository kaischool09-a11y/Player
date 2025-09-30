using player;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Wizard w = new Wizard("Brad");
            w.SpellPower = 5;
            warrior war = new warrior("Findard");
            war.attack(w);
            Player p= new Player("Gerlic");
            Console.WriteLine(p);
            Console.WriteLine(w);
            Console.WriteLine(war);

            Player[] players = new Player[5];
            for (int i = 0; i < players.Length; i++)
            {
               if( players[i] is Wizard) {
                 (  (Wizard) players[i]).SpellPower += 4;
                    
            }
               else if (players[i] is warrior)
                {
                    for (int j = 0; j < players.Length; j++)
                    {
                      if( players[j] is Wizard)
                            {
                            ((warrior)players[i]).attack(players[j]);
                        }
                    }
                }



            }
    }
}
