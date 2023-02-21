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
            String room1 = "Lived-in Cabin";
            String room2 = "Dim Cabin";
            String room3 = "Bloody Cabin";
            String room4 = "Cliffside Outpost";
            String room5 = "Hoarder's Cabin";

            // Weapons - 4
            String weapon1 = "Wood Chair";
            String weapon2 = "Kitchen Knife";
            String weapon3 = "Metal Pipe";
            String weapon4 = "Pocket Revolver";

            // Potions (Edible Items) - 2
            String food1 = "Soft Drink [Cherry]";
            String food2 = "Energy Drink";

            // Treasure (Key/Unique Items) - 3
            String treasure1 = "$10 Bill";
            String treasure2 = "Family Photo";
            String treasure3 = "Ornate Watch";

            // Items - 4
            String item1 = "Pebble";
            String item2 = "Glass Bottle";
            String item3 = "Cooking Pot";
            String item4 = "Lighter";

            // Mobs - 5
            String mob1 = "Zid";
            String mob2 = "Newcomer";
            String mob3 = "The Screamer";
            String mob4 = "Abomination";
            String mob5 = "The Beast";

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
                    // Display Rooms (5)
                    Console.WriteLine(room1);
                    Console.WriteLine(room2);
                    Console.WriteLine(room3);
                    Console.WriteLine(room4);
                    Console.WriteLine(room5);
                    break;

                case "2":
                case "weapon":
                case "weapons":
                    // Display Weapons (4)
                    Console.WriteLine(weapon1);
                    Console.WriteLine(weapon2);
                    Console.WriteLine(weapon3);
                    Console.WriteLine(weapon4);
                    break;

                case "3":
                case "potion":
                case "potions":
                    // Display Potions (2)
                    Console.WriteLine(food1);
                    Console.WriteLine(food2);
                    break;

                case "4":
                case "treasure":
                case "treasures":
                    // Display Treasures (3)
                    Console.WriteLine(treasure1);
                    Console.WriteLine(treasure2);
                    Console.WriteLine(treasure3);
                    break;

                case "5":
                case "item":
                case "items":
                    // Display Items (4)
                    Console.WriteLine(item1); 
                    Console.WriteLine(item2);
                    Console.WriteLine(item3);
                    Console.WriteLine(item4);
                    break;

                case "6":
                case "mob":
                case "mobs":
                    // Display Mobs (5)
                    Console.WriteLine(mob1);
                    Console.WriteLine(mob2);
                    Console.WriteLine(mob3);
                    Console.WriteLine(mob4);
                    Console.WriteLine(mob5);
                    break;

                case "7":
                case "exit":
                    // Exit Program
                    Console.WriteLine("Goodbye");
                    break;

                default:
                    // If user enters an invalid answer
                    Console.WriteLine("Answer is invalid");
                    break;
            }

            // End of program
            Console.ReadLine();
        }
    }
}
