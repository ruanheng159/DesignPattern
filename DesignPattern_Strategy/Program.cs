// See https://aka.ms/new-console-template for more information

using DesignPattern_Strategy;

Console.WriteLine("Hello, World!");

double total = 0.0d;

// CashSuper cashSuper = CashFactory.CreateCashAccept("打8折");
CashSuper cashSuper = CashFactory.CreateCashAccept("满300返100");
// CashSuper cashSuper = CashFactory.CreateCashAccept("正常收费");
double totalPrices = 0d;

var price = 101;
var count = 3;

totalPrices = cashSuper.AcceptCash(price * count);
total += totalPrices;
Console.WriteLine(total);