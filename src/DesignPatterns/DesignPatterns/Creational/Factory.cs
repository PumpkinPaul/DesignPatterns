namespace DesignPatterns.Creational;

public static class Factory
{
    public interface IWidget
    {
        void Defangulate();
    }

    public class FizzWidget : IWidget 
    {
        public void Defangulate() => Console.WriteLine("Fizzzzzzz!!");
    }

    public class BuzzWidget : IWidget
    {
        public void Defangulate() => Console.WriteLine("B.u.z.z.z.....");
    }

    public class WidgetFactory
    {
        public static IWidget Create(string config)
        {
            Console.WriteLine($"Creating a widget: {config}");

            return config == "fizz"
                ? new FizzWidget()
                : new BuzzWidget();
        }
    }

    public static class Runner
    {
        public static void Execute()
        {
            Console.WriteLine($"[{nameof(Factory)} Pattern]");
            Console.WriteLine();

            var widget = WidgetFactory.Create("buzz");
            widget.Defangulate();
        }
    }
}

