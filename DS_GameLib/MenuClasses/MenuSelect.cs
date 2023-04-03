using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class MenuSelect
    {
        public static bool Choose(string input)
        {
            Console.Clear();

            bool exitMenu = false; // Menu sentry boolean

            switch (input) // Choose menu choices
            {
                case "1":
                case "room":
                case "rooms":
                    MenuOption.Show(1); // Option 1: Display Rooms
                    break;

                case "2":
                case "weapon":
                case "weapons":
                    MenuOption.Show(2); // Option 2: Display Weapons
                    break;

                case "3":
                case "potion":
                case "potions":
                    MenuOption.Show(3); // Option 3: Display Potions
                    break;

                case "4":
                case "treasure":
                case "treasures":
                    MenuOption.Show(4); // Option 4: Display Treasures
                    break;

                case "5":
                case "item":
                case "items":
                    MenuOption.Show(5); // Option 5: Display Items
                    break;

                case "6":
                case "mob":
                case "mobs":
                    MenuOption.Show(6); // Option 6: Display Mobs
                    break;

                case "7":
                case "exit":
                    Console.WriteLine("Goodbye"); // Option 7: Exit Program
                    exitMenu = true;
                    break;

                default:
                    Console.WriteLine("Answer is invalid");
                    break;
            }

            return exitMenu;
        }
    }
}
