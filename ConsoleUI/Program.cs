using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* Date
* CSC 153
* Name
* Program description
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Display Rooms");
            Console.WriteLine("[2] Display Weapons");
            Console.WriteLine("[3] Display Potions");
            Console.WriteLine("[4] Display Treasure");
            Console.WriteLine("[5] Display Items");
            Console.WriteLine("[6] Display Mobs");
            Console.WriteLine("[7] Exit");

            Console.Write(">> ");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "room":
                case "rooms":
                    break;
                case "2":
                case "weapon":
                case "weapons":
                    break;
                case "3":
                case "potion":
                case "potions":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                case "mobs":
                    break;
                case "7":
                case "exit":
                    break;
                default:
                    Console.WriteLine("Answer out of range");
                    break;
            }

            Console.ReadLine();
        }
    }
}
