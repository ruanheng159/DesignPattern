// See https://aka.ms/new-console-template for more information

/*
 * 需求：设计一个计算器，支持加减乘除
 */

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