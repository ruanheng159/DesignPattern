namespace DesignPattern_Strategy;

public class CashNormal : CashSuper
{
    public override double AcceptCash(double money)
    {
        return money;
    }
}