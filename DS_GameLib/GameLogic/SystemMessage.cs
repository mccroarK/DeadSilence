using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class SystemMessage
    {
        public static void Greet()
        {
            // Print greeting message
            Console.WriteLine("Type [help] to view the available commands");
        }

        public static void Help()
        {
            // Print commands
            Console.WriteLine("[north] [south] [east] [west] to move between rooms");
            Console.WriteLine("[inv] Open inventory");
            Console.WriteLine("[weapon] View equipped weapon");
            Console.WriteLine("[scan] View other mobs in the room");
            Console.WriteLine("[attack] Attack other mobs in the room");
            Console.WriteLine("[loot] View resources");
            Console.WriteLine("[exit] Exit the game");
        }

        public static void Goodbye()
        {
            // Print goodbye message
            Console.WriteLine("Goodbye");
        }
        public static void Win()
        {
            // Print win battle message
            Console.WriteLine("You win");
        }
        public static void Lose()
        {
            // Print lose battle message
            Console.Clear();
            Console.WriteLine("GAME OVER");
        }
        public static void InvalidInput()
        {
            // Print invalid input
            Console.WriteLine("I can't do that.");
        }

        public static void Move(string direction)
        {
            Console.WriteLine($"You move {direction}...");
        }

        public static void InvalidMove()
        {
            Console.WriteLine("OUCH! You walked into a wall.");
        }

        public static void Count(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
        }

        public static void Empty()
        {
            Console.WriteLine("There's nothing here.");
        }

        public static void Categories()
        {
            Console.WriteLine("[1] Items");
            Console.WriteLine("[2] Potions");
            Console.WriteLine("[3] Treasures");
            Console.WriteLine("[4] Weapons");
            Console.WriteLine("[5] Close");
            Console.WriteLine();
        }

        public static void Decisions()
        {
            Console.WriteLine("[1] Use");
            Console.WriteLine("[2] Drop");
            Console.WriteLine("[3] Cancel");
            Console.WriteLine();
        }

        public static void Premeditate()
        {
            Console.WriteLine("[1] Attack");
            Console.WriteLine("[2] Cancel");
            Console.WriteLine();
        }
    }
}
