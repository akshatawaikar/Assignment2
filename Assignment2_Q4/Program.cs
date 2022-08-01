using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q4
{
    internal class Program
    {

        public struct Time
        {
            private readonly int minutes;
            private readonly int hours;
            // public int i;

            public Time(int hh, int mm)
            {
                this.minutes = mm;
                this.hours = hh;
            }
            public static implicit operator Time(int i)
            {
                Time t = new Time(11,i);
                return t;
            }

            public static explicit operator Time(int i)
            {

            }
            public void print()
            {
                Console.WriteLine("{0}", );
            }

        }
        static void Main(string[] args)
        {

        }
    }
}
