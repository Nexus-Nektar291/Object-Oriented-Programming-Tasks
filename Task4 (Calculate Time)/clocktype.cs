using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class ClockType
    {
        public int hr;
        public int min;
        public int sec;
        public ClockType()
        {
            hr = 0;
            min = 0;
            sec = 0;
        }
        public ClockType(int h)
        {
            hr = h;
        }
        public ClockType(int h, int m)
        {
            hr = h;
            min = m;
        }
        public ClockType(int h, int m, int s)
        {
            hr = h;
            min = m;
            sec = s;
        }
        public void increement_hour()
        {
            hr++;
        }
        public void increement_minutes()
        {
            min++;
        }
        public void increement_second()
        {
            sec++;
        }
        public void print_time()
        {
            Console.WriteLine(hr + " : " + min + " : " + sec);
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
        public bool equal(ClockType other)
        {
            if(hr == other.hr && min == other.min && sec == other.sec)
            {
                return true;
            }
            else 
                return false;
        }
    }
}
