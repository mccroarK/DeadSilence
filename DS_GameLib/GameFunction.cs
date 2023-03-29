using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class GameFunction
    {
        public static void Menu()
        {
            // Menu Function
            // Local Variables
            bool exit = false; // Sentry

            do
            {
                // Print Menu
                Console.WriteLine("[1] Display Rooms");
                Console.WriteLine("[2] Display Weapons");
                Console.WriteLine("[3] Display Potions");
                Console.WriteLine("[4] Display Treasures");
                Console.WriteLine("[5] Display Items");
                Console.WriteLine("[6] Display Mobs");
                Console.WriteLine("[7] Combat Test");
                Console.WriteLine("[8] Exit");

                MakeChoice(0, ref exit);
            }
            while (!exit);
        }

        public static void MakeChoice(int context, ref bool sentry)
        {
            // Might move to Entity Class
            // Context = what the choice is used for
            string input;

            Console.Write("-> ");
            input = Console.ReadLine().ToLower();

            Console.Clear(); // Clear the console

            switch (context)
            {
                case 0:
                    // Menu choice
                    MenuChoice(input, ref sentry);
                    break;
                default:
                    // Invalid context
                    Console.WriteLine("Dumbass");
                    break;
            }

            // End
            Console.ReadLine();
            Console.Clear();
        }

        public static void MenuChoice(string input, ref bool sentry)
        {
            // Input file
            StreamReader inputfile;

            // Choose menu choices
            switch (input)
            {
                case "1":
                case "room":
                case "rooms":
                    MenuOp1(out inputfile); // Option 1: Display Rooms
                    break;

                case "2":
                case "weapon":
                case "weapons":
                    MenuOp2(out inputfile); // Option 2: Display Weapons
                    break;

                case "3":
                case "potion":
                case "potions":
                    MenuOp3(out inputfile); // Option 3: Display Potions
                    break;

                case "4":
                case "treasure":
                case "treasures":
                    MenuOp4(out inputfile); // Option 4: Display Treasures
                    break;

                case "5":
                case "item":
                case "items":
                    MenuOp5(out inputfile); // Option 5: Display Items
                    break;

                case "6":
                case "mob":
                case "mobs":
                    MenuOp6(out inputfile); // Option 6: Display Mobs
                    break;

                case "7":
                case "test":
                case "combat":
                case "combat test":
                    MenuOp7(); // Combat Test
                    break;

                case "8":
                case "exit":
                    // Option 7: Exit Program
                    Console.WriteLine("Goodbye");
                    sentry = true; // Exit
                    break;

                default:
                    Console.WriteLine("Answer is invalid");
                    break;
            }
        }

        public static void MenuOp1(out StreamReader inputfile)
        {
            // Menu Option 1: Display Rooms

            // Rooms - 5
            String room1, room2, room3, room4, room5,
                room1desc, room2desc, room3desc, room4desc, room5desc;

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
        }

        public static void MenuOp2(out StreamReader inputfile)
        {
            // Menu Option 2: Display Weapons

            // Weapons - 4
            String weapon1, weapon2, weapon3, weapon4,
                weapon1desc, weapon2desc, weapon3desc, weapon4desc;

            // Open and Close file
            using (inputfile = File.OpenText(@"../../txt/weapons.txt"))
            {
                // Read from file
                while (!inputfile.EndOfStream)
                {
                    // Assign Rooms (4)
                    weapon1 = inputfile.ReadLine();
                    weapon1desc = inputfile.ReadLine();
                    weapon2 = inputfile.ReadLine();
                    weapon2desc = inputfile.ReadLine();
                    weapon3 = inputfile.ReadLine();
                    weapon3desc = inputfile.ReadLine();
                    weapon4 = inputfile.ReadLine();
                    weapon4desc = inputfile.ReadLine();

                    // Print Rooms
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
        }

        public static void MenuOp3(out StreamReader inputfile)
        {
            // Menu Option 3: Display Potions

            // Potions - 2
            String potion1, potion2,
                potion1desc, potion2desc;

            // Open and Close file
            using (inputfile = File.OpenText(@"../../txt/potions.txt"))
            {
                // Read from file
                while (!inputfile.EndOfStream)
                {
                    // Assign Potions (2)
                    potion1 = inputfile.ReadLine();
                    potion1desc = inputfile.ReadLine();
                    potion2 = inputfile.ReadLine();
                    potion2desc = inputfile.ReadLine();

                    // Print Potions
                    Console.WriteLine(potion1);
                    Console.WriteLine(potion1desc);
                    Console.WriteLine();
                    Console.WriteLine(potion2);
                    Console.WriteLine(potion2desc);
                }
            }
        }

        public static void MenuOp4(out StreamReader inputfile)
        {
            // Menu Option 4: Display Treasures

            // Treasure (Key/Unique Items) - 3
            String treasure1, treasure2, treasure3,
                treasure1desc, treasure2desc, treasure3desc;

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
        }

        public static void MenuOp5(out StreamReader inputfile)
        {
            // Menu Option 5: Display Items

            // Items - 4
            String item1, item2, item3, item4,
                item1desc, item2desc, item3desc, item4desc;

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
        }

        public static void MenuOp6(out StreamReader inputfile)
        {
            // Menu Option 6: Display Mobs

            // Mobs - 5
            String mob1, mob2, mob3, mob4, mob5,
                mob1desc, mob2desc, mob3desc, mob4desc, mob5desc;

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
        }

        public static void MenuOp7()
        {
            Combat.Fight();
        }
    }
}
