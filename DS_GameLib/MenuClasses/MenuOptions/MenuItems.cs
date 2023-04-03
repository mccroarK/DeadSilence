using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class MenuItems
    {
        public static void Show(StreamReader inputfile)
        {
            // Menu Option 5: Display Items

            // Items - 4
            string item1, item2, item3, item4, item1desc, item2desc, item3desc, item4desc;

            // Open and Close file
            using (inputfile = File.OpenText(@"../../txt/items.txt"))
            {
                // Read from file
                while (!inputfile.EndOfStream)
                {
                    // Assign Items (4)
                    item1 = inputfile.ReadLine();
                    item1desc = inputfile.ReadLine();
                    item2 = inputfile.ReadLine();
                    item2desc = inputfile.ReadLine();
                    item3 = inputfile.ReadLine();
                    item3desc = inputfile.ReadLine();
                    item4 = inputfile.ReadLine();
                    item4desc = inputfile.ReadLine();

                    // Print Items
                    Console.WriteLine(item1);
                    Console.WriteLine(item1desc);
                    Console.WriteLine();
                    Console.WriteLine(item2);
                    Console.WriteLine(item2desc);
                    Console.WriteLine();
                    Console.WriteLine(item3);
                    Console.WriteLine(item3desc);
                    Console.WriteLine();
                    Console.WriteLine(item4);
                    Console.WriteLine(item4desc);
                }
            }
        }
    }
}
