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
            /*
             * Eventually remove the need for switch by way of creating an Action Class and making a list of Actions for player
             * to activate by looping through each action to check if a keyword was entered
            */

            Console.Clear();

            bool exitGame = false; // Menu sentry boolean

            switch (input) // Choose menu choices
            {
                case "help":
                case "command":
                case "commands":
                    SystemMessage.Help();
                    break;
                case "inv":
                case "inventory":
                case "bag":
                case "bags":
                    World.player.Inventory();
                    break;

                case "loot":
                case "pick":
                case "pickup":
                case "pick up":
                    // Let player choose to pick up items, potions, treasures, and weapons
                    //World.player.Loot(World.currentRoom.Items, World.player.Bags);
                    // TEMP END
                    World.player.LootRoom(World.currentRoom);
                    break;

                case "n":
                case "north":
                    // Check if exit exists, then move north
                    if (World.currentRoom.ExitIDs[0] != -1)
                    {
                        World.player.Use(IDReader.IDtoExit(World.currentRoom.ExitIDs[0])); // Use the north exit
                    }
                    break;

                case "s":
                case "south":
                    // Check if exit exists, then move south
                    if (World.currentRoom.ExitIDs[1] != -1)
                    {
                        World.player.Use(IDReader.IDtoExit(World.currentRoom.ExitIDs[1])); // Use the south exit
                    }
                    break;

                case "e":
                case "east":
                    // Check if exit exists, then move east
                    if (World.currentRoom.ExitIDs[2] != -1)
                    {
                        World.player.Use(IDReader.IDtoExit(World.currentRoom.ExitIDs[2])); // Use the east exit
                    }
                    break;

                case "w":
                case "west":
                    // Check if exit exists, then move west
                    if (World.currentRoom.ExitIDs[3] != -1)
                    {
                        World.player.Use(IDReader.IDtoExit(World.currentRoom.ExitIDs[3])); // Use the west exit
                    }
                    break;

                case "attack":
                    // Select mobs
                    World.player.FindMobs(World.currentRoom);
                    break;

                case "log":
                case "logbook":
                case "journal":
                    // Open logbook
                    break;

                case "weapon":
                    // Show player weapon
                    break;

                case "item":
                case "items":
                    foreach (Bag bag in World.player.Bags)
                    {
                        Console.WriteLine($"Bag {bag.CurrentSlots}/{bag.Slots}");
                        bag.Show("items"); // Show all items in all bags
                    }
                    break;

                case "food":
                case "drink":
                case "drinks":
                case "potion":
                case "potions":
                    foreach (Bag bag in World.player.Bags)
                    {
                        Console.WriteLine($"Bag {bag.CurrentSlots}/{bag.Slots}");
                        bag.Show("potions"); // Show all potions in all bags
                    }
                    break;

                case "treasure":
                case "treasures":
                    foreach (Bag bag in World.player.Bags)
                    {
                        Console.WriteLine($"Bag {bag.CurrentSlots}/{bag.Slots}");
                        bag.Show("treasures"); // Show all treasures in all bags
                    }
                    break;

                case "weapons":
                    foreach (Bag bag in World.player.Bags)
                    {
                        Console.WriteLine($"Bag {bag.CurrentSlots}/{bag.Slots}");
                        bag.Show("weapons"); // Show all weapons in all bags
                    }
                    break;

                case "scan":
                case "mob":
                case "mobs":
                    World.currentRoom.Show("mobs"); // Display Mobs
                    break;

                case "me":
                case "stats":
                case "status":
                case "player":
                    World.player.Info();
                    break;

                case "players":
                    World.currentRoom.Show("players");
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
