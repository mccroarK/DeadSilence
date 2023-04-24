using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public static class Move
    {
        // TEMPORARY UNTIL PLAYER OBJECTS ARE ADDED
        public static void Walk(string direction)
        {
            switch (direction)
            {
                case "north":
                    SystemMessage.Move("north");
                    if (World.currentRoom < World.rooms.Length - 1)
                    {
                        World.currentRoom++;
                    }
                    else
                    {
                        SystemMessage.InvalidMove(); // REPLACE
                    }
                    break;

                case "south":
                    SystemMessage.Move("south");
                    if (World.currentRoom > 0)
                    {
                        World.currentRoom--;
                    }
                    else
                    {
                        SystemMessage.InvalidMove(); // REPLACE
                    }
                    break;
            }
        }
    }
}
