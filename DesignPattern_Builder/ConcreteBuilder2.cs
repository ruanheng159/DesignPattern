namespace DesignPattern_Builder;

public class ConcreteBuilder2 : Builder
{
    private Product _product = new Product();
    
    public override void BuilderA()
    {
        _product.Add("部件X");
    }

    public override void BuilderB()
    {
        _product.Add("部件Y");
    }

    public override Product GetResult()
    {
        return _product;
    }
}