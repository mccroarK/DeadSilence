using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Display
    {
        // Done in for loops to support printing of both name and description arrays/lists

        #region Objects
        public static void Room()
        {
            // Print current room (change to IDReader ID to room world.player.location)
            World.currentRoom.Info();
            World.currentRoom.ShowExits();
        }

        public static void Rooms()
        {
            // Print Rooms
            foreach (Room room in World.rooms)
            {
                room.Info();
            }
        }

        public static void Weapon(Player player)
        {
            // Print single weapon (Player)
            player.Weapon.InfoAll();
        }

        public static void Weapons()
        {
            // Print all weapons
            foreach (Weapon weapon in World.weapons)
            {
                weapon.Info();
            }
        }

        public static void Potions()
        {
            // Print all potions
            foreach (Potion potion in World.potions)
            {
                potion.Info();
            }
        }

        public static void Treasures()
        {
            // Print all treasures
            foreach (Treasure treasure in World.treasures)
            {
                treasure.Info();
            }
        }

        public static void Items()
        {
            // Print all items
            foreach(Item item in World.items)
            {
                item.Info();
            }
        }

        public static void Mobs()
        {
            // Print all mobs
            foreach (Mob mob in World.mobs)
            {
                mob.Info();
            }
        }
        #endregion
    }
}
