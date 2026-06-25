public class ErrorCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Failed to find command");
    }
}
