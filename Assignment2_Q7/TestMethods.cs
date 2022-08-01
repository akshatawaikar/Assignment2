using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q7
{
    internal class TestMethods
    {
        public class B
        {
            public static void SM() { Console.WriteLine("Hello from B.SM()"); }
            public virtual void VIM() { Console.WriteLine("Hello from B.VIM()"); }
            public void NIM() { Console.WriteLine("Hello from B.NIM()"); }
        }

        public class C : B 
        {
            public static void SM() { Console.WriteLine("Hello from C.SM()"); }

            override public void VIM() { Console.WriteLine("Hello from C.VIM()"); }

            public void NIM() { Console.WriteLine("Hello from C.NIM"); }
            

        }

    }
}
