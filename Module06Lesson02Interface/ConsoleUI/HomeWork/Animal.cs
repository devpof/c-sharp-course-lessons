using System;

namespace ConsoleUI
{
    public class Animal : IRun
    {
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
}
