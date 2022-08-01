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
            public int minutes;
            public int hours;
           
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

            public static explicit operator int(Time t)
            {
               
                int i = (int)t.minutes;
                return i ;
            }
          
        }
        static void Main(string[] args)
        {
            Time t1 = new Time(9, 30);
            Time t2 = 100;
            Console.WriteLine("T2 : {0}", t2.minutes);
            int i = (int)t1;
            Console.WriteLine(i);
        }
    }
}
