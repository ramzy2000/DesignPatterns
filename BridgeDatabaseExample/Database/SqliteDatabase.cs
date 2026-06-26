public class SqliteDatabase : Database
{
    public override void Connect(string connectionString)
    {
        Console.WriteLine("Connected to Sqlite database");
    }

    public override void Save()
    {
        Console.WriteLine("Saving Sqlite database");
    }

    public override void Close()
    {
        Console.WriteLine("Closing Sqlite database");
    }
}