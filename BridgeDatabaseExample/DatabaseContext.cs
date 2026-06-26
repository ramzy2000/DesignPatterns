public class DatabaseContext
{
    IDatabase database;

    public DatabaseContext(IDatabase database)
    {
        this.database = database;
    }

    public void SetDatabase(IDatabase database)
    {
        this.database = database;
    }

    public void Connect(string connectionString)
    {
        database.Connect(connectionString);
    }

    public void Save()
    {
        database.Save();
    }

    public void Close()
    {
        database.Close();
    }
}