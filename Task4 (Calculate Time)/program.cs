using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClockType empty_time = new ClockType();
            Console.WriteLine("Empty time : ");
            empty_time.print_time();

            ClockType hour_time = new ClockType(12);
            Console.WriteLine("Hour time : ");
            hour_time.print_time();

            ClockType minute_time = new ClockType(12, 22);
            Console.WriteLine("Minute time : ");
            minute_time.print_time();

            ClockType second_time = new ClockType(12, 22, 43);
            Console.WriteLine("Second time : ");
            second_time.print_time();

            //  ClockType full_time = new ClockType();

            Console.WriteLine("Full time after 1 second : ");
            second_time.increement_second();
            second_time.print_time();

            Console.WriteLine("Full time after 1 minute : ");
            second_time.increement_minutes();
            second_time.print_time();

            Console.WriteLine("Full time after 1 hour : ");
            second_time.increement_hour();
            second_time.print_time();

            bool flag = second_time.isequal(13, 23, 44);
            Console.WriteLine("Flag is : " + flag);

            ClockType clockType = new ClockType(12);
            flag = clockType.equal(hour_time);
            Console.WriteLine("Time is : " + flag);
            Console.WriteLine("At last i am successful ");
        }
    }
}
