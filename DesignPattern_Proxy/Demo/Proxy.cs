namespace DesignPattern_Proxy.Demo;

public class Proxy : IGiveGift
{
    private Pursuit _schollBoy;
    public Proxy(SchollGirl mm)
    {
        _schollBoy = new Pursuit(mm);
    }
    
    public void GiveDolls()
    {
        _schollBoy.GiveDolls();
    }

    public void GiveFlowers()
    {
        _schollBoy.GiveFlowers();
    }

    public void GiveChocolate()
    {
        _schollBoy.GiveChocolate();
    }
}