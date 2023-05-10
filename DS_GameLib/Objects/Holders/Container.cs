using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Container
    {
        #region Properties
        public string Name { get; }                     // Name
        public string Type { get; }                     // Racks / Shelves can't barricade, Drawers / Chests can't barricade windows, Fridges / Wardrobes can barricade all
        public int HP { get; set; }                     // Barricade Health

        public List<Item> Items { get; set; }           // Items list
        public List<Potion> Potions { get; set; }       // Potions list
        public List<Treasure> Treasures { get; set; }   // Treasures list
        public List<Weapon> Weapons { get; set; }       // Weapons List
        #endregion

        #region Constructors
        public Container() { } // Default constructor
        public Container(string name, string type, int hp)
        {
            this.Name = name;
            this.Type = type;
            this.HP = hp;
        }
        #endregion
    }
}
