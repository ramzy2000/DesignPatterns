public abstract class Device : IDevice
{
    protected bool isOn = true;
    public virtual void turnOn()
    {
        isOn = true;
    }
    public virtual void turnOff()
    {
        isOn = false;
    }
}