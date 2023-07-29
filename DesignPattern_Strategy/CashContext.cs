namespace DesignPattern_Strategy;

public class CashContext
{
    CashSuper cs = null;
    public CashContext(string type)
    {
        switch (type)
        {
            case "正常收费":
               CashNormal cs0 = new CashNormal();
               cs = cs0;
               break;
            case "满300返100":
                CaseReturn cr1 = new CaseReturn("300", "100");
                cs = cr1;
                break;
            case "打8折":
                CashRebate cr2 = new CashRebate("0.8");
                cs = cr2;
                break;
        }
    }

    public double GetResult(double money)
    {
        return cs.AcceptCash(money);
    }
}