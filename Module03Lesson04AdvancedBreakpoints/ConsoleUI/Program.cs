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
             * ADVANCED BREAKPOINTS
             * 
             * PRO TIP:
             *  Use advanced breakpoints to help you narrow down issues and finally find the location of the error.
             * 
             * 1. Using Conditions
             *    Options you can user
             *      > Conditional Expression - if the expression entered is true
             *      > Hit Count - how many times the breakpoint will be hit
             *      > Filter - very rarely you will use this
             *    After putting Conditionals in your breakpoint, your breakpoint
             *    icon will contain a plus(+) symbol that indicates that breakpoint
             *    is a counter breakpoint.
             *    
             * 2. Actions
             *    You can add Actions in tandem with the conditions
             *    Actions can let you show a message in the output window
             *    You can use String intrapolation on the message
             *    After putting an Action, your breakpoint icon will be
             *      diamond shape.
             *      
             * 3. Edit Labels
             *    Breakpoints window will let you see all the Breakpoints in your application
             *    To do that go to:
             *      Debug Menu > Windows > Breakpoints
             *    Right click on the Breakpoint icon and then select Edit Labels
             *    You add the name of the Label and once added you can just select it for grouping of breakpoints
             *    You can also do anything in the Breakpoints window just like when you right click a breakpoint
             *    Unique to Breakpoints window:
             *      > Add a New Function Breakpoint. This will put a breakpoint in the opening curly brace
             *        of the function you entered
             *      > Import/Export breakpoints. You can send your breakpoints to someone by exporting your breakpoints
             *        and then sending the file to your colleague and him/her will import it. It is useful for
             *        finding a weird bug so you can use it for next time
             * 
             */
            //RunsALot();

            HomeWork.RunALoop();
            Console.ReadLine();            
        }

        private static void RunsALot()
        {
            long total = 0;
            int test = 0;

            for (int i = -1000; i <= 1000; i++)
            {
                total += i;
                try
                {
                    test = 5 / i;
                }
                catch
                {
                    //shortcut is you can put a break point on the line below
                    //to know the value of where the error is
                    Console.WriteLine("There was an exception");
                }
            }

            Console.WriteLine($"The total is {total}");
        }
    }
}
