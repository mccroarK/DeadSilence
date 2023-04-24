using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Combat
    {
        public static void Fight(int player, string playerDie, int mob, string mobDie)
        {
            // Combat turns
            while ((player > 0) && (mob > 0))
            {
                // Clear console
                Console.Clear();

                int damage = 0;

                if (player > 0) // If player is alive, attack mob
                {
                    damage = RandomDie.Roll(playerDie);
                    mob -= damage;
                    Console.WriteLine($"Player deals {damage} damage to Mob.");
                }

                if (mob > 0) // If mob is alive, attack player
                {
                    damage = RandomDie.Roll(mobDie);
                    player -= damage;
                    Console.WriteLine($"Mob deals {damage} damage to Player.");
                }

                // Continue
                Console.WriteLine("[Next Turn]");
                Console.ReadLine();
            }

            // After combat is done
            Outcome(player, mob);
        }

        public static void Outcome(int playerHp, int mobHp)
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
        }
    }
}
