using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class LoadFile
    {
        public static StreamReader inputfile;
        public static void Run ()
        {
            Rooms();
            Weapons();
            Potions();
            Treasures();
            Items();
            Mobs();
        }

        public static void Close()
        {
            inputfile.Close();
        }

        public static void Rooms()
        {
            int i = 0;
            inputfile = File.OpenText(@"..\..\txt\rooms.txt");
            while (!inputfile.EndOfStream && i < World.rooms.Length)
            {
                // Assign Rooms (5)
                World.rooms[i] = inputfile.ReadLine();
                World.roomdescs[i] = inputfile.ReadLine();
                i++;
            }
        }

        public static void Weapons()
        {
            int i = 0;
            inputfile = File.OpenText(@"..\..\txt\weapons.txt");
            while (!inputfile.EndOfStream && i < World.weapons.Length)
            {
                // Assign Weapons (4)
                World.weapons[i] = inputfile.ReadLine();
                World.weapondescs[i] = inputfile.ReadLine();
                i++;
            }
        }

        public static void Potions()
        {
            int i = 0;
            inputfile = File.OpenText(@"..\..\txt\potions.txt");
            while (!inputfile.EndOfStream && i < World.potions.Length)
            {
                // Assign Potions (2)
                World.potions[i] = inputfile.ReadLine();
                World.potiondescs[i] = inputfile.ReadLine();
                i++;
            }
        }

        public static void Treasures()
        {
            int i = 0;
            inputfile = File.OpenText(@"..\..\txt\treasures.txt");
            while (!inputfile.EndOfStream && i < World.treasures.Length)
            {
                // Assign Treasures (3)
                World.treasures[i] = inputfile.ReadLine();
                World.treasuredescs[i] = inputfile.ReadLine();
                i++;
            }
        }

        public static void Items()
        {
            inputfile = File.OpenText(@"..\..\txt\items.txt");
            while (!inputfile.EndOfStream)
            {
                // Assign Items (4)
                World.items.Add(inputfile.ReadLine());
                World.itemdescs.Add(inputfile.ReadLine());
            }
        }

        public static void Mobs()
        {
            inputfile = File.OpenText(@"..\..\txt\mobs.txt");
            while (!inputfile.EndOfStream)
            {
                // Assign Mobs (5)
                World.mobs.Add(inputfile.ReadLine());
                World.mobdescs.Add(inputfile.ReadLine());
            }
        }
    }
}
