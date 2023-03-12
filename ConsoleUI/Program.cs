using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**
* 3/11/2023
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
            bool exit = false; // Sentry

            // Input file
            StreamReader inputfile;

            // Rooms - 5
            String room1, room2, room3, room4, room5,
                room1desc, room2desc, room3desc, room4desc, room5desc;

            // Weapons - 4
            String weapon1, weapon2, weapon3, weapon4,
                weapon1desc, weapon2desc, weapon3desc, weapon4desc;

            // Potions (Edible Items) - 2
            String food1, food2,
                food1desc, food2desc;

            // Treasure (Key/Unique Items) - 3
            String treasure1, treasure2, treasure3,
                treasure1desc, treasure2desc, treasure3desc;

            // Items - 4
            String item1, item2, item3, item4,
                item1desc, item2desc, item3desc, item4desc;

            // Mobs - 5
            String mob1, mob2, mob3, mob4, mob5,
                mob1desc, mob2desc, mob3desc, mob4desc, mob5desc;

            do
            {
                // Print Menu
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
                        // Clear Console
                        Console.Clear();

                        // Open and Close file
                        using (inputfile = File.OpenText(@"../../txt/rooms.txt"))
                        {
                            // Read from file
                            while (!inputfile.EndOfStream) 
                            {
                                // Assign Rooms (5)
                                room1 = inputfile.ReadLine();
                                room1desc = inputfile.ReadLine();
                                room2 = inputfile.ReadLine();
                                room2desc = inputfile.ReadLine();
                                room3 = inputfile.ReadLine();
                                room3desc = inputfile.ReadLine();
                                room4 = inputfile.ReadLine();
                                room4desc = inputfile.ReadLine();
                                room5 = inputfile.ReadLine();
                                room5desc = inputfile.ReadLine();
                                
                                // Print Rooms
                                Console.WriteLine(room1);
                                Console.WriteLine(room1desc);
                                Console.WriteLine();
                                Console.WriteLine(room2);
                                Console.WriteLine(room2desc);
                                Console.WriteLine();
                                Console.WriteLine(room3);
                                Console.WriteLine(room3desc);
                                Console.WriteLine();
                                Console.WriteLine(room4);
                                Console.WriteLine(room4desc);
                                Console.WriteLine();
                                Console.WriteLine(room5);
                                Console.WriteLine(room5desc);
                            }
                            
                        }

                        

                        break;

                    case "2":
                    case "weapon":
                    case "weapons":
                        // Clear Console
                        Console.Clear();

                        // Open and Close file
                        using (inputfile = File.OpenText(@"../../txt/weapons.txt"))
                        {
                            // Read from file
                            while (!inputfile.EndOfStream)
                            {
                                // Assign Weapons (4)
                                weapon1 = inputfile.ReadLine();
                                weapon1desc = inputfile.ReadLine();
                                weapon2 = inputfile.ReadLine();
                                weapon2desc = inputfile.ReadLine();
                                weapon3 = inputfile.ReadLine();
                                weapon3desc = inputfile.ReadLine();
                                weapon4 = inputfile.ReadLine();
                                weapon4desc = inputfile.ReadLine();

                                // Print Weapons
                                Console.WriteLine(weapon1);
                                Console.WriteLine(weapon1desc);
                                Console.WriteLine();
                                Console.WriteLine(weapon2);
                                Console.WriteLine(weapon2desc);
                                Console.WriteLine();
                                Console.WriteLine(weapon3);
                                Console.WriteLine(weapon3desc);
                                Console.WriteLine();
                                Console.WriteLine(weapon4);
                                Console.WriteLine(weapon4desc);
                            }
                        }

                        break;

                    case "3":
                    case "potion":
                    case "potions":
                        // Clear Console
                        Console.Clear();

                        // Open and Close file
                        using (inputfile = File.OpenText(@"../../txt/potions.txt"))
                        {
                            // Read from file
                            while (!inputfile.EndOfStream)
                            {
                                // Assign Potions (2)
                                food1 = inputfile.ReadLine();
                                food1desc = inputfile.ReadLine();
                                food2 = inputfile.ReadLine();
                                food2desc = inputfile.ReadLine();

                                // Print Potions
                                Console.WriteLine(food1);
                                Console.WriteLine(food1desc);
                                Console.WriteLine();
                                Console.WriteLine(food2);
                                Console.WriteLine(food2desc);
                            }
                        }

                        break;

                    case "4":
                    case "treasure":
                    case "treasures":
                        // Clear Console
                        Console.Clear();

                        // Open and Close file
                        using (inputfile = File.OpenText(@"../../txt/treasures.txt"))
                        {
                            // Read from file
                            while (!inputfile.EndOfStream)
                            {
                                // Assign Treasures (3)
                                treasure1 = inputfile.ReadLine();
                                treasure1desc = inputfile.ReadLine();
                                treasure2 = inputfile.ReadLine();
                                treasure2desc = inputfile.ReadLine();
                                treasure3 = inputfile.ReadLine();
                                treasure3desc = inputfile.ReadLine();

                                // Print Treasures
                                Console.WriteLine(treasure1);
                                Console.WriteLine(treasure1desc);
                                Console.WriteLine();
                                Console.WriteLine(treasure2);
                                Console.WriteLine(treasure2desc);
                                Console.WriteLine();
                                Console.WriteLine(treasure3);
                                Console.WriteLine(treasure3desc);
                            }
                        }

                        break;

                    case "5":
                    case "item":
                    case "items":
                        // Clear Console
                        Console.Clear();

                        // Open and Close file
                        using (inputfile = File.OpenText(@"../../txt/items.txt"))
                        {
                            // Read from file
                            while (!inputfile.EndOfStream)
                            {
                                // Assign Items (4)
                                item1 = inputfile.ReadLine();
                                item1desc = inputfile.ReadLine();
                                item2 = inputfile.ReadLine();
                                item2desc = inputfile.ReadLine();
                                item3 = inputfile.ReadLine();
                                item3desc = inputfile.ReadLine();
                                item4 = inputfile.ReadLine();
                                item4desc = inputfile.ReadLine();

                                // Print Items
                                Console.WriteLine(item1);
                                Console.WriteLine(item1desc);
                                Console.WriteLine();
                                Console.WriteLine(item2);
                                Console.WriteLine(item2desc);
                                Console.WriteLine();
                                Console.WriteLine(item3);
                                Console.WriteLine(item3desc);
                                Console.WriteLine();
                                Console.WriteLine(item4);
                                Console.WriteLine(item4desc);
                            }
                        }

                        break;

                    case "6":
                    case "mob":
                    case "mobs":
                        // Clear Console
                        Console.Clear();

                        // Open and Close file
                        using (inputfile = File.OpenText(@"../../txt/mobs.txt"))
                        {
                            // Read from file
                            while (!inputfile.EndOfStream)
                            {
                                // Assign Mobs (5)
                                mob1 = inputfile.ReadLine();
                                mob1desc = inputfile.ReadLine();
                                mob2 = inputfile.ReadLine();
                                mob2desc = inputfile.ReadLine();
                                mob3 = inputfile.ReadLine();
                                mob3desc = inputfile.ReadLine();
                                mob4 = inputfile.ReadLine();
                                mob4desc = inputfile.ReadLine();
                                mob5 = inputfile.ReadLine();
                                mob5desc = inputfile.ReadLine();

                                // Print Mobs
                                Console.WriteLine(mob1);
                                Console.WriteLine(mob1desc);
                                Console.WriteLine();
                                Console.WriteLine(mob2);
                                Console.WriteLine(mob2desc);
                                Console.WriteLine();
                                Console.WriteLine(mob3);
                                Console.WriteLine(mob3desc);
                                Console.WriteLine();
                                Console.WriteLine(mob4);
                                Console.WriteLine(mob4desc);
                                Console.WriteLine();
                                Console.WriteLine(mob5);
                                Console.WriteLine(mob5desc);
                            }
                        }

                        break;

                    case "7":
                    case "exit":
                        // Exit Program
                        Console.WriteLine("Goodbye");
                        exit = true;
                        break;

                    default:
                        // If user enters an invalid answer
                        Console.WriteLine("Answer is invalid");
                        break;
                }

                // End Readline
                Console.ReadLine();
                Console.Clear();

            } while (!exit);
        }
    }
}
