using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Treasure
    {
        #region Properties
        public int ID { get; }                      // ID
        public string Name { get; }                 // Name
        public string Description { get; }          // Description
        public bool KeyItem { get; }                // Key Item / Quest Item (Item that can be used in a questline)
        public string Appeal { get; }               // Appeal (modifier for trading) [Antique, Extravagant, Practical]
        public int Value { get; }                   // Value
        public int Size { get; }                    // Size
        #endregion

        #region Constructors
        public Treasure() { } // Default constructor
        public Treasure(int id, string name, string description, bool keyitem, string appeal, int value, int size)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.KeyItem = keyitem;
            this.Appeal = appeal;
            this.Value = value;
            this.Size = size;
        }
        public Treasure(Treasure basis) // Clone
        {
            this.ID = basis.ID;
            this.Name = basis.Name;
            this.Description = basis.Description;
            this.KeyItem = basis.KeyItem;
            this.Appeal = basis.Appeal;
            this.Value = basis.Value;
            this.Size = basis.Size;
        }
        #endregion

        #region Methods
        public void Info() // Show minimal Info
        {
            // Name and Description
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Description);
            Console.WriteLine();
        }
        public void InfoAll() // Show all Info (not really all but a lot)
        {
            // Name and Description
            Console.WriteLine(this.ID);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Description);
            Console.WriteLine(this.Appeal);
            Console.WriteLine($"Size: {this.Size}");
            Console.WriteLine();
        }
        public void Use()
        {
            // Inspect
            InfoAll();
        }
        #endregion
    }
}
