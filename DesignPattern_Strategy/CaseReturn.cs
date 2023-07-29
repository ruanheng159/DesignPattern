namespace DesignPattern_Strategy;

public class CaseReturn : CashSuper
{
    private double moneyCondition = 0.0d;
    private double moneyReturn = 0.0d;

    public CaseReturn(string moneyCondition, string moneyReturn)
    {
        this.moneyCondition = double.Parse(moneyCondition);
        this.moneyReturn = double.Parse(moneyReturn);
    }

    public override double AcceptCash(double money)
    {
        double result = money;
        if (money > moneyCondition)
        {
            result = money - Math.Floor(money / moneyCondition) * moneyReturn;
        }

        return result;
    }
}