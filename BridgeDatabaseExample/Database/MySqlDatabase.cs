public class MySqlDatabase : Database
{
    public override void Connect(string connectionString)
    {
        Console.WriteLine("Connected to MySQL database");
    }

    public override void Save()
    {
        Console.WriteLine("Saving MySQL database");
    }

    public override void Close()
    {
        Console.WriteLine("Closing MySQL database");
    }
}