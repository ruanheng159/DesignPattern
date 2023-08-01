namespace DesignPattern_Proxy.Base;

public class RealSubject : Subject
{
    public override void Request()
    {
        Console.WriteLine("真实请求");
    }
}