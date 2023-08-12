namespace DesignPattern_Builder;

public class ConcreteBuilder1 : Builder
{
    private Product _product = new Product();
    
    public override void BuilderA()
    {
        _product.Add("部件A");
    }

    public override void BuilderB()
    {
        _product.Add("部件B");
    }

    public override Product GetResult()
    {
        return _product;
    }
}