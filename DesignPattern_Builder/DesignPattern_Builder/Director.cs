namespace DesignPattern_Builder;

public class Director
{
    public void Construct(Builder builder)
    {
        builder.BuilderA();
        builder.BuilderB();
    }
}