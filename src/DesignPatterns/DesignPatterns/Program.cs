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

BuilderPattern.Execute();
NewLine();
Separator();

FactoryPattern.Execute();
NewLine();
Separator();

SingletonPattern.Execute();
NewLine();
Separator();

Console.WriteLine("*** Structural Patterns ***");
Separator();

Proxy.Execute();
NewLine();
Separator();

Adapter.Execute();
NewLine();
Separator();

Console.WriteLine("*** Behavioural Patterns ***");
Separator();

StrategyPattern.Execute();
NewLine();
Separator();

static void Separator() => Console.WriteLine(new string('-', 100));
static void NewLine() => Console.WriteLine();
