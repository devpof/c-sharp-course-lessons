using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PRO TIP: A bug is an opportunity, not something to be avoided.
             */
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"The value of i is {i}");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"The value of j is {j}");
                }
            }

            HomeWork.Run();

            Console.ReadLine();
        }
    }
}
