using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMethods.B.SM();
            TestMethods.C.SM();

            TestMethods.C c = new TestMethods.C();
            TestMethods.B b = new TestMethods.C();

            b.NIM();
            b.VIM();

            c.NIM();
            c.VIM();



        }
    }
}
