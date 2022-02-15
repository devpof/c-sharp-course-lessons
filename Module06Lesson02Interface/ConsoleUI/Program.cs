using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
     * INTERFACE
     * Interface is a contract. This is what a class will do that implements this interface
     * Classes implement interfaces
     * Contains just definitions
     * 
     * USE CASE:
     * - If we have different things but we want to store them together
     * - When you want to create a contract that somebody else is going to implement.
     * 
     * Priority:
     * > You have to Inherit first, if you have a class to inherit, then you can implement the interfaces after
     * 
     * You can also combine 2 interfaces using the same syntax.
     * 
     * PRO=TIP:
     * Interfaces are a contract Use them as types when you need common functionality.
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController bpgc = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(bpgc);

            foreach (IComputerController controller in controllers)
            {
                if (controller is GameController gc)
                {

                }

                //is check can work in interfaces as well
                if (controller is IBatteryPowered powered)
                {
                    controller.Connect();
                    int a = powered.BatteryLevel;

                }
            }

            // you can use this for IDisposable implemented classes
            // it knows that this class has a Disposable method
            // beneficial on images. If you forgot to unload your
            // images, it will stay in the memory forever.
            // with this, it will always run regardless if your app crashes
            // another potential is for connecting to database
            // you can use this to close the connection to the database.
            using (GameController gc = new GameController())
            {
            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(bpgc);
            powereds.Add(batteryKeyboard);

            //HOMEWORK
            HomeWork.Run();

            Console.ReadLine();
        }
    }
}
