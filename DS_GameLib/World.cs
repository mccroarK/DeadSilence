using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class World
    {
        // Containers
        public static List<Room> rooms = new List<Room>();
        public static List<Exit> exits = new List<Exit>();

        // Things
        public static List<Weapon> weapons = new List<Weapon>();
        public static List<Potion> potions = new List<Potion>();
        public static List<Treasure> treasures = new List<Treasure>();
        public static List<Item> items = new List<Item>();

        // Actors
        public static List<Mob> mobs = new List<Mob>();

        // Current Room
        public static Room currentRoom;

        // Current Player
        public static Player player; // Player character
    }
}
