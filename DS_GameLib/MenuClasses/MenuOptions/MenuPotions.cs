using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class MenuPotions
    {
        public static void Show(StreamReader inputfile)
        {
            // Menu Option 3: Display Potions

            // Potions - 2
            string potion1, potion2, potion1desc, potion2desc;

            // Read from file
            while (!inputfile.EndOfStream)
            {
                // Assign Potions (2)
                potion1 = inputfile.ReadLine();
                potion1desc = inputfile.ReadLine();
                potion2 = inputfile.ReadLine();
                potion2desc = inputfile.ReadLine();

                // Print Potions
                Console.WriteLine(potion1);
                Console.WriteLine(potion1desc);
                Console.WriteLine();
                Console.WriteLine(potion2);
                Console.WriteLine(potion2desc);
            }
        }
    }
}
