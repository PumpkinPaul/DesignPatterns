namespace DesignPatterns.Structural;

public static class Adapter
{
    public interface IEuroPlug
    {
        void Insert();
    }

    public interface IUkPlug
    {
        void UkSpecificInsert();
    }

    public class UkPlug : IUkPlug
    {
        public void UkSpecificInsert() => Console.WriteLine("Plugging in a UK plug");
    }

    public class FrenchPlug : IEuroPlug
    {
        public void Insert() => Console.WriteLine("Plugging in a French plug");
    }


    public class EuroPlugToUkPlugAdapter : IEuroPlug
    {
        readonly IUkPlug _ukPlug;

        public EuroPlugToUkPlugAdapter(IUkPlug ukPlug)
        {
            _ukPlug = ukPlug;
        }

        public void Insert()
        {
            _ukPlug.UkSpecificInsert();
        }
    }

    public static class Runner
    {
        public static void Execute()
        {
            Console.WriteLine($"[{nameof(Adapter)} Pattern]");
            Console.WriteLine();

            var ukPlug = new UkPlug();
            IEuroPlug adapter = new EuroPlugToUkPlugAdapter(ukPlug);

            adapter.Insert();
        }
    }
}

