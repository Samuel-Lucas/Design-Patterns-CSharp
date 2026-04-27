namespace SingletonPattern;

public class LogSingleton
{
    private static LogSingleton? Instance;

    private LogSingleton() { }

    public static LogSingleton GetInstance
    {
        get
        {
            if (Instance is null)
                Instance = new();
            
            return Instance;
        }
    }

    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}