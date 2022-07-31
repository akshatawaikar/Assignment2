using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        public struct Time
        {
            private readonly int minutes;
            private readonly int hours;

            
            public Time(int hh, int mm)
            {
                this.minutes = mm;
                this.hours = hh;
                
            }
            public int HOUR { get { return hours; } }
            public int MIN { get { return minutes; } }
            public override string ToString()
            {
                return String.Format("{0}:{1}",hours,minutes);
            }
        }
        static void Main(string[] args)
        {
            Time t = new Time(10, 25);
            Console.WriteLine(t.ToString());

        }
    }
}
