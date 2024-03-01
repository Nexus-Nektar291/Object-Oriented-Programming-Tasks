using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClockType c1 = new ClockType();
            Console.Write("Intial time is = ");
            c1.print_time();
            c1.increment_time();
            c1.remaining_time();
            c1.Manual_time(13, 34, 49);
            c1.elapsed_time(19, 22, 46);
            Console.WriteLine();

            ClockType c3 = new ClockType(23, 19, 27);
            Console.Write("Time for third object is = ");
            c3.print_time();
            c3.remaining_time();
            c3.increment_time();
            c3.Manual_time(7, 36, 25);
            c3.elapsed_time(12, 33, 41);
            Console.WriteLine();

            ClockType c2 = new ClockType(8, 21, 59);
            Console.Write("Time for second object is = ");
            c2.print_time();
            c2.increment_time();
            c2.Manual_time(9, 22, 60);
            c2.elapsed_time(16, 39, 19);
            c2.remaining_time();
            c2.object_time(c3);
        }
    }
}
