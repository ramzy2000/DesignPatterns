// singleton

public class Singleton
{
    private static Singleton? instance = null;

    private static readonly object lockObject = new object();

    private static int numberOfExecutions = 0;

    private Singleton()
    {

    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
        }
        return instance;
    }

    public void Execute()
    {
        numberOfExecutions++;
    }

    public int GetExecutionCount()
    {
        return numberOfExecutions;
    }
}


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