using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class MenuTreasures
    {
        public static void Show(StreamReader inputfile)
        {
            // Menu Option 4: Display Treasures

            // Treasure (Key/Unique Items) - 3
            string treasure1, treasure2, treasure3, treasure1desc, treasure2desc, treasure3desc;

            // Read from file
            while (!inputfile.EndOfStream)
            {
                // Assign Treasures (3)
                treasure1 = inputfile.ReadLine();
                treasure1desc = inputfile.ReadLine();
                treasure2 = inputfile.ReadLine();
                treasure2desc = inputfile.ReadLine();
                treasure3 = inputfile.ReadLine();
                treasure3desc = inputfile.ReadLine();

                // Print Treasures
                Console.WriteLine(treasure1);
                Console.WriteLine(treasure1desc);
                Console.WriteLine();
                Console.WriteLine(treasure2);
                Console.WriteLine(treasure2desc);
                Console.WriteLine();
                Console.WriteLine(treasure3);
                Console.WriteLine(treasure3desc);
            }
        }
    }
}
