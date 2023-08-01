// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using DesignPattern_Decorator;
using DesignPattern_Decorator.Demo;

Main();

static void Main()
{
    // ConcreteComponent c = new ConcreteComponent();
    // ConcreteDecoratorA d1 = new ConcreteDecoratorA();
    // ConcreteDecoratorB d2 = new ConcreteDecoratorB();
    // d1.SetComponent(c);
    // d2.SetComponent(d1);
    // d2.Operation();

    Person ps = new Person("RH");
    Console.WriteLine("第一种装扮");
    TShirt ts = new TShirt();
    BigTrouser bt = new BigTrouser();
    
    ts.Decorate(ps);
    bt.Decorate(ts);
    bt.Show();

    Console.WriteLine("Hello, World!");
}