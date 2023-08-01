namespace DesignPattern_Decorator.Demo;

public class Finery : Person
{
    protected Person _component;

    public void Decorate(Person component)
    {
        this._component = component;
    }

    public override void Show()
    {
        if (_component != null)
        {
            _component.Show();
        }
    }
}