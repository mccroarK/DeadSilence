using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class MenuOption
    {
        public static void Show(int menuOption)
        {
            // Funtion to make it easier to change file names
            // Could make switching menu order harder so might be counterproductive
            // Maybe make file names into list and use index?

            string filename;

            switch (menuOption)
            {
                case 1:
                    filename = "rooms.txt";
                    break;
                case 2:
                    filename = "weapons.txt";
                    break;
                case 3:
                    filename = "potions.txt";
                    break;
                case 4:
                    filename = "treasures.txt";
                    break;
                case 5:
                    filename = "items.txt";
                    break;
                case 6:
                    filename = "mobs.txt";
                    break;
                default:
                    filename = null;
                    Console.WriteLine("No such option");
                    break;
            }

            if (filename != null)
            {
                StreamReader file;
                file = LoadFile.Get(filename);

                switch (menuOption)
                {
                    case 1:
                        MenuRooms.Show(file);
                        break;
                    case 2:
                        MenuWeapons.Show(file);
                        break;
                    case 3:
                        MenuPotions.Show(file);
                        break;
                    case 4:
                        MenuTreasures.Show(file);
                        break;
                    case 5:
                        MenuItems.Show(file);
                        break;
                    case 6:
                        MenuMobs.Show(file);
                        break;
                    default:
                        Console.WriteLine("No such function");
                        break;
                }
                file.Close();
            }
        }
    }
}
