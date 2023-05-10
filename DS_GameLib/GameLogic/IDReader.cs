using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class IDReader
    {
        public static Item IDtoItem(int itemID)
        {
            int itemIndex = 0;
            for (int i = 0; i < World.items.Count; i++)
            {
                if (itemID == World.items[i].ID)
                {
                    itemIndex = i;
                }
            }
            return World.items[itemIndex];
        }
        public static Potion IDtoPotion(int potionID)
        {
            int potionIndex = 0;
            for (int i = 0; i < World.potions.Count; i++)
            {
                if (potionID == World.potions[i].ID)
                {
                    potionIndex = i;
                }
            }
            return World.potions[potionIndex];
        }
        public static Treasure IDtoTreasure(int treasureID)
        {
            int treasureIndex = 0;
            for (int i = 0; i < World.treasures.Count; i++)
            {
                if (treasureID == World.treasures[i].ID)
                {
                    treasureIndex = i;
                }
            }
            return World.treasures[treasureIndex];
        }
        public static Weapon IDtoWeapon(int weaponID)
        {
            int weaponIndex = 0;
            for (int i = 0; i < World.weapons.Count; i++)
            {
                if (weaponID == World.weapons[i].ID)
                {
                    weaponIndex = i;
                }
            }
            return World.weapons[weaponIndex];
        }
        public static Mob IDtoMob(int mobID)
        {
            int mobIndex = 0;
            for (int i = 0; i < World.mobs.Count; i++)
            {
                if (mobID == World.mobs[i].ID)
                {
                    mobIndex = i;
                }
            }
            return World.mobs[mobIndex];
        }
        public static Exit IDtoExit(int exitID)
        {
            int exitIndex = 0;
            for (int i = 0; i < World.exits.Count; i++)
            {
                if (exitID == World.exits[i].ID)
                {
                    exitIndex = i;
                }
            }
            return World.exits[exitIndex];
        }
        public static Room IDtoRoom(int roomID)
        {
            int roomIndex = 0;
            for (int i = 0; i < World.rooms.Count; i++)
            {
                if (roomID == World.rooms[i].ID)
                {
                    roomIndex = i;
                }
            }
            return World.rooms[roomIndex];
        }
    }
}
