using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegates t = new TestDelegates();

            TestDelegates.InAction del = new TestDelegates.InAction(PrintInt);
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            t.Perform(del,arr) ;

        }

        public static void PrintInt(int j)
        {
            Console.WriteLine(j);
        }

       
    }
}
