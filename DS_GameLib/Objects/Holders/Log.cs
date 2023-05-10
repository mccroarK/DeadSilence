using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Log
    {
        #region Properties
        public List<Item> Items { get; set; }
        public List<Potion> Potions { get; set; }
        public List<Treasure> Treasures { get; set; }
        public List<Weapon> Weapons { get; set; }
        #endregion

        #region Constructors
        public Log() { }
        #endregion

        #region Methods
        public void ShowItems()
        {
            // Display known items
            foreach (Item item in this.Items)
            {
                item.InfoAll();
            }
        }

        public void ShowPotions()
        {
            // Display known potions
            foreach (Potion potion in this.Potions)
            {
                potion.InfoAll();
            }
        }

        public void ShowTreasures()
        {
            // Display known treasures
            foreach (Treasure treasure in this.Treasures)
            {
                treasure.InfoAll();
            }
        }

        public void ShowWeapons()
        {
            // Display known weapons
            foreach (Weapon weapon in this.Weapons)
            {
                weapon.InfoAll();
            }
        }
        #endregion
    }
}
