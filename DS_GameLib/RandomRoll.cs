using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class RandomDie
    {
        public static Random rand = new Random();
        public static int Roll(string range)
        {
            string[] dieRange = range.Split('D'); // Get range of die
            int number = rand.Next(1, int.Parse(dieRange[1]) + 1) * int.Parse(dieRange[0]); // Get die value
            return number; // Return die value
        }
    }
}
