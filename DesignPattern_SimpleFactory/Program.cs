// See https://aka.ms/new-console-template for more information


using DesignPattern;

Main(null);

static void Main(string[] args)
{
    Console.WriteLine("Hello, World!");
    var operation = OperationFactories.CreateOperation("+");
    operation.NumberA = 2;
    operation.NumberB = 3;
    Console.WriteLine(operation.GetResult());
}