public interface IDatabase
{
    public void Connect(string connectionString);

    public void Save();

    public void Close();
}