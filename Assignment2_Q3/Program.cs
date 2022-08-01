using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q3
{
    internal class Program
    {
        public struct Time
        {
            /*public int i;*/
            private int minutes;
            private int hours;


            public Time(int hh, int mm)
            {
                this.minutes = mm;
                this.hours = hh;
            }


           /* public Time(int a)
            {
                this.i = a;

            }*/
            public static Time operator +(Time t1, Time t2)
            {
                Time t3 = new Time();
                t3.minutes = t1.minutes + t2.minutes;
                t3.hours = t1.hours + t2.hours;
                return t3;

            }


            public static Time operator -(Time t1, Time t2)
            {
                Time t3 = new Time();
                t3.minutes = t1.minutes - t2.minutes;
                t3.hours = t1.hours - t2.hours;
                return t3;

            }



            public void display()
            {              
                Console.WriteLine("{0}:{1}", hours,minutes);
            }
        }
        static void Main(string[] args)
        {
            Time t1 = new Time(4,30);
            Time t2 = new Time(1,15);
            

            Time t3 = t1 + t2;

            Time t4 = t1 - t2;
            
           

            (t1 + new Time(03,08)).display();
            (t1 - new Time(04,07)).display();

            t3.display();
            t4.display();

        }
    }
}
