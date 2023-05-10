using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Bag
    {
        #region Properties
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Potion> Potions { get; set; } = new List<Potion>();
        public List<Treasure> Treasures { get; set; } = new List<Treasure>();
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        public int Slots { get; } = 10;
        public int CurrentSlots { get; set; } = 0;
        #endregion

        #region Constructors
        public Bag() { }
        #endregion

        #region Methods
        public void Store(Item item)
        {
            // Store item into bag
            Items.Add(item);
        }

        public void Store(Potion potion)
        {
            // Store potion into bag
            Potions.Add(potion);
        }

        public void Store(Treasure treasure)
        {
            // Store treasure into bag
            Treasures.Add(treasure);
        }

        public void Store(Weapon weapon)
        {
            // Store weapon into bag
            Weapons.Add(weapon);
        }

        public void Show(string userInput)
        {
            // String to make it easier to know which case is which
            switch (userInput)
            {
                case "items":
                    if (this.Items.Count > 0)
                    {
                        foreach (Item item in this.Items)
                        {
                            item.Info();
                        }
                    }
                    else
                    {
                        // No items in this bag
                        SystemMessage.Empty();
                    }
                    break;

                case "potions":
                    if (this.Potions.Count > 0)
                    {
                        foreach (Potion potion in this.Potions)
                        {
                            potion.Info();
                        }
                    }
                    else
                    {
                        // No food in this bag
                        SystemMessage.Empty();
                    }
                    break;

                case "treasures":
                    if (this.Treasures.Count > 0)
                    {
                        foreach (Treasure treasure in this.Treasures)
                        {
                            treasure.Info();
                        }
                    }
                    else
                    {
                        // No treasures in this bag
                        SystemMessage.Empty();
                    }
                    break;

                case "weapons":
                    if (this.Weapons.Count > 0)
                    {
                        foreach (Weapon weapon in this.Weapons)
                        {
                            weapon.Info();
                        }
                    }
                    else
                    {
                        // No weapons in this bag
                        SystemMessage.Empty();
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
