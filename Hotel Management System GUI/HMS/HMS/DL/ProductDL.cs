using Gui_hotelmanagementsystem.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_hotelmanagementsystem.DL
{
    public class ProductDL
    {
        public static List<ProductBL> products = new List<ProductBL>();
        public static bool delete_product(string name, string type)
        {
            bool flag = false;
            foreach (ProductBL p in products)
            {
                if (p.getname() == name && p.gettype() == type) 
                {
                    products.Remove(p);
                    flag = true;
                }
            }
            return flag;
        }
        public static ProductBL show_products(int index)
        {
            ProductBL product = products[index];
            return product;
        }
        public static bool update_name(string previous_name, string new_name)
        {
            foreach (ProductBL p in products)
            {
                if (p.getname() == previous_name)
                {
                    p.setname(new_name);
                    return true;
                }
            }
            return false;
        }
        public static bool update_price(string name, double perivous_price, double new_price)
        {
            bool flag = false;
            foreach (ProductBL b in products)
            {
                if (b.getname() == name && b.getprice()==perivous_price)
                {
                    b.setprice(new_price);
                    flag = true;
                }
            }
            return flag;
        }
        public static bool isproductexists(string name, string type)
        {
            bool flag = false;
            foreach (ProductBL b in products)
            {
                if (b.getname().Equals(name) && b.gettype().Equals(type))
                {
                    flag = true;
                }
            }
            return flag;
        }
        public static void storeproductinfile(string path, ProductBL b)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(b.getname() + "," + b.gettype() + "," + b.getprice());
            file.Close();
        }
    }
}
