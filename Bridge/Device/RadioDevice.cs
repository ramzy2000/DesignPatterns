public class RadioDevice : Device
{
    public override void turnOn()
    {
        base.turnOn();
        Console.WriteLine("Turning Radio on...");
    }
    public override void turnOff()
    {
        base.turnOff();
        Console.WriteLine("Turn Radio Off...");
    }
}