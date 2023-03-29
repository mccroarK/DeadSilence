using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Combat
    {
        public static void Fight()
        {
            // Health variables
            int pla_hp = 150; // Player HP
            int mob_hp = 150; // Mob HP

            // Combat variables
            string pla_die = "1D12"; // Player damage string
            string mob_die = "1D12"; // Mob damage string
            int damage;
            Random rand = new Random();

            // Combat turns
            while ((pla_hp > 0) && (mob_hp > 0))
            {
                // Clear console
                Console.Clear();

                if (pla_hp > 0)
                {
                    // If player is alive, attack
                    damage = GetDmg(rand, pla_die);
                    mob_hp -= damage;
                    Console.WriteLine($"Player deals {damage} damage to Mob."); // Placeholder
                }

                if (mob_hp > 0)
                {
                    // If mob is alive, attack
                    damage = GetDmg(rand, mob_die);
                    pla_hp -= damage;
                    Console.WriteLine($"Mob deals {damage} damage to Player."); // Placeholder
                }

                // Continue
                Console.WriteLine("[Next Turn]");
                Console.ReadLine();
            }

            if (pla_hp > mob_hp)
            {
                Console.WriteLine("Player wins");
            }
            else if (mob_hp > pla_hp)
            {
                Console.WriteLine("Mob wins");
            }
            else
            {
                Console.WriteLine("Tie");
            }

            // End input
            Console.WriteLine("[End]");
        }

        public static int GetDmg(Random rand, string die)
        {
            // Get damage from entity die
            int damage;

            string[] dmg_range = die.Split('D');
            damage = rand.Next(1, int.Parse(dmg_range[1]) + 1) * int.Parse(dmg_range[0]);

            return damage;
        }
    }
}
