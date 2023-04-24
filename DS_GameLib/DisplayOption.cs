using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class DisplayOption
    {
        // Done in for loops to support printing of both name and description arrays/lists

        public static void Room()
        {
            // Print current room
            Console.WriteLine(World.rooms[World.currentRoom]);
            Console.WriteLine(World.roomdescs[World.currentRoom]);
            Console.WriteLine();
        }

        public static void Rooms()
        {
            // Instead of rooms, make only current room by using room and currentRoom as index
            // Print Rooms
            for (int i = 0; i < World.rooms.Length; i++)
            {
                Console.WriteLine(World.rooms[i]);
                Console.WriteLine(World.roomdescs[i]);
                Console.WriteLine();
            }
        }

        public static void Weapons()
        {
            // Print Weapons
            for (int i = 0; i < World.weapons.Length; i++)
            {
                Console.WriteLine(World.weapons[i]);
                Console.WriteLine(World.weapondescs[i]);
                Console.WriteLine();
            }
        }

        public static void Potions()
        {
            // Print Potions
            for (int i = 0; i < World.potions.Length; i++)
            {
                Console.WriteLine(World.potions[i]);
                Console.WriteLine(World.potiondescs[i]);
                Console.WriteLine();
            }
        }

        public static void Treasures()
        {
            // Print Treasures
            for (int i = 0; i < World.treasures.Length; i++)
            {
                Console.WriteLine(World.treasures[i]);
                Console.WriteLine(World.treasuredescs[i]);
                Console.WriteLine();
            }
        }

        public static void Items()
        {
            // Print Items
            for (int i = 0; i < World.items.Count; i++)
            {
                Console.WriteLine(World.items[i]);
                Console.WriteLine(World.itemdescs[i]);
                Console.WriteLine();
            }
        }

        public static void Mobs()
        {
            // Print Mobs
            for (int i = 0; i < World.mobs.Count; i++)
            {
                Console.WriteLine(World.mobs[i]);
                Console.WriteLine(World.mobdescs[i]);
                Console.WriteLine();
            }
        }
    }
}
