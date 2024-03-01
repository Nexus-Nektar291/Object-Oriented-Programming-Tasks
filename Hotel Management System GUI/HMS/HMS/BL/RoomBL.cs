using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_hotelmanagementsystem.BL
{
    public class RoomBL
    {
        private string name;
        private string type;
        private double price;

        public static string room_path = "rooms.txt";
        public RoomBL() { }
        public RoomBL(string name, string type, double price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setprice(double price)
        {
            this.price = price;
        }
        public string getName()
        {
            return this.name;
        }
        public string gettype()
        {
            return this.type;
        }
        public double getprice()
        {
            return this.price;
        }

    }
}
