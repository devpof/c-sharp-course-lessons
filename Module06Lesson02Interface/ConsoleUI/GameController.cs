using System;

namespace ConsoleUI
{
    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {
        }

        public void CurrentKeyPressed()
        {
        }

        // you get this from IDisposable
        // this gets run whenever we shut down this class or get rid of the class
        public void Dispose()
        {
            // do whatever shutdown tasks needed
        }
    }

}
