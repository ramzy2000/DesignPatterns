public interface ICommand
{
    public void Execute();
}

public class HelloCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Hello you typed the hello command");
    }
}

public class ErrorCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Failed to find command");
    }
}

public interface ICommandFactory
{
    public ICommand CreateCommand(string commandText);
}

public class CommandFactory : ICommandFactory
{
    public ICommand CreateCommand(string? commandText)
    {
        switch (commandText)
        {
            case "hello":
                return new HelloCommand();
        }
        return new ErrorCommand();
    }
}

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