using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DS_GameLib
{
    public static class MenuMobs
    {
        public static void Show(StreamReader inputfile)
        {
            // Menu Option 6: Display Mobs

            // Mobs - 5
            string mob1, mob2, mob3, mob4, mob5, mob1desc, mob2desc, mob3desc, mob4desc, mob5desc;

            // Open and Close file
            using (inputfile = File.OpenText(@"../../txt/mobs.txt"))
            {
                // Read from file
                while (!inputfile.EndOfStream)
                {
                    // Assign Mobs (5)
                    mob1 = inputfile.ReadLine();
                    mob1desc = inputfile.ReadLine();
                    mob2 = inputfile.ReadLine();
                    mob2desc = inputfile.ReadLine();
                    mob3 = inputfile.ReadLine();
                    mob3desc = inputfile.ReadLine();
                    mob4 = inputfile.ReadLine();
                    mob4desc = inputfile.ReadLine();
                    mob5 = inputfile.ReadLine();
                    mob5desc = inputfile.ReadLine();

                    // Print Mobs
                    Console.WriteLine(mob1);
                    Console.WriteLine(mob1desc);
                    Console.WriteLine();
                    Console.WriteLine(mob2);
                    Console.WriteLine(mob2desc);
                    Console.WriteLine();
                    Console.WriteLine(mob3);
                    Console.WriteLine(mob3desc);
                    Console.WriteLine();
                    Console.WriteLine(mob4);
                    Console.WriteLine(mob4desc);
                    Console.WriteLine();
                    Console.WriteLine(mob5);
                    Console.WriteLine(mob5desc);
                }
            }
        }
    }
}
