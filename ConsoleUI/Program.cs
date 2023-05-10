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
// lmao going to have to rename because there was a 2007 movie named the same thing
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false; // Sentry

            LoadGame.RunLoad();
            
            SystemMessage.Greet();
            Console.WriteLine();

            World.player.MoveTo(0);

            while (!exit && World.player.Alive) // Game is running
            {
                // Start game

                Display.Room();
                exit = Command.Choose(Choice.Prompt());

                Console.WriteLine("[CONTINUE]");
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
