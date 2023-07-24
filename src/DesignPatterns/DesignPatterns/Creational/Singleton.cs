namespace DesignPatterns.Creational;

public static class SingletonPattern
{
    public sealed class Singleton
    {
        static Singleton? _instance;

        private Singleton() { }

        public static Singleton Instance => _instance ??= new Singleton();
    }

    public static void Execute()
    {
        Console.WriteLine($"[{nameof(Singleton)} Pattern]");
        Console.WriteLine();

        var s1 = Singleton.Instance;
        var s2 = Singleton.Instance;

        if (s1 == s2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }
    }
}

