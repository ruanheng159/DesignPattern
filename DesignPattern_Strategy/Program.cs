// See https://aka.ms/new-console-template for more information

/*
 * 需求：设计一个商店的收银机，包含正常收费，折扣，满减活动，积分
 */

using DesignPattern_Strategy;

Console.WriteLine("Hello, World!");

double total = 0.0d;

// CashSuper cashSuper = CashFactory.CreateCashAccept("打8折");
// CashSuper cashSuper = CashFactory.CreateCashAccept("正常收费");
CashContext cs = new CashContext("满300返100");
double totalPrices = 0d;

var price = 101;
var count = 3;

totalPrices = cs.GetResult(price * count);
total += totalPrices;
Console.WriteLine(total);