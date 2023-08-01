namespace DesignPattern_Decorator;

public class ConcreteDecoratorA : Decorator
{
    private string addedState;
    
    public override void Operation()
    {
        base.Operation();
        addedState = "New State";
        Console.WriteLine("具体装饰对象 A 的操作");
    }
}