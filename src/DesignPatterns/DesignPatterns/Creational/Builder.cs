namespace DesignPatterns.Creational;

public static class BuilderPattern
{
    public record Widget(
        int Foo,
        int Bar,
        int Baz
    );

    public class WidgetBuilder
    {
        int _foo;
        int _bar;
        int _baz;

        public WidgetBuilder WithFoo(int foo)
        {
            _foo = foo;
            return this;
        }

        public WidgetBuilder WithBar(int bar)
        {
            _bar = bar;
            return this;
        }

        public WidgetBuilder WithBaz(int baz)
        {
            _baz = baz;
            return this;
        }

        public Widget Build()
        {
            Console.WriteLine($"Building a new Widget with foo:{_foo}, bar:{_bar}, baz:{_baz}");
            return new(_foo, _bar, _baz);
        }
    }

    public static void Execute()
    {
        Console.WriteLine($"[{nameof(BuilderPattern)} Pattern]");
        Console.WriteLine();

        var widget = new WidgetBuilder()
            .WithFoo(123)
            .WithBaz(999)
            .Build();
    }
}

