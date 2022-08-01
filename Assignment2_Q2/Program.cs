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
            private readonly int totalminutes;


            public int HOUR { get { return hours; } }
            public int MIN { get { return minutes; } }
            public Time(int hh, int mm)
            {
                this.hours = hh;
                this.minutes = mm;
                this.totalminutes = hh * 60 + mm;
            }
            
            public override string ToString()
            {
                int mins = totalminutes % 60;
                int hrs = totalminutes / 60;
                
                return String.Format("{0}:{1}",hrs,mins);
            }
        }
        static void Main(string[] args)
        {
            Time t = new Time(10, 25);
            Console.WriteLine(t.ToString());

        }
    }
}
