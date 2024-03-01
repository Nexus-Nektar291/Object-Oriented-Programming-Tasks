using Gui_hotelmanagementsystem.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_hotelmanagementsystem.DL
{
    public class RoomDL
    {
        public static List<RoomBL> rooms = new List<RoomBL>();
        public static void add_room(RoomBL b)
        {
            rooms.Add(b);
        }
        public static bool isroomexists(string name, string type)
        {
            bool flag = false;
            foreach (RoomBL b in rooms)
            {
                if (b.getName() == name && b.gettype() == type)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static void storeroomsinfile(string path, RoomBL b)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(b.getName() + "," + b.gettype() + "," + b.getprice());
            file.Close();
        }
    }
}
