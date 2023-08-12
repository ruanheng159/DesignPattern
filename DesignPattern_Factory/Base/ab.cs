namespace DesignPattern_Factory.Base;

public abstract class Operation
{
    public double NumberA { get; set; }
    public double NumberB { get; set; }

    public abstract double GetResult();
}