namespace DesignPattern_Proxy.Demo;

public class Pursuit : IGiveGift
{
    private SchollGirl _schollGirl;

    public Pursuit(SchollGirl mm)
    {
        _schollGirl = mm;
    }
    
    public void GiveDolls()
    {
        Console.WriteLine($"{_schollGirl.Name} 送你洋娃娃");
    }

    public void GiveFlowers()
    {
        Console.WriteLine($"{_schollGirl.Name} 送你花");
    }

    public void GiveChocolate()
    {
        Console.WriteLine($"{_schollGirl.Name} 送你巧克力");
    }
}