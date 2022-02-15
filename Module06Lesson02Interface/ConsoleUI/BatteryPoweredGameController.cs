namespace ConsoleUI
{
    // Since the parent class inherits an Interface, this class is also part
    // of that interface.
    // ALWAYS Inherit a class first, if needed, then implement interface after.
    public class BatteryPoweredGameController : GameController, IBatteryPowered
    {
        public int BatteryLevel { get; set; }

    }

}
