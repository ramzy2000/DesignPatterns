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