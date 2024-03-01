using DistanceFormula.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceFormula.BL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLine line = new MyLine();
            Char Option;
            do
            {
                Option = menu();
                if (Option == '1')
                {
                    line = makeLine();
                }
                else if (Option == '2')
                {
                    line.setBegin(updateBegin());
                }
                else if (Option == '3')
                {
                    line.setEnd(updateEnd());
                }
                else if (Option == '4')
                {
                    Console.WriteLine("Begining points are X: " + line.getBegin().getX() + " Y: " + line.getBegin().getY());
                    Console.ReadKey();
                }
                else if (Option == '5')
                {
                    Console.WriteLine("Ending points are X: " + line.getEnd().getX() + " Y: " + line.getEnd().getY());
                    Console.ReadKey();
                }
                else if (Option == '6')
                {
                    Console.WriteLine("Lenght is: " + line.getLength());
                    Console.ReadKey();
                }
                else if (Option == '7')
                {
                    Console.WriteLine("Gradient is: " + line.getGradient());
                    Console.ReadKey();
                }
                else if (Option == '8')
                {
                    Console.WriteLine("Distance of begin point from zero coordinate is: " + line.getBegin().distanceFromZero());
                    Console.ReadKey();
                }
                else if (Option == '9')
                {
                    Console.WriteLine("Distance of end point from zero coordinate is: " + line.getEnd().distanceFromZero());
                    Console.ReadKey();
                }
            }
            while(Option != 10);
            
        }
        static MyLine makeLine()
        {
            Console.Write("Enter Begining Coordinate X: ");
            int bx = int.Parse(Console.ReadLine());
            Console.Write("Enter Begining Coordinate Y: ");
            int by = int.Parse(Console.ReadLine());
            Console.Write("Enter Ending Coordinate X: ");
            int ex = int.Parse(Console.ReadLine());
            Console.Write("Enter Ending Coordinate Y: ");
            int ey = int.Parse(Console.ReadLine());
            MyPoint begin = new MyPoint(bx, by);
            MyPoint end = new MyPoint(ex, ey);
            MyLine line = new MyLine(begin, end);
            return line;
            
        }
        static MyPoint updateBegin()
        {
            Console.Write("Enter X Coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Coordinate: ");
            int y = int.Parse(Console.ReadLine());
            MyPoint begin = new MyPoint(x, y);
            return begin;
        }
        static MyPoint updateEnd()
        {
            Console.Write("Enter X Coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Coordinate: ");
            int y = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint(x, y);
            return end;
        }
        static Char menu()
        {
            Console.WriteLine("1. Make a Line");
            Console.WriteLine("2. Update the Begin Point");
            Console.WriteLine("3. Update the End Point");
            Console.WriteLine("4. Show the Begin Point");
            Console.WriteLine("5. Show the End Point");
            Console.WriteLine("6. Get the Lenght of Line");
            Console.WriteLine("7. Get the Gradient of Line");
            Console.WriteLine("8. Find distance of Begin Point from Zero Coordinates");
            Console.WriteLine("9. Find distance of End Point from Zero Coordinates");
            Console.WriteLine("10. Exit");
            Console.Write("Enter Option: ");
            Char option = Char.Parse(Console.ReadLine());
            return option;
        }
    }
}
