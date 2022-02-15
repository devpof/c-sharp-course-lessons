using System;

namespace ConsoleUI
{
    public class Person : IRun
    {
        public void Run()
        {
            Console.WriteLine("Person is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Person is now walking");
        }
    }
}
