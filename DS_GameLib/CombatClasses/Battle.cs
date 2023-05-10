using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Battle
    {
        public static void Run(Player player, Mob mob)
        {
            // When able to, replace order with list containing mobs and players
            // Then use for loop to go through each entity in list
            // TEMP Mob gets first move
            Console.Clear();
            while (player.Alive && mob.Alive)
            {
                Turn(mob, player);
                Turn(player, mob);
            }
            if (player.Alive)
            {
                SystemMessage.Win();
            }
            else
            {
                SystemMessage.Lose();
            }
        }

        static void Turn(Mob attacker, Player victim)
        {
            Console.Clear();
            // Mob's turn
            attacker.Attack(victim);
            Console.WriteLine("[CONTINUE]");
            Console.ReadLine();
        }

        static void Turn(Player attacker, Mob victim)
        {
            Console.Clear();
            // Player's turn
            attacker.Attack(victim);
            Console.WriteLine("[Continue]");
            Console.ReadLine();
        }
    }
}
