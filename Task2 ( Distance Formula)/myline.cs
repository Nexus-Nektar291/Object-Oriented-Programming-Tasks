using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DistanceFormula.BL
{
    public class MyLine
    {
        MyPoint Begin = new MyPoint();
        MyPoint End = new MyPoint();
        public MyLine() 
        {

        }
        public MyLine(MyPoint begin, MyPoint end)
        {
            Begin = begin;
            End = end;
        }
        public void setBegin(MyPoint begin) 
        {
            Begin = begin;
        }
        public void setEnd(MyPoint end) 
        {
            End = end;
        }
        public MyPoint getBegin()
        {
            return Begin;
        }
        public MyPoint getEnd()
        {
            return End;
        }
        public double getLength()
        {
            double length = Begin.distanceFromZero() - End.distanceFromZero();
            return length;
        }
        public double getGradient()
        {
            double slope = (End.getY() - Begin.getY())/(End.getX()-Begin.getX());
            return slope;
        }
    }
}
