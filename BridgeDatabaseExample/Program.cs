public class Program
{
    public static void Main(string[] args)
    {
        MySqlDatabase mysql = new MySqlDatabase();
        SqliteDatabase sqlite = new SqliteDatabase();
        DatabaseContext databaseContext = new DatabaseContext(mysql);
        databaseContext.SetDatabase(sqlite);

        databaseContext.Connect("Test");
    }
}