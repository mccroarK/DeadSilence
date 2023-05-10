using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Room
    {
        #region Properties
        public int ID { get; }                          // ID
        public string Name { get; }                     // Name
        public string Text { get; }                     // Room Description
        public int[] ExitIDs { get; }                   // Exit IDs
        //public int[] ContainerIDs { get; }              // Container IDs // Drawers, chests, wardrobes, racks, shelves, fridges

        public List<Item> Items { get; set; } = new List<Item>();               // Items list
        public List<Potion> Potions { get; set; } = new List<Potion>();         // Potions list
        public List<Treasure> Treasures { get; set; } = new List<Treasure>();   // Treasures list
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();         // Weapons List
        public List<Mob> Mobs { get; set; } = new List<Mob>();                  // Mobs list
        public List<Player> Players { get; set; } = new List<Player>();         // Players list
        #endregion

        #region Constructors
        public Room() { } // Default constructor
        public Room(int id, string name, string text, int[] exitIDs)
        {
            this.ID = id;
            this.Name = name;
            this.Text = text;
            this.ExitIDs = exitIDs;
        }
        #endregion

        #region Methods
        public void Info() // Show minimal stats
        {
            // Name and Description
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Text);
            Console.WriteLine();
        }

        public void ShowExits()
        {
            // Show all exits if exist
            foreach (int ID in this.ExitIDs)
            {
                // ID to Exit
                if (ID != -1)
                {
                    IDReader.IDtoExit(ID).Info();
                }
            }
        }

        public void Show(string userInput)
        {
            // String to make it easier to know which case is which
            switch (userInput)
            {
                case "players":
                    if(this.Players.Count > 0)
                    {
                        foreach (Player player in this.Players)
                        {
                            player.Info();
                        }
                    }
                    else
                    {
                        SystemMessage.Empty(); // This message shouldn't appear if everything works right
                    }
                    break;

                case "mobs":
                    if (this.Mobs.Count > 0)
                    {
                        foreach (Mob mob in this.Mobs)
                        {
                            if (mob.Alive)
                            {
                                mob.Info();
                            }
                            else
                            {
                                mob.InfoAll();
                            }
                        }
                    }
                    else
                    {
                        SystemMessage.Empty(); // The room is empty message
                    }
                    break;
            }
        }

        public void Add(Mob mob)
        {
            // Add mob to room
            Mobs.Add(mob);
        }

        public void Add(Player player)
        {
            // Add player to room
            Players.Add(player);
        }

        public void Remove(Mob mob)
        {
            // Remove mob from room
            Mobs.Remove(mob);
        }

        public void Remove(Player player)
        {
            // Remove player from room
            Players.Remove(player);
        }
        #endregion
    }
}
