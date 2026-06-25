public class Program
{
    public static void Main(string[] args)
    {
        Singleton singleton = Singleton.GetInstance();

        singleton.Execute();


        Singleton singleton1 = Singleton.GetInstance();

        Console.WriteLine(singleton1.GetExecutionCount());
    }
}