namespace DesignPattern_Factory.Base;

public class AddFactory : IFactory
{
    private OperationAdd _operationAdd;

    public AddFactory(OperationAdd operationAdd)
    {
        this._operationAdd = operationAdd;
    }
    
    public void CreateOperation()
    {
        _operationAdd.GetResult();
    }
}