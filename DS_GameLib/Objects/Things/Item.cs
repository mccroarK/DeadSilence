using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Item
    {
        #region Properties
        public int ID { get; }                      // ID
        public string Name { get; }                 // Name
        public string Description { get; }          // Description
        public bool KeyItem { get; }                // Key Item / Quest Item (Item that can be used in a questline)
        public int Uses { get; set; }               // Amount of times an item can be used
        public int Value { get; }                   // Value
        public int Size { get; }                    // Size
        #endregion

        #region Constructors
        public Item() { } // Default constructor
        public Item(int id, string name, string description, bool keyitem, int uses, int value, int size)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.KeyItem = KeyItem;
            this.Uses = Uses;
            this.Value = value;
            this.Size = size;
        }
        public Item(Item basis) // Clone
        {
            this.ID = basis.ID;
            this.Name = basis.Name;
            this.Description = basis.Description;
            this.KeyItem = basis.KeyItem;
            this.Uses = basis.Uses;
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
            Console.WriteLine($"Size: {this.Size}");
            Console.WriteLine();
        }
        #endregion
        public void Use()
        {
            // Inspect Item
            Console.Clear();
            InfoAll();
        }
    }
}
