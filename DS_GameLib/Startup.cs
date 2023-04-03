using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Startup
    {
        public static void Run()
        {
            bool exit = false; // Sentry boolean

            do
            {
                // Show menu
                Menu.DisplayMenu();
                exit = MenuSelect.Choose(Choice.Prompt());
                Console.ReadLine();
                Console.Clear();
            } while (!exit);
        }
    }
}
