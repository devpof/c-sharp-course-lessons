using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class HomeWork
    {
        public static void Run()
        {
            BadLoop();
        }

        private static void BadLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                if(i == 4)
                {
                    throw new Exception("5 iterations happpened");
                }
            }
        }
    }
}
