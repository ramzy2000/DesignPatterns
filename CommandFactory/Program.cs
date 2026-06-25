public class Program
{
    public static void Main(string[] args)
    {
        CommandFactory commandFactory = new CommandFactory();

        while (true)
        {
            Console.Write("Enter a command: ");
            string? input = Console.ReadLine();
            ICommand command = commandFactory.CreateCommand(input);
            command.Execute();
        }
    }
}