using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_GameLib
{
    public class Exit
    {
        #region Properties
        public int ID { get; }
        public string[] Text { get; }
        public int[] ToRoomsIDs { get; }
        #endregion

        #region Constructors
        public Exit() { }
        public Exit(int id, string[] text, int[] toRoomsIDs)
        {
            this.ID = id;
            this.Text = text;
            this.ToRoomsIDs = toRoomsIDs;
        }
        #endregion

        #region Methods
        public void Info()
        {
            // Check if user is in room, then print exit to opposite room
            if (World.player.Location != this.ToRoomsIDs[0])
            {
                Console.WriteLine(this.Text[0]);
            }
            else
            {
                Console.WriteLine(this.Text[1]);
            }
            Console.WriteLine();
        }

        public void Use()
        {
            // Check if user is in room, then move user to opposite room
            if (World.player.Location != this.ToRoomsIDs[0])
            {
                World.player.MoveTo(this.ToRoomsIDs[0]);
            }
            else
            {
                World.player.MoveTo(this.ToRoomsIDs[1]);
            }
        }
        #endregion
    }
}
