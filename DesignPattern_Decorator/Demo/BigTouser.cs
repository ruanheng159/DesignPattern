namespace DesignPattern_Decorator.Demo;

public class BigTrouser : Finery
{
    public override void Show()
    {
        Console.WriteLine("Big Trouser");
        base.Show();
    }
}