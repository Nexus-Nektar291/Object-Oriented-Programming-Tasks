using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_hotelmanagementsystem.BL
{
    public class ProductBL
    {
        private string name;
        private string type;
        private double price;

        public static string products_path = "products.txt";
        public ProductBL() { }
        public ProductBL(string name, string type, double price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        public string getname()
        {
            return name;
        }
        public string gettype()
        {
            return type;
        }
        public double getprice()
        {
            return price;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void settype(string type)
        {
            this.type = type;
        }
        public void setprice(double price)
        {
            this.price = price;
        }
    }
}
