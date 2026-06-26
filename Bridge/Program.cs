public class Program
{
    public static void Main(string[] args)
    {

        RemoteControl remoteControl = new RemoteControl(new RadioDevice());

        remoteControl = new RemoteControl(new TVDevice());

        remoteControl.turnOn();
    }
}