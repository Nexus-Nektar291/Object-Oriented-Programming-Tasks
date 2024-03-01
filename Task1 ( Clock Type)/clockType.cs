using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    public class ClockType
    {
        public int hr;
        public int min;
        public int sec;
        public ClockType()
        {
            hr = 0; min = 0; sec = 0;
        }
        public ClockType(int h)
        {
            hr = h;
            min = 0;
            sec = 0;
        }
        public ClockType(int h, int m)
        {
            hr = h;
            min = m;
            sec = 0;
        }
        public ClockType(int h, int m,int s)
        {
            hr = h;
            min = m;
            sec = s;
        }
        public void print_time()
        {
            Console.WriteLine(hr + " : " + min + " : " + sec);
        }
        public void sethr()
        {
            hr++;
        }
        public void setmin()
        {
            min++;
        }
        public void setsec()
        {
            sec++;
        }
        public bool isequal(int h, int m, int s)
        {
            if (hr == h && min == m && sec == s)
            {
                return true;
            }
            else
                return false;
        }
        public bool isequal(ClockType other)
        {
            if (hr == other.hr && min == other.min && sec == other.sec)
            {
                return true;
            }
            else
                return false;
        }
        public void increment_time()
        {
            sethr();
            setmin();
            setsec();
            Console.Write("Time after increment = ");
            print_time();
        }
        public void Manual_time(int h, int m, int s)
        {
            bool flag = isequal(h, m, s);
            Console.WriteLine("Comparing with manual time : " + flag);
        }
        public void object_time(ClockType obj)
        {
            bool flag = isequal(obj);
            Console.WriteLine("Comparing with object time : " + flag);
        }
        public void elapsed_time(int h,int m,int s)
        {
            h = Math.Abs(hr - h);
            m = Math.Abs(min - m);
            s = Math.Abs(sec - s);
            Console.WriteLine("Elapsed time is = {0} : {1} : {2} ",h, m, s);
        }
        public void remaining_time()
        {
            hr = 23 - hr;
            min = Math.Abs(60 - min);
            sec = Math.Abs(60 - sec);
            Console.WriteLine("Remaining time in the day is = {0} : {1} : {2} ",hr,min, sec);
        }
    }
}
