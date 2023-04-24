using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Command
    {
        public static bool Choose(string input)
        {
            Console.Clear();

            bool exitGame = false; // Menu sentry boolean

            switch (input) // Choose menu choices
            {
                case "help":
                case "command":
                case "commands":
                    SystemMessage.Help();
                    break;

                case "n":
                case "north":
                    Move.Walk("north");
                    break;

                case "s":
                case "south":
                    Move.Walk("south");
                    break;

                case "room":
                case "rooms":
                    DisplayOption.Room(); // Display Current Room
                    break;

                case "weapon":
                case "weapons":
                    DisplayOption.Weapons(); // Display Weapons
                    break;

                case "drink":
                case "drinks":
                case "potion":
                case "potions":
                    DisplayOption.Potions(); // Display Potions
                    break;

                case "treasure":
                case "treasures":
                    DisplayOption.Treasures(); // Display Treasures
                    break;

                case "item":
                case "items":
                    DisplayOption.Items(); // Display Items
                    break;

                case "mob":
                case "mobs":
                    DisplayOption.Mobs(); // Display Mobs
                    break;

                case "quit":
                case "exit":
                    SystemMessage.Goodbye(); // Exit program
                    exitGame = true;
                    break;

                default:
                    SystemMessage.InvalidInput(); // Bad input
                    break;
            }

            return exitGame;
        }
    }
}
