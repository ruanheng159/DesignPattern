namespace DesignPattern_Proxy.Base;

public class Proxy : Subject
{
    private RealSubject _rs;
    public Proxy(RealSubject rs)
    {
        _rs = rs;
    }

    public override void Request()
    {
        _rs.Request();
    }
}