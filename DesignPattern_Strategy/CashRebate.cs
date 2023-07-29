namespace DesignPattern_Strategy;

public class CashRebate : CashSuper
{
    private double moneyRebate = 1d;

    public CashRebate(string moneyRebate)
    {
        this.moneyRebate = double.Parse(moneyRebate);
    }
    public override double AcceptCash(double money)
    {
        return money * moneyRebate;
    }
}