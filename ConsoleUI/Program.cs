using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 2/15/2023
* CSC 153
* Kevin McCroary
* C# Game Project
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local Variables
            // Rooms - 5
            String room1 = "";
            String room2 = "";
            String room3 = "";
            String room4 = "";
            String room5 = "";

            // Weapons - 4
            String weapon1 = "";
            String weapon2 = "";
            String weapon3 = "";
            String weapon4 = "";

            // Potions - 2
            String food1 = "";
            String food2 = "";

            // Treasure - 3
            String treasure1 = "";
            String treasure2 = "";
            String treasure3 = "";

            // Items - 4
            String item1 = "";
            String item2 = "";
            String item3 = "";
            String item4 = "";

            // Mobs - 5
            String mob1 = "";
            String mob2 = "";
            String mob3 = "";
            String mob4 = "";
            String mob5 = "";

            Console.WriteLine("[1] Display Rooms");
            Console.WriteLine("[2] Display Weapons");
            Console.WriteLine("[3] Display Potions");
            Console.WriteLine("[4] Display Treasure");
            Console.WriteLine("[5] Display Items");
            Console.WriteLine("[6] Display Mobs");
            Console.WriteLine("[7] Exit");

            Console.Write(">> ");

            // Get user input
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "room":
                case "rooms":
                    // Display Rooms
                    Console.WriteLine("Rooms"); // Placeholder
                    break;

                case "2":
                case "weapon":
                case "weapons":
                    // Display Weapons
                    Console.WriteLine("Weapons"); // Placeholder
                    break;

                case "3":
                case "potion":
                case "potions":
                    // Display Potions
                    Console.WriteLine("Potions"); // Placeholder
                    break;

                case "4":
                case "treasure":
                case "treasures":
                    // Display Treasures
                    Console.WriteLine("Treasures"); // Placeholder
                    break;

                case "5":
                case "item":
                case "items":
                    // Display Items
                    Console.WriteLine("Items"); // Placeholder
                    break;

                case "6":
                case "mob":
                case "mobs":
                    // Display Mobs
                    Console.WriteLine("Mobs"); // Placeholder
                    break;

                case "7":
                case "exit":
                    // Exit Program
                    Console.WriteLine("Goodbye");
                    break;

                default:
                    // If user enters an invalid answer
                    Console.WriteLine("Answer out of range");
                    break;
            }

            // End of program
            Console.ReadLine();
        }
    }
}
