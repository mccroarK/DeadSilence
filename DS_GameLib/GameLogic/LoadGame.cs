using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class LoadGame
    {
        public static void RunLoad()
        {
            // Load things
            LoadItems();
            LoadPotions();
            LoadTreasures();
            LoadWeapons();

            // Load actors
            LoadMobs();
            LoadPlayer();

            // Load containers
            LoadExits();

            // Load rooms
            LoadRooms();
        }

        static void LoadItems()
        {
            // Load items into Item List
            int index = 0;

            using (StreamReader reader = File.OpenText(@"..\..\..\DS_GameLib\Docs\Items.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (index != 0)
                    {
                        World.items.Add(new Item(int.Parse(tokens[0]), tokens[1], tokens[2], bool.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6])));
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }

        static void LoadPotions()
        {
            // Load potions into Potion List
            int index = 0;

            using (StreamReader reader = File.OpenText(@"..\..\..\DS_GameLib\Docs\Potions.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (index != 0)
                    {
                        World.potions.Add(new Potion(int.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6])));
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }

        static void LoadTreasures()
        {
            // Load treasure into Treasure List
            int index = 0;

            using (StreamReader reader = File.OpenText(@"..\..\..\DS_GameLib\Docs\Treasures.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (index != 0)
                    {
                        World.treasures.Add(new Treasure(int.Parse(tokens[0]), tokens[1], tokens[2], bool.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]), int.Parse(tokens[6])));
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }

        static void LoadWeapons()
        {
            // Load weapons into Weapon List
            int index = 0;

            using (StreamReader reader = File.OpenText(@"..\..\..\DS_GameLib\Docs\Weapons.csv")) // Have to include file in project. Drag it into a folder and hit Show All Files, find the file and right click, then choose Add in Project
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (index != 0)
                    {
                        World.weapons.Add(new Weapon(int.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6]), tokens[7], tokens[8], int.Parse(tokens[9]), int.Parse(tokens[10])));
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }

        static void LoadExits()
        {
            // Load exits into Exits List
            int index = 0;

            using (StreamReader reader = File.OpenText(@"..\..\..\DS_GameLib\Docs\Exits.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (index != 0)
                    {
                        World.exits.Add(new Exit(int.Parse(tokens[0]), ToStringArray(tokens[1]), ToIntArray(tokens[2])));
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }

        static void LoadRooms()
        {
            // Load rooms into Room List
            int index = 0;

            using (StreamReader reader = File.OpenText(@"..\..\..\DS_GameLib\Docs\Rooms.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (index != 0)
                    {
                        Room room = new Room(int.Parse(tokens[0]), tokens[1], tokens[2], ToIntArray(tokens[3]));
                        // Add Items
                        if (tokens[4] != "") // If items are in list
                        {
                            int[] itemIDs = ToIntArray(tokens[4]); // Split item list into ID list
                            foreach(int id in itemIDs)
                            {
                                room.Items.Add(new Item(IDReader.IDtoItem(id))); // Add item clone into Item List
                            }
                        }
                        // Add Potions
                        if (tokens[5] != "") // If potions are in list
                        {
                            int[] potionIDs = ToIntArray(tokens[5]); // Split potion list into ID list
                            foreach (int id in potionIDs)
                            {
                                room.Potions.Add(new Potion(IDReader.IDtoPotion(id))); // Add potion clone into Potion List
                            }
                        }
                        // Add Treasures
                        if (tokens[6] != "") // If treasures are in list
                        {
                            int[] treasureIDs = ToIntArray(tokens[6]); // Split treasure list into ID list
                            foreach (int id in treasureIDs)
                            {
                                room.Treasures.Add(new Treasure(IDReader.IDtoTreasure(id))); // Add treasure clone into Treasure List
                            }
                        }
                        // Add Weapons
                        if (tokens[7] != "") // If weapons are in list
                        {
                            int[] weaponIDs = ToIntArray(tokens[7]); // Split weapons list into ID list
                            foreach (int id in weaponIDs)
                            {
                                room.Weapons.Add(new Weapon(IDReader.IDtoWeapon(id))); // Add weapon clone into Weapon List
                            }
                        }
                        // Add Mobs
                        if (tokens[8] != "")
                        {
                            int[] mobIDs = ToIntArray(tokens[8]); // Split mobs list into ID list
                            foreach (int id in mobIDs)
                            {
                                room.Mobs.Add(new Mob(IDReader.IDtoMob(id))); // Add mob clone into Mob List
                            }
                        }
                        World.rooms.Add(room);
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }

        static void LoadPlayer()
        {
            // Load player into Player slot
            int index = 0;

            using (StreamReader reader = File.OpenText(@"..\..\..\DS_GameLib\Docs\Players.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (index != 0)
                    {
                        // Create player
                        World.player = new Player();

                        // Player stats
                        World.player.ID = int.Parse(tokens[0]);
                        World.player.Name = tokens[1];
                        World.player.Password = tokens[2];
                        World.player.Race = tokens[3];
                        World.player.Type = tokens[4];
                        World.player.AC = int.Parse(tokens[5]);
                        World.player.HP = int.Parse(tokens[6]);
                        World.player.ST = int.Parse(tokens[7]);
                        World.player.Power = int.Parse(tokens[8]);
                        World.player.Location = int.Parse(tokens[9]);
                        World.player.Weapon = new Weapon(IDReader.IDtoWeapon(int.Parse(tokens[10])));
                        // Current Stats
                        World.player.CurrentHP = World.player.HP;
                        World.player.CurrentST = World.player.ST;
                        // Additional
                        // Bool if player starts with log
                        //World.player.Log = new Log();
                        // Bool if player starts with bag
                        World.player.Bags.Add(new Bag());
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }


        static void LoadMobs()
        {
            // Load mobs into Mob List
            int index = 0;

            using (StreamReader reader = File.OpenText(@"..\..\..\DS_GameLib\Docs\Mobs.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (index != 0)
                    {
                        // Create Mob
                        World.mobs.Add(new Mob(int.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], int.Parse(tokens[6]), int.Parse(tokens[7]), int.Parse(tokens[8]), int.Parse(tokens[9])));
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }

        #region Helper Functions
        static string[] ToStringArray(string arrayString)
        {
            // For sub arrays
            return arrayString.Split('|');
        }

        static int[] ToIntArray(string arrayString)
        {
            // for sub arrays
            string[] dummyArray = arrayString.Split('|');
            int[] intArray = new int[dummyArray.Length];

            for (int i = 0; i < dummyArray.Length; i++)
            {
                if (dummyArray[i] != "null")
                {
                    intArray[i] = int.Parse(dummyArray[i]);
                }
                else
                {
                    intArray[i] = -1;
                }
            }

            return intArray;
        }
        #endregion
    }
}
