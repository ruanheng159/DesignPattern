namespace DesignPattern;

public class OperationFactories
{
    public static Operation CreateOperation(string opera)
    {
        Operation result = null;
        switch (opera)
        {
            case "+":
                result = new OperationAdd();
                break;
            case "-":
                result = new OperationSub();
                break;
            case "*":
                result = new OperationMul();
                break;
            case "/" :
                result = new OperationDiv();
                break;
        }

        return result;
    }
        
}