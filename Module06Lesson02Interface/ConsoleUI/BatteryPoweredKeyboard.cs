namespace ConsoleUI
{
    public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
    {
        public int BatteryLevel { get; set; }

    }

}
