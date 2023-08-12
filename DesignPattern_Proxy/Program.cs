// See https://aka.ms/new-console-template for more information

using DesignPattern_Proxy.Demo;

Console.WriteLine("Hello, World!");


SchollGirl mm = new SchollGirl();
mm.Name = "小芳";

Proxy proxy = new Proxy(mm);

proxy.GiveDolls();
proxy.GiveChocolate();
proxy.GiveChocolate();

