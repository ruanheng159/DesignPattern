namespace DesignPattern_Decorator;

public class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("具体对象操作");
    }
}