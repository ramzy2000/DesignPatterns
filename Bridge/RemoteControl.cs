// This class acts as a bridge between the IDevice class and the remote control

public class RemoteControl
{
    IDevice remoteDevice;

    public RemoteControl(IDevice remoteDevice)
    {
        this.remoteDevice = remoteDevice;
    }

    public void turnOn()
    {
        remoteDevice.turnOn();
    }

    public void turnOff()
    {
        remoteDevice.turnOff();
    }
}