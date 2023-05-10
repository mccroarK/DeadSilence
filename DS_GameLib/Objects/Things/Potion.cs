using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Potion
    {
        #region Properties
        public int ID { get; }                      // ID
        public string Name { get; }                 // Name
        public string Description { get; }          // Description
        public string StatAffected { get; }         // Stat to affect
        public int StatChange { get; set; }         // Change to stat on ingested
        public int Value { get; set; }                   // Value
        public int Size { get; }                    // Size
        #endregion

        #region Constructors
        public Potion() { } // Default constructor
        public Potion(int id, string name, string description, string stataffected, int statchange, int value, int size) 
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.StatAffected = stataffected;
            this.StatChange = statchange;
            this.Value = value;
            this.Size = size;
        }
        public Potion (Potion basis) // Clone
        {
            this.ID = basis.ID;
            this.Name = basis.Name;
            this.Description = basis.Description;
            this.StatAffected = basis.StatAffected;
            this.StatChange = basis.StatChange;
            this.Value = basis.Value;
            this.Size = basis.Size;
        }
        #endregion

        #region Methods
        public void Info() // Show minimal stats
        {
            // Name and Description
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Description);
            Console.WriteLine();
        }
        public void InfoAll() // Show all stats (not really all but a lot)
        {
            // Name and Description
            Console.WriteLine(this.ID);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Description);
            Console.WriteLine($"{this.StatChange} {this.StatAffected}");
            Console.WriteLine($"Size: {this.Size}");
            Console.WriteLine();
        }

        public void Use(Player player)
        {
            switch (StatAffected)
            {
                case "Health":
                    player.HealHP(StatChange);
                    break;
                case "Stamina":
                    player.HealST(StatChange);
                    break;
            }
            // Empty
            this.StatChange = 0;
            this.Value = 0;
        }
        #endregion
    }
}
