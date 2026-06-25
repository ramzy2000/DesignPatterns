public class HelloCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Hello you typed the hello command");
    }
}