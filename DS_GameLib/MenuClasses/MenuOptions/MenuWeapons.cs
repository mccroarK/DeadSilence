using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class MenuWeapons
    {
        public static void Show(StreamReader inputfile)
        {
            // Menu Option 2: Display Weapons

            // Weapons - 4
            string weapon1, weapon2, weapon3, weapon4, weapon1desc, weapon2desc, weapon3desc, weapon4desc;

            // Read from file
            while (!inputfile.EndOfStream)
            {
                // Assign Rooms (4)
                weapon1 = inputfile.ReadLine();
                weapon1desc = inputfile.ReadLine();
                weapon2 = inputfile.ReadLine();
                weapon2desc = inputfile.ReadLine();
                weapon3 = inputfile.ReadLine();
                weapon3desc = inputfile.ReadLine();
                weapon4 = inputfile.ReadLine();
                weapon4desc = inputfile.ReadLine();

                // Print Rooms
                Console.WriteLine(weapon1);
                Console.WriteLine(weapon1desc);
                Console.WriteLine();
                Console.WriteLine(weapon2);
                Console.WriteLine(weapon2desc);
                Console.WriteLine();
                Console.WriteLine(weapon3);
                Console.WriteLine(weapon3desc);
                Console.WriteLine();
                Console.WriteLine(weapon4);
                Console.WriteLine(weapon4desc);
            }
        }
    }
}
