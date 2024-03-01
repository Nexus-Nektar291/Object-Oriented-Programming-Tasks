using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            while (true)
            {
                string option;
                Console.Clear();
                Console.Write("1. Add Product\n");
                Console.Write("2. View All Products\n");
                Console.Write("3. Find Product with the Highest Unit Price\n");
                Console.Write("4. View Sales Tax of All Products\n");
                Console.Write("5. Products to be Ordered (less than the threshold)\n");
                Console.Write("6. Exit\n");
                Console.Write("Enter your option : ");
                option=Console.ReadLine();

                if (option == "1")
                    products.add_product();
                else if (option == "2")
                    products.view_products();
                else if (option == "3")
                    products.highest_price();
                else if (option == "4")
                    products.sales_tax();
                else if (option == "5")
                    products.ordered_products();
                else if (option == "6")
                    break;
                else
                    Console.Write("Invalid Option ! \n");
                Console.WriteLine();
            }
        }
    }
}
