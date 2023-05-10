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
        #region Store Methods
        public void Store(Item item)
        {
            // Store item into bag
            Items.Add(item);
            UpdateSlots();
        }

        public void Store(Potion potion)
        {
            // Store potion into bag
            Potions.Add(potion);
            UpdateSlots();
        }

        public void Store(Treasure treasure)
        {
            // Store treasure into bag
            Treasures.Add(treasure);
            UpdateSlots();
        }

        public void Store(Weapon weapon)
        {
            // Store weapon into bag
            Weapons.Add(weapon);
            UpdateSlots();
        }
        #endregion
        #region Remove Methods
        public void Remove(Item item)
        {
            // Remove item from bag
            Items.Remove(item);
            UpdateSlots();
        }

        public void Remove(Potion potion)
        {
            // Remove potion from bag
            Potions.Remove(potion);
            UpdateSlots();
        }

        public void Remove(Treasure treasure)
        {
            // Remove treasure from bag
            Treasures.Remove(treasure);
            UpdateSlots();
        }

        public void Remove(Weapon weapon)
        {
            // Remove weapon from bag
            Weapons.Remove(weapon);
            UpdateSlots();
        }
        #endregion

        public void UpdateSlots()
        {
            this.CurrentSlots = 0;
            // Check item sizes
            foreach (Item item in this.Items)
            {
                this.CurrentSlots += item.Size;
            }
            // Check potion sizes
            foreach (Potion potion in this.Potions)
            {
                this.CurrentSlots += potion.Size;
            }
            // Check treasure sizes
            foreach (Treasure treasure in this.Treasures)
            {
                this.CurrentSlots += treasure.Size;
            }
            // Check weapon sizes
            foreach (Weapon weapon in this.Weapons)
            {
                this.CurrentSlots += weapon.Size;
            }
        }

        public void Show(string userInput)
        {
            // String to make it easier to know which case is which
            Console.Clear();
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
