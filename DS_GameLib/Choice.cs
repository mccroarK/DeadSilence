using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Choice
    {
        public static string Prompt()
        {
            Console.Write("-> ");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}
