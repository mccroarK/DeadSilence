using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class World
    {
        public static string[] rooms = new string[5];
        public static string[] roomdescs = new string[5];

        public static string[] weapons = new string[4];
        public static string[] weapondescs = new string[4];

        public static string[] potions = new string[2];
        public static string[] potiondescs = new string[2];

        public static string[] treasures = new string[3];
        public static string[] treasuredescs = new string[3];

        public static List<string> items = new List<string>();
        public static List<string> itemdescs = new List<string>();

        public static List<string> mobs = new List<string>();
        public static List<string> mobdescs = new List<string>();

        public static int currentRoom = 0; // Could make current X,Y? But that would mean moving down and right
    }
}
