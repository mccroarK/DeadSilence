using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Mob
    {
        #region Properties
        public int ID { get; }                      // ID
        public string Name { get; set; }            // Name
        public string Description1 { get; }         // Description 1 (Overworld Description)
        public string Description2 { get; }         // Description 2 (Journal Description)
        public string Race { get; }                 // Race
        public string Type { get; }                 // Class (Named type so lowercase does not disrupt class function)
        public int HP { get; set; }                 // Health
        public int AC { get; set; }                 // Defense
        public int Power { get; set; }              // Power
        public Weapon Weapon { get; set; }          // Weapon
        public int CurrentHP { get; set; }          // Current HP

        // Flags
        public bool Alive { get; set; } = true;     // Alive
        #endregion

        #region Constructors
        public Mob() { } // Default constructor

        public Mob(int id, string name, string description1, string description2, string race, string type, int ac, int hp, int power, int weaponID)
        {
            // Info
            this.ID = id;
            this.Name = name;
            this.Description1 = description1; // Scan string
            this.Description2 = description2; // Dead/Observe string
            this.Race = race;
            this.Type = type;
            this.AC = ac;
            this.HP = hp;
            this.Power = power;
            this.Weapon = new Weapon(IDReader.IDtoWeapon(weaponID));

            // Current Info
            CurrentHP = this.HP;
        }
        public Mob(Mob basis) // Clone
        {
            // Info
            this.ID = basis.ID;
            this.Name = basis.Name;
            this.Description1 = basis.Description1; // Scan string
            this.Description2 = basis.Description2; // Dead/Observe string
            this.Race = basis.Race;
            this.Type = basis.Type;
            this.AC = basis.AC;
            this.HP = basis.HP;
            this.Power = basis.Power;
            this.Weapon = new Weapon(basis.Weapon);

            // Current Info
            CurrentHP = this.HP;
        }
        #endregion

        #region Methods
        public void Info() // Show minimal stats
        {
            // Name and Description
            Console.WriteLine(Name);
            Console.WriteLine(Description1);
            Console.WriteLine();
            this.Weapon.Info();
        }

        public void InfoAll() // Show all stats (not really all but a lot)
        {
            // Name and Description
            Console.WriteLine(Name);
            Console.WriteLine(Description2);
        }

        public void Equip(Weapon weapon)
        {
            Weapon = weapon;
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
        public void Attack(Player target)
        {
            // Get damage number
            int damage = this.CalcDamage();
            // Print message
            Console.WriteLine($"{this.Name} deals {damage} damage to you.");
            // Attack player
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
        public void Afflict(Player target)
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
            this.Power *= 3/4;
            this.HP *= 7/8;
            CheckHP();
            // Print message
            Console.WriteLine($"{this.Name} is crippled.");
        }
        public void Die()
        {
            // Change flag
            this.Alive = false;
            // Print string
            Console.WriteLine($"{this.Name} is dead.");
        }
        #endregion
    }
}
