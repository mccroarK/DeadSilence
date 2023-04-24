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
            bool exit = false; // Sentry

            LoadFile.Run();
            LoadFile.Close();

            SystemMessage.Greet();
            Console.WriteLine();

            while (!exit) // Game is running
            {
                // Start game
                DisplayOption.Room();
                exit = Command.Choose(Choice.Prompt());

                Console.WriteLine("[CONTINUE]");
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
