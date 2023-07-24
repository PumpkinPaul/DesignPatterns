// See https://aka.ms/new-console-template for more information

using DesignPatterns.Behavioural;
using DesignPatterns.Creational;
using DesignPatterns.Structural;

Console.WriteLine("DESIGN PATERNS");
NewLine();
NewLine();

Separator();
Console.WriteLine("*** Creational Patterns ***");
Separator();

Builder.Runner.Execute();
NewLine();
Separator();

Factory.Runner.Execute();
NewLine();
Separator();

Console.WriteLine("*** Structural Patterns ***");
Separator();

Proxy.Runner.Execute();
NewLine();
Separator();

Adapter.Runner.Execute();
NewLine();
Separator();

Console.WriteLine("*** Behavioural Patterns ***");
Separator();

Strategy.Runner.Execute();
NewLine();
Separator();

static void Separator() => Console.WriteLine(new string('-', 100));
static void NewLine() => Console.WriteLine();
