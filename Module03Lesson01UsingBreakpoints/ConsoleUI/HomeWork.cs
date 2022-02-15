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
         * Homework:
         * Create a Console Application with a
         * for loop that multiplies a number by 5 and
         * adds it to the total each time.
         * Step through the code.
         */
        public static void Run()
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += (i * 5);
            }
        }
    }
}
