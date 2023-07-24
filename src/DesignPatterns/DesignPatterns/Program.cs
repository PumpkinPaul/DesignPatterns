// See https://aka.ms/new-console-template for more information

using DesignPatterns.Behavioural;
using DesignPatterns.Creational;
using DesignPatterns.Structural;

Separator();
Separator();
Console.WriteLine("DESIGN PATERNS");
Separator();
Separator();

Console.WriteLine("*** Creational Patterns ***");

Builder.Runner.Execute();
Separator();

Console.WriteLine("*** Structural Patterns ***");

Proxy.Runner.Execute();
Separator();

Adapter.Runner.Execute();
Separator();

Console.WriteLine("*** Behavioural Patterns ***");

Strategy.Runner.Execute();
Separator();

static void Separator() => Console.WriteLine(new string('-', 100));
