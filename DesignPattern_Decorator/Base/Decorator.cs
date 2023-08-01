namespace DesignPattern_Decorator;

public abstract class Decorator : Component
{
    protected Component _component;

    public void SetComponent(Component component)
    {
        this._component = component;
    }

    public override void Operation()
    {
        if (_component != null)
        {
            _component.Operation();
        }
    }
}