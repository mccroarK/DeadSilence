using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Player
    {
        #region Properties
        public int ID { get; set; }                             // ID
        public string Name { get; set; }                        // Name
        public string Password { get; set; }                    // Password
        public string Race { get; set; }                        // Race
        public string Type { get; set; }                        // Type (Class but named to not conflict with class keyword)
        public int AC { get; set; }                             // Defense
        public int HP { get; set; }                             // Health
        public int ST { get; set; }                             // Stamina
        public int Power { get; set; }                          // Power (Base damage)
        public int Location { get; set; }                       // Current Room ID

        // Flags
        public bool Alive { get; set; } = true;                 // Alive
        
        // Current Properties
        public int CurrentHP { get; set; }                      // Current HP
        public int CurrentST { get; set; }                      // Current ST

        public Weapon Weapon { get; set; }                      // Weapon

        public List<Bag> Bags { get; set; } = new List<Bag>();           // Bags player can hold (Each bag holds 10 slots, Max bags is 3, but bag list is easier to work with)
        public List<Item> Pockets { get; set; }                 // Player can hold size 1 objects in each pocket (Pocket size is 2)
        public Log Log { get; set; }                            // Lists all objects
        #endregion

        #region Constructors
        public Player() { } // Default Constructor
        #endregion

        #region Methods
        public void Info()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine($"[{this.Race}]");
            Console.WriteLine($"[{this.Type}]");
            Console.WriteLine();
            Console.WriteLine($"HP:\t{CurrentHP}/{HP}");
            Console.WriteLine($"ST:\t{CurrentST}/{ST}");
            Console.WriteLine();
            this.Weapon.InfoAll();
        }
        public void MoveTo(int roomID)
        {
            if (World.currentRoom != null)
            {
                World.currentRoom.Remove(this);
            }
            // Not really necessary to have both roomID and Location, but location was needed for assignment and I did not want it to be completely useless
            this.Location = roomID;
            World.currentRoom = IDReader.IDtoRoom(Location);

            World.currentRoom.Add(this);
        }
        #region Use Methods
        public void Use(Item item)
        {
            item.Use();
        }
        public void Use(Potion potion)
        {
            potion.Use(this);
        }
        public void Use(Treasure treasure)
        {
            treasure.Use();
        }
        public void Use(Weapon weapon)
        {
            // TEMP Inspect Weapon
            weapon.Use();
            // Remove None weapon from current weapon
            // Equip weapon chosen
            // Remove weapon from bag
        }
        public void Use(Exit exit)
        {
            // Change to Action Object?
            // Use (Exit)
            if (exit != null)
            {
                exit.Use();
            }
            else
            {
                // Add funny line / fail method
            }
        }
        #endregion
        #region Drop Methods
        public void Drop(Item item, Bag bag)
        {
            // Drop Item into room
            bag.Remove(item);
            World.currentRoom.Items.Add(item);
        }
        public void Drop(Potion potion, Bag bag)
        {
            // Drop Potion into room
            bag.Remove(potion);
            World.currentRoom.Potions.Add(potion);
        }
        public void Drop(Treasure treasure, Bag bag)
        {
            // Drop Treasure into room
            bag.Remove(treasure);
            World.currentRoom.Treasures.Add(treasure);
        }
        public void Drop(Weapon weapon, Bag bag)
        {
            // Drop Weapon into room
            bag.Remove(weapon);
            World.currentRoom.Weapons.Add(weapon);
        }
        #endregion
        #region Inventory Methods
        public void Unequip()
        {
            // Cycle through bags to place weapon in
            // Equip None weapon
        }
        public void Inventory()
        {
            // Select Bag to Open
            Bag bag = Select(this.Bags);
            if (bag != null)
            {
                ChooseCategory(bag);
            }
        }
        public void ChooseCategory(Bag bag)
        {
            bool loopFinish = false;
            while (loopFinish != true)
            {
                Console.Clear();
                // Print categories
                SystemMessage.Categories();

                // Prompt user for category
                switch (Choice.Prompt())
                {
                    case "1":
                    case "item":
                    case "items":
                        Item item = Select(bag.Items);
                        if (item != null)
                        {
                            // Use or drop
                            Decide(item, bag);
                            loopFinish = true;
                        }
                        else
                        {
                            Console.ReadLine();
                        }
                        break;

                    case "2":
                    case "potion":
                    case "potions":
                        Potion potion = Select(bag.Potions);
                        if (potion != null)
                        {
                            // Use or drop
                            Decide(potion, bag);
                            loopFinish = true;
                        }
                        else
                        {
                            Console.ReadLine();
                        }
                        break;

                    case "3":
                    case "treasure":
                    case "treasures":
                        Treasure treasure = Select(bag.Treasures);
                        if (treasure != null)
                        {
                            // Use or drop
                            Decide(treasure, bag);
                            loopFinish = true;
                        }
                        else
                        {
                            Console.ReadLine();
                        }
                        break;

                    case "4":
                    case "weapon":
                    case "weapons":
                        Weapon weapon = Select(bag.Weapons);
                        if (weapon != null)
                        {
                            // Use or drop
                            Decide(weapon, bag);
                            loopFinish = true;
                        }
                        else
                        {
                            Console.ReadLine();
                        }
                        break;

                    case "5":
                    case "cancel":
                    case "close":
                    case "quit":
                        loopFinish = true;
                        break;

                    default:
                        SystemMessage.InvalidInput();
                        break;
                }
            }
        }
        #endregion
        #region Decide Methods
        void Decide(Item item, Bag bag)
        {
            bool loopFinish = false;
            while (loopFinish != true)
            {
                Console.Clear();
                // Decide what to do with Item
                SystemMessage.Decisions();
                switch (Choice.Prompt())
                {
                    case "1":
                    case "use":
                        Use(item);
                        loopFinish = true;
                        break;

                    case "2":
                    case "drop":
                        Drop(item, bag);
                        loopFinish = true;
                        break;

                    case "3":
                    case "cancel":
                    case "close":
                    case "quit":
                        loopFinish = true;
                        break;

                    default:
                        SystemMessage.InvalidInput();
                        break;
                }
            }
        }
        void Decide(Potion potion, Bag bag)
        {
            bool loopFinish = false;
            while (loopFinish != true)
            {
                Console.Clear();
                // Decide what to do with Potion
                SystemMessage.Decisions();
                switch (Choice.Prompt())
                {
                    case "1":
                    case "use":
                        Use(potion);
                        loopFinish = true;
                        break;

                    case "2":
                    case "drop":
                        Drop(potion, bag);
                        loopFinish = true;
                        break;

                    case "3":
                    case "cancel":
                    case "close":
                    case "quit":
                        loopFinish = true;
                        break;

                    default:
                        SystemMessage.InvalidInput();
                        break;
                }
            }
        }
        void Decide(Treasure treasure, Bag bag)
        {
            bool loopFinish = false;
            while (loopFinish != true)
            {
                Console.Clear();
                // Decide what to do with Potion
                SystemMessage.Decisions();
                switch (Choice.Prompt())
                {
                    case "1":
                    case "use":
                        Use(treasure);
                        loopFinish = true;
                        break;

                    case "2":
                    case "drop":
                        Drop(treasure, bag);
                        loopFinish = true;
                        break;

                    case "3":
                    case "cancel":
                    case "close":
                    case "quit":
                        loopFinish = true;
                        break;

                    default:
                        SystemMessage.InvalidInput();
                        break;
                }
            }
        }
        void Decide(Weapon weapon, Bag bag)
        {
            bool loopFinish = false;
            while (loopFinish != true)
            {
                Console.Clear();
                // Decide what to do with Potion
                SystemMessage.Decisions();
                switch (Choice.Prompt())
                {
                    case "1":
                    case "use":
                        Use(weapon);
                        loopFinish = true;
                        break;

                    case "2":
                    case "drop":
                        Drop(weapon, bag);
                        loopFinish = true;
                        break;

                    case "3":
                    case "cancel":
                    case "close":
                    case "quit":
                        loopFinish = true;
                        break;

                    default:
                        SystemMessage.InvalidInput();
                        break;
                }
            }
        }
        void Decide(Mob mob)
        {
            bool loopFinish = false;
            while (loopFinish != true)
            {
                Console.Clear();
                // Decide what to do with Mob
                SystemMessage.Premeditate();
                switch (Choice.Prompt())
                {
                    case "1":
                    case "attack":
                        // Attack mob
                        Battle.Run(this, mob);
                        loopFinish = true;
                        break;
                    case "2":
                    case "close":
                    case "cancel":
                    case "quit":
                        // Cancel move
                        loopFinish = true;
                        break;
                    default:
                        SystemMessage.InvalidInput();
                        break;
                }
            }
        }
        #endregion
        #region Select Methods
        public Item Select(List<Item> items)
        {
            if (items.Count > 0)
            {
                // Select item what item list
                bool loopFinish = false;
                int itemChoice = 0;

                // Choose item loop
                while (loopFinish != true)
                {
                    Console.Clear();
                    // Print items
                    for (int i = 0; i < items.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {items[i].Name}");
                    }
                    Console.WriteLine($"[{items.Count + 1}] Cancel");
                    Console.WriteLine();

                    // Prompt player
                    if (int.TryParse(Choice.Prompt(), out itemChoice))
                    {
                        itemChoice -= 1;
                        // If user inputs an int
                        if ((itemChoice) >= 0 && (itemChoice) <= items.Count)
                        {
                            // Valid Option
                            if ((itemChoice) == items.Count)
                            {
                                // Cancel
                                loopFinish = true;
                            }
                            else
                            {
                                // Choose item
                                return items[itemChoice];
                            }
                        }
                        else
                        {
                            // Invalid Option (int too high)
                            SystemMessage.InvalidInput();
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        // Invalid Option (string)
                        SystemMessage.InvalidInput();
                        Console.ReadLine();
                    }
                }
                // return to main
                return null;
            }
            else
            {
                // Nothing in item list
                SystemMessage.Empty();
                return null;
            }
        }
        public Potion Select(List<Potion> potions)
        {
            if (potions.Count > 0)
            {
                // Select potion what potion list
                bool loopFinish = false;
                int potionChoice = 0;

                // Choose potion loop
                while (loopFinish != true)
                {
                    Console.Clear();
                    // Print potions
                    for (int i = 0; i < potions.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {potions[i].Name}");
                    }
                    Console.WriteLine($"[{potions.Count + 1}] Cancel");
                    Console.WriteLine();

                    // Prompt player
                    if (int.TryParse(Choice.Prompt(), out potionChoice))
                    {
                        potionChoice -= 1;
                        // If user inputs an int
                        if ((potionChoice) >= 0 && (potionChoice) <= potions.Count)
                        {
                            // Valid Option
                            if ((potionChoice) == potions.Count)
                            {
                                // Cancel
                                loopFinish = true;
                            }
                            else
                            {
                                // Choose item
                                return potions[potionChoice];
                            }
                        }
                        else
                        {
                            // Invalid Option (int too high)
                            SystemMessage.InvalidInput();
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        // Invalid Option (string)
                        SystemMessage.InvalidInput();
                        Console.ReadLine();
                    }
                }
                // return to main
                return null;
            }
            else
            {
                // Nothing in potion list
                SystemMessage.Empty();
                return null;
            }
        }
        public Treasure Select(List<Treasure> treasures)
        {
            if (treasures.Count > 0)
            {
                // Select treasure what treasure list
                bool loopFinish = false;
                int treasureChoice = 0;

                // Choose treasure loop
                while (loopFinish != true)
                {
                    Console.Clear();
                    // Print treasures
                    for (int i = 0; i < treasures.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {treasures[i].Name}");
                    }
                    Console.WriteLine($"[{treasures.Count + 1}] Cancel");
                    Console.WriteLine();

                    // Prompt player
                    if (int.TryParse(Choice.Prompt(), out treasureChoice))
                    {
                        treasureChoice -= 1;
                        // If user inputs an int
                        if ((treasureChoice) >= 0 && (treasureChoice) <= treasures.Count)
                        {
                            // Valid Option
                            if ((treasureChoice) == treasures.Count)
                            {
                                // Cancel option
                                loopFinish = true;
                            }
                            else
                            {
                                // Choose treasure
                                return treasures[treasureChoice];
                            }
                        }
                        else
                        {
                            // Invalid Option (int too high)
                            SystemMessage.InvalidInput();
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        // Invalid Option (string)
                        SystemMessage.InvalidInput();
                        Console.ReadLine();
                    }
                }
                // return to main
                return null;
            }
            else
            {
                // Nothing in treasure list
                SystemMessage.Empty();
                return null;
            }
        }
        public Weapon Select(List<Weapon> weapons)
        {
            if (weapons.Count > 0)
            {
                // Select weapon what weapon list
                bool loopFinish = false;
                int weaponChoice = 0;

                // Choose weapon loop
                while (loopFinish != true)
                {
                    Console.Clear();
                    // Print weapons
                    for (int i = 0; i < weapons.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {weapons[i].Name}");
                    }
                    Console.WriteLine($"[{weapons.Count + 1}] Cancel");
                    Console.WriteLine();

                    // Prompt player
                    if (int.TryParse(Choice.Prompt(), out weaponChoice))
                    {
                        weaponChoice -= 1;
                        // If user inputs an int
                        if ((weaponChoice) >= 0 && (weaponChoice) <= weapons.Count)
                        {
                            // Valid Option
                            if ((weaponChoice) == weapons.Count)
                            {
                                // Cancel option
                                loopFinish = true;
                            }
                            else
                            {
                                // Choose weapon
                                return weapons[weaponChoice];
                            }
                        }
                        else
                        {
                            // Invalid Option (int too high)
                            SystemMessage.InvalidInput();
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        // Invalid Option (string)
                        SystemMessage.InvalidInput();
                        Console.ReadLine();
                    }
                }
                // return to main
                return null;
            }
            else
            {
                // Nothing in weapon list;
                SystemMessage.Empty();
                return null;
            }
        }
        public Bag Select(List<Bag> bags)
        {
            if (bags.Count > 0)
            {
                // Select bag from bag list
                bool loopFinish = false;
                int bagChoice = 0;

                // Choose bag loop
                while (loopFinish != true)
                {
                    Console.Clear();
                    // Print choices
                    for (int i = 0; i < bags.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] Bag {bags[i].CurrentSlots}/{bags[i].Slots}");
                    }
                    Console.WriteLine($"[{bags.Count + 1}] Cancel");
                    Console.WriteLine();

                    // Prompt player
                    if (int.TryParse(Choice.Prompt(), out bagChoice))
                    {
                        bagChoice -= 1;
                        // If user inputs an int
                        if ((bagChoice) >= 0 && (bagChoice) <= bags.Count)
                        {
                            // Valid Option
                            if ((bagChoice) == bags.Count)
                            {
                                // Cancel option
                                loopFinish = true;
                            }
                            else
                            {
                                // Choose bag
                                return bags[bagChoice];
                            }
                        }
                        else
                        {
                            // Invalid Option (int too high)
                            SystemMessage.InvalidInput();
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        // Invalid Option (string)
                        SystemMessage.InvalidInput();
                        Console.ReadLine();
                    }
                }
                // return to main
                return null;
            }
            else
            {
                // Nothing in bag list
                SystemMessage.Empty();
                return null;
            }
        }
        public Mob Select(List<Mob> mobs)
        {
            if (mobs.Count > 0)
            {
                // Select mob what mob list
                bool loopFinish = false;
                int mobChoice = 0;

                // Choose mob loop
                while (loopFinish != true)
                {
                    Console.Clear();
                    // Print mobs
                    for (int i = 0; i < mobs.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {mobs[i].Name}");
                    }
                    Console.WriteLine($"[{mobs.Count + 1}] Cancel");
                    Console.WriteLine();

                    // Prompt player
                    if (int.TryParse(Choice.Prompt(), out mobChoice))
                    {
                        mobChoice -= 1;
                        // If user inputs an int
                        if ((mobChoice) >= 0 && (mobChoice) <= mobs.Count)
                        {
                            // Valid Option
                            if ((mobChoice) == mobs.Count)
                            {
                                // Cancel
                                loopFinish = true;
                            }
                            else
                            {
                                // Choose mob
                                return mobs[mobChoice];
                            }
                        }
                        else
                        {
                            // Invalid Option (int too high)
                            SystemMessage.InvalidInput();
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        // Invalid Option (string)
                        SystemMessage.InvalidInput();
                        Console.ReadLine();
                    }
                }
                // return to main
                return null;
            }
            else
            {
                // Nothing in mob list
                SystemMessage.Empty();
                return null;
            }
        }
        #endregion
        #region Loot Methods
        public void LootRoom(Room room)
        {
            bool loopFinish = false;
            while (loopFinish != true)
            {
                Console.Clear();
                // Print Categories
                SystemMessage.Categories();

                // Prompt user for categories
                switch (Choice.Prompt())
                {
                    case "1":
                    case "item":
                    case "items":
                        Loot(room.Items, Bags);
                        loopFinish = true;
                        break;

                    case "2":
                    case "potion":
                    case "potions":
                        Loot(room.Potions, Bags);
                        loopFinish = true;
                        break;

                    case "3":
                    case "treasure":
                    case "treasures":
                        Loot(room.Treasures, Bags);
                        loopFinish = true;
                        break;

                    case "4":
                    case "weapon":
                    case "weapons":
                        Loot(room.Weapons, Bags);
                        loopFinish = true;
                        break;

                    case "5":
                    case "cancel":
                    case "close":
                    case "quit":
                        loopFinish = true;
                        break;

                    default:
                        SystemMessage.InvalidInput();
                        break;
                }
            }
        }
        public void Loot(List<Item> items, List<Bag> bags)
        {
            // Get Item
            if (items.Count > 0)
            {
                Item item = Select(items);
                if (item != null)
                {
                    // Get Bag
                    Bag bag = Select(bags);
                    if (bag != null)
                    {
                        if ((bag.CurrentSlots + item.Size) <= bag.Slots)
                        {
                            bag.Store(item);
                            items.Remove(item);
                        }
                    }
                }
            }
            else
            {
                SystemMessage.Empty();
            }
        }
        public void Loot (List<Potion> potions, List<Bag> bags)
        {
            // Get Potion
            if (potions.Count > 0)
            {
                Potion potion = this.Select(potions);
                if (potion != null)
                {
                    // Get Bag
                    Bag bag = this.Select(bags);
                    if (bag != null)
                    {
                        if ((bag.CurrentSlots + potion.Size) <= bag.Slots)
                        {
                            bag.Store(potion);
                        }
                    }
                }
            }
            else
            {
                SystemMessage.Empty();
            }
        }
        public void Loot(List<Treasure> treasures, List<Bag> bags)
        {
            // Get Treasure
            if (treasures.Count > 0)
            {
                Treasure treasure = Select(treasures);
                if (treasure != null)
                {
                    // Get Bag
                    Bag bag = Select(bags);
                    if (bag != null)
                    {
                        if ((bag.CurrentSlots + treasure.Size) <= bag.Slots)
                        {
                            bag.Store(treasure);
                        }
                    }
                }
            }
            else
            {
                SystemMessage.Empty();
            }
        }
        public void Loot(List<Weapon> weapons, List<Bag> bags)
        {
            // Get Treasure
            if (weapons.Count > 0)
            {
                Weapon weapon = Select(weapons);
                if (weapon != null)
                {
                    // Get Bag
                    Bag bag = Select(bags);
                    if (bag != null)
                    {
                        if ((bag.CurrentSlots + weapon.Size) <= bag.Slots)
                        {
                            bag.Store(weapon);
                        }
                    }
                }
            }
            else
            {
                SystemMessage.Empty();
            }
        }
        #endregion
        #region Combat Methods
        public void FindMobs(Room room)
        {
            Mob target = Select(room.Mobs);
            if (target != null)
            {
                Console.Clear();
                if (target.Alive)
                {
                    Decide(target);
                }
                else
                {
                    Console.WriteLine("It's already dead. I shouldn't bother.");
                }
            }
        }
        public void HealHP(int health)
        {
            CurrentHP += health;
            CheckHP();
        }
        void CheckHP()
        {
            // If HP above max
            if (this.CurrentHP > this.HP)
            {
                this.CurrentHP = this.HP;
            }
            // If HP below 0
            if (this.CurrentHP < 0)
            {
                this.CurrentHP = 0;
                this.Die();
            }
        }
        public void HealST(int stamina)
        {
            CurrentST += stamina;
            CheckST();
        }
        void CheckST()
        {
            // If ST above max
            if (this.CurrentST > this.ST)
            {
                this.CurrentST = this.ST;
            }
            // If ST below 0
            if (this.CurrentST < 0)
            {
                this.CurrentST = 0;
            }

        }
        public void TakeDamage(int damage)
        {
            damage -= (int)(.1 * this.AC);
            if (damage < 0)
            {
                damage = 0;
            }
            this.CurrentHP -= damage;
            CheckHP();
        }
        public void Attack(Mob target)
        {
            // Get damage number
            int damage = this.CalcDamage();
            // Print message
            Console.WriteLine($"You deal {damage} damage to {target.Name}");
            // Attack mob
            target.TakeDamage(damage);
            // Special chance
            if (this.Weapon.AfflictCheck())
            {
                Afflict(target);
            }
        }
        public int CalcDamage()
        {
            return this.Power + this.Weapon.Damage;
        }
        public void Afflict(Mob target)
        {
            // Afflict target with status effect
            switch (this.Weapon.DamageType)
            {
                case "Incision":
                    // Bleed (-CurrentHP over time)
                    break;
                case "Blunt":
                    // Cripple (-Power, -HP)
                    target.Cripple();
                    break;
                case "Puncture":
                    // Deep Bleed (-HP, -CurrentHP over time)
                default:
                    // No damage type = no status affect
                    break;
            }
        }
        public void Cripple()
        {
            // Decrease Stats
            this.Power *= 3 / 4;
            this.HP *= 7 / 8;
            CheckHP();
            // Print message
            Console.WriteLine($"{this.Name} is crippled.");
        }
        public void Die()
        {
            // Print string
            Console.WriteLine($"{this.Name} is dead.");
        }
        #endregion
        #endregion
    }
}
