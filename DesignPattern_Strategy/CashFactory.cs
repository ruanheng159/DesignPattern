namespace DesignPattern_Strategy;

public class CashFactory
{
    public static CashSuper CreateCashAccept(string type)
    {
        CashSuper cs = null;
        switch (type)
        {
            case "正常收费":
                cs = new CashNormal();
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

        return cs;
    }
}