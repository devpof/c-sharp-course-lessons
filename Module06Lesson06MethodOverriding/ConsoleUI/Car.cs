using System;

namespace ConsoleUI
{
    public abstract class Car
    {
        //use this way if the method is very common and does not
        //need to be overwritten most of the time
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start");
        }

        //requires you to override this method everytime you inherit
        public abstract void SetClock();
    }
}
