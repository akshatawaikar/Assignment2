using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q8
{
    internal class TestDelegates
    {
        public delegate void InAction(int i);

        public void Perform(InAction act, int[] arr)
        {
           foreach(int i in arr)
           {

               act(i);

           }
        }
    }
}
