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
            public Time(int hh, int mm)
            {
                this.minutes = hh * 60 + mm;

            }
            public override string ToString()
            {
                return minutes.ToString(); 
            }
        }
        static void Main(string[] args)
        {
            Time t = new Time(10,05);
            Console.WriteLine(t.ToString());

        }
    }
}
