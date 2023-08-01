namespace DesignPattern_Decorator;

public class ConcreteDecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
        AddBehavior();
        Console.WriteLine("具体装饰对象 B 的操作");
    }

    private void AddBehavior()
    {
        
    }
}