using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Weapon
    {
        #region Properties
        public int ID { get; }                      // ID
        public string Name { get; }                 // Name
        public string Description { get; }          // Description
        public string Appeal { get; set; }          // Appeal (modifier for trading) [Antique, Extravagant, Practical, None]
        public int HP { get; set; }                 // Weapon Durability (works as current HP as well)
        public int Speed { get; set; }              // Speed (Used for enemy reaction time)
        public int Damage { get; set; }             // Damage
        public string DamageType { get; }           // Damage Type (Incision / Cutting) (Puncture) (Blunt)
        public string AfflictRoll { get; }          // Status affliction chance (has to be highest number) (Cripple, Bleed, etc)
        public int Value { get; }                   // Value / Price for trading. Value can vary between NPCs if they value an item type more or less (Items, Weapons, Potions). If value of item is higher to NPC than the item you want, NPC will trade.
        public int Size { get; }                    // Amount of slots it takes in a bag
        #endregion

        #region Constructors
        public Weapon() { } // Default constructor
        public Weapon(int id, string name, string description, string appeal, int hp, int speed,  int damage, string damagetype, string afflictRoll, int value, int size)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Appeal = appeal;
            this.HP = hp;
            this.Speed = speed;
            this.Damage = damage;
            this.DamageType = damagetype;
            this.AfflictRoll = afflictRoll;
            this.Value = value;
            this.Size = size;
        }
        public Weapon(Weapon basis) // Clone
        {
            this.ID = basis.ID;
            this.Name = basis.Name;
            this.Description = basis.Description;
            this.Appeal = basis.Appeal;
            this.HP = basis.HP;
            this.Speed = basis.Speed;
            this.Damage = basis.Damage;
            this.DamageType = basis.DamageType;
            this.AfflictRoll = basis.AfflictRoll;
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
            Console.WriteLine(this.Appeal);
            Console.WriteLine($"HP: {this.HP}");
            Console.WriteLine($"Size: {this.Size}");
            Console.WriteLine();
        }
        public bool AfflictCheck()
        {
            // If damage type can inflict status effect
            if (this.DamageType != "None")
            {
                // If roll is highest possible outcome
                if ((RandomDie.Roll(this.AfflictRoll)) == int.Parse((this.AfflictRoll.Split('D'))[1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
