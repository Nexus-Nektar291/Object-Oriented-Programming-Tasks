using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace smoothie_muhammadjilani2022cs192_
{
    internal class Program
    {
        static List<ingredients> items = new List<ingredients>();
        static void Main(string[] args)
        {
            ingredients ingredient1 = new ingredients("Strawberries", 1.50);
            items.Add(ingredient1);
            ingredients ingredient2 = new ingredients("Banana", 0.50);
            items.Add(ingredient2);
            ingredients ingredient3 = new ingredients("Mango", 2.50);
            items.Add(ingredient3);
            ingredients ingredient4 = new ingredients("Blueberries", 1.00);
            items.Add(ingredient4);
            ingredients ingredient5 = new ingredients("Raspberries", 1.00);
            items.Add(ingredient5);
            ingredients ingredient6 = new ingredients("Apple", 1.75);
            items.Add(ingredient6);
            ingredients ingredient7 = new ingredients("Pineapple", 3.50);
            items.Add(ingredient7);

            List<string> smoothies = GetSmoothieFromInput();
            Smoothie s = new Smoothie(smoothies);
            outputResult(s);
        }

        public static void outputResult(Smoothie s)
        {

            Console.WriteLine(Math.Round(s.GetCost(), 2));
            Console.WriteLine(Math.Round(s.GetPrice(), 2));
            Console.WriteLine(s.GetName());
        }
        public static List<string> GetSmoothieFromInput()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ingredients = new List<string>();
            for (int i = 0; i < n; ++i)
            {
                string _params = Console.ReadLine();
                ingredients.Add(_params);
            }
            return ingredients;
        }

        public class Smoothie
        {
            public List<string> Ingredients = new List<string>();
            public Smoothie(List<string> Ingredients)
            {
            }

            public double GetCost()
            {

                foreach (var i in Ingredients)
                {
                    if (Ingredients[i]==GetSmoothieFromInput())
                    {
                        return 0;
                    }
                }
            }
            public double GetPrice()
            {
                double sum = 1.5*GetCost();
                for (int i = 0; i < 5; i++) 
                {
                    if (GetSmoothieFromInput() == ingredients[i])
                    {
                        sum=sum+GetCost();
                    }
                }
            }
            public string GetName()
            {
                for(int i = 0;i < Ingredients.Count;)
            }


        }
        public class ingredients
        {
            public string name;
            public double price;

            public ingredients(string name, double price)
            {
                this.name = name;
                this.price = price;
            }
        }
    }
}