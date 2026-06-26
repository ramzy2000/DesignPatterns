public class TVDevice : Device
{
    public override void turnOn()
    {
        base.turnOn();
        Console.WriteLine("Turning TV on...");
    }
    public override void turnOff()
    {
        base.turnOff();
        Console.WriteLine("Turn TV Off...");
    }
}