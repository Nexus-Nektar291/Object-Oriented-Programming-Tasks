using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Products
    {
        public int count = 0;
        public string[] name = new string[10];
        public string[] category = new string[10];
        public double[] price = new double[10];
        public int[] quantity = new int[10];
        public int[] minQuantity = new int[10];
        public double[] tax = new double[10];

        public void add_product()
        {
            Console.Clear();
            Console.Write("Enter product name : ");
            name[count] = Console.ReadLine();
            Console.Write("Enter product category: ");
            category[count]= Console.ReadLine();
            Console.Write("Enter product price: ");
            price[count]=double.Parse(Console.ReadLine());
            Console.Write("Enter product quantity: ");
            quantity[count]=int.Parse(Console.ReadLine());
            Console.Write("Enter minimum stock quantity: ");
            minQuantity[count]=int.Parse(Console.ReadLine());
            {
                if (category[count] == "fruit")
                    tax[count] = price[count] * 0.1;
                else if (category[count] == "grocery")
                    tax[count] = price[count] * 0.05;
                else
                    tax[count] = price[count] * 0.15;
                count++; 
            }

            Console.WriteLine("Product added successfully !");
            Console.Write("Enter any key to continue : ");
            Console.ReadKey();
        }

        public void view_products()
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No products found ! ");
            }
            else
            {
                Console.WriteLine("Name\t\tCategory\tPrice\t\tQuantity\tMin Quantity\tSales Tax");
                for (int i = 0; i < count; i++)
                {
                   Console.Write(name[i] + "\t\t" + category[i] + "\t\t" + price[i] + "\t\t" + quantity[i] + "\t\t" + minQuantity[i] + "\t\t" + tax[i] + "\n");
                }
            }
            Console.Write("Enter any key to continue : ");
            Console.ReadKey();
        }

        public void highest_price()
        {
            double max = 0;
            int a = 0;
            Console.Clear();
            if (count == 0)
                Console.Write ("No products found ! \n");
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (price[i] > max)
                    {
                        max = price[i];
                        a = i;
                    }
                }
                Console.Write(" Product with the highest price is : " + name[a] + " ( " + category[a] + " )  = " + price[a] + "\n");
            }
            Console.Write("Enter any key to continue : ");
            Console.ReadKey();
        }

        public void sales_tax()
        {
            double tax1 = 0.0;
            Console.Clear();
            if (count == 0)
                Console.Write("No products found ! \n");
            for (int i = 0; i < count; i++)
            {
                Console.Write(name[i]+" : "+tax[i]+" rs \n");
                tax1 = tax1 + tax[i];
            }
            Console.Write("Total Sales Tax : "+tax1+" rs \n");
            Console.Write("Enter any key to continue : ");
            Console.ReadKey();
        }

        public void ordered_products()
        {
            Console.Clear();
            if (count == 0)
            {
                Console.Write("No products found ! \n");
            }
            bool found = false;
            if(count !=0)
            { 
                Console.WriteLine("Products that should be ordered are : ");
                for (int i = 0; i < count; i++)
                {
                    {
                        if (quantity[i] < minQuantity[i])
                        {
                            Console.WriteLine();
                            Console.Write(name[i] + " (" + category[i] + ") - Quantity: " + quantity[i] + ", Minimum Quantity: " + minQuantity[i] + "\n");
                            found = true;
                        }
                    }
                }
            }
            if (!found)
                Console.Write("No products to be ordered!\n");
            Console.Write("Enter any key to continue : ");
            Console.ReadKey();
        }
    }
}
