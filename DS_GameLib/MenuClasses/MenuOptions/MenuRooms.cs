using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class MenuRooms
    {
        public static void Show(StreamReader inputfile)
        {
            // Menu Option 1: Display Rooms

            // Rooms - 5
            string room1, room1desc, room2, room2desc, room3, room3desc, room4, room4desc, room5, room5desc;

            while (!inputfile.EndOfStream)
            {
                // Assign Rooms (5)
                room1 = inputfile.ReadLine();
                room1desc = inputfile.ReadLine();
                room2 = inputfile.ReadLine();
                room2desc = inputfile.ReadLine();
                room3 = inputfile.ReadLine();
                room3desc = inputfile.ReadLine();
                room4 = inputfile.ReadLine();
                room4desc = inputfile.ReadLine();
                room5 = inputfile.ReadLine();
                room5desc = inputfile.ReadLine();

                // Print Rooms
                Console.WriteLine(room1);
                Console.WriteLine(room1desc);
                Console.WriteLine();
                Console.WriteLine(room2);
                Console.WriteLine(room2desc);
                Console.WriteLine();
                Console.WriteLine(room3);
                Console.WriteLine(room3desc);
                Console.WriteLine();
                Console.WriteLine(room4);
                Console.WriteLine(room4desc);
                Console.WriteLine();
                Console.WriteLine(room5);
                Console.WriteLine(room5desc);
            }
        }
    }
}
