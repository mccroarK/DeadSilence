using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Battle
    {
        public static void Engage(int hpValue1, int hpValue2)
        {
            // Temp class, will probably be replaced by objects when learned

            // Health variables
            int playerHp = hpValue1; // Player HP
            int mobHp = hpValue2; // Mob HP

            // Combat variables
            string playerDie = "1D12"; // Player damage string
            string mobDie = "1D12"; // Mob damage string

            //Random rand = new Random();

            Combat.Fight(playerHp, playerDie, mobHp, mobDie);
        }
    }
}
