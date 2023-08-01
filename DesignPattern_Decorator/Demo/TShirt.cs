namespace DesignPattern_Decorator.Demo;

public class TShirt : Finery
{
    public override void Show()
    {
        Console.WriteLine("T-Shirt");
        base.Show();
    }
}