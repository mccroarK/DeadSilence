using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Outcome
    {
        public static void Get(int playerHp, int mobHp)
        {
            if (playerHp > mobHp)
            {
                Console.WriteLine("Player wins");
            }
            else if (mobHp > playerHp)
            {
                Console.WriteLine("Mob wins");
            }
            else
            {
                Console.WriteLine("Draw");
            }

            // End input
            Console.WriteLine("[End]");
            Console.ReadLine();
        }
    }
}
