using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class GenericMessage
    {
        public static void Show(int id)
        {
            switch (id)
            {
                case 0:
                    Console.WriteLine("Goodbye");
                    break;
                case 1:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
