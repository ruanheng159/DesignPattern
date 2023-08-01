namespace DesignPattern_Decorator.Demo;

/// <summary>
/// ConcreteComponent
/// </summary>
public class Person
{
    public Person()
    {
    }

    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine($"装扮的{name}");
    }
}