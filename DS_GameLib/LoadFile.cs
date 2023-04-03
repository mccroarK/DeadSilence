using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_GameLib
{
    public static class LoadFile
    {
        public static StreamReader Get (string filename)
        {
            string[] fileID = filename.Split('.'); // Split string to get file type
            string location = "../../" + fileID[1] + "/" + filename; // Get folder, which should be named by file type
            StreamReader file = File.OpenText(@location);
            return file;
        }
    }
}
