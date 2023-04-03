using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DS_GameLib;

/**
* 3/11/2023
* CSC 153
* Kevin McCroary
* C# Game Project
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning = true; // Sentry

            while (gameRunning) // Game is running
            {
                // Start game
                Startup.Run();

                Console.WriteLine("You aren't leaving without a fight.");
                Console.ReadLine();

                // Start Combat
                Battle.Engage(150, 150);

                // End game
                gameRunning = false;
            }
        }
    }
}
