using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceFormula.BL
{
    public class MyPoint
    {
        public int X;
        public int Y;
        public MyPoint()
        {
            this.X = 0; this.Y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int getX()
        {
            return X;
        }
        public int getY() 
        {
            return Y;
        }
        public void setX(int x)
        {
            X = x;
        }
        public void setY(int y)
        {
            Y = y;
        }
        public void setXY(int x, int y) 
        {
            X = x;
            Y = y;
        }
        public double distanceWithCords(int x, int y)
        {
            double distance = Math.Sqrt((x-X)*(x-X) + (y-Y)*(y-Y));
            return distance;
        }
        public double distanceWithObject(MyPoint p)
        {
            double distance = Math.Sqrt((p.X - X) * (p.X - X) + (p.Y - Y) * (p.Y - Y));
            return distance;
        }
        public double distanceFromZero()
        {
            double distance = Math.Sqrt((0-X)*(0-X) + (0-Y) *(0-Y));
            return distance;
        }
    } 
}
