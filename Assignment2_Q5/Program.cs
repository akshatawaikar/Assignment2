using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q5
{
    internal class Program
    {
        public  struct Time {
            public int minutes;
            private readonly int hours;

            public Time(int hh, int mm)
            {
                this.minutes = mm;
                this.hours = hh;

            }

            static Time t;
        }

        static void Main(string[] args)
        {
            Time t1 = new Time(9, 30); 
            Time t2 = t1;
            t1.minutes = 100;
            Console.WriteLine("t1={0} and t2={1}", t1.minutes, t2.minutes);

        }
    }
}
