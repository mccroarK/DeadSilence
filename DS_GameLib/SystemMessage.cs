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
            Console.WriteLine("Type [north] and [south] to move between rooms");
            Console.WriteLine("Type [room] to view your current room");
            Console.WriteLine("Type [weapon] to view weapons");
            Console.WriteLine("Type [potion] to view potions");
            Console.WriteLine("Type [treasure] to view treasures");
            Console.WriteLine("Type [item] to view items");
            Console.WriteLine("Type [mob] to view mobs");
            Console.WriteLine("Type [exit] to exit the game");
        }

        public static void Goodbye()
        {
            // Print goodbye message
            Console.WriteLine("Goodbye");
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
    }
}
