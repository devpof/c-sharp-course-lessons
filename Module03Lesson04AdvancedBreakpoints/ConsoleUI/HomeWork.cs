using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class HomeWork
    {
        /*
         * Create a Console Application that loops from 1 to 100. Throw an exception on 73.
         * Use a breakpoint to break before the breaking situation.
         */
        public static void RunALoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 73)
                {
                    throw new Exception("i is 73");
                }
            }
        }
    }
}
