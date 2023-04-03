using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Menu
    {
        public static void DisplayMenu()
        {
            // Print Menu
            Console.WriteLine("[1] Display Rooms");
            Console.WriteLine("[2] Display Weapons");
            Console.WriteLine("[3] Display Potions");
            Console.WriteLine("[4] Display Treasures");
            Console.WriteLine("[5] Display Items");
            Console.WriteLine("[6] Display Mobs");
            Console.WriteLine("[7] Exit");
        }
    }
}
