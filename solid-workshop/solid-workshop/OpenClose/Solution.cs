namespace solid_workshop.OpenClose;

public class AplicacaoServiceNew
{
    private IIntegrador _integrador;

    public AplicacaoServiceNew(IIntegrador integrador)
    {
        _integrador = integrador;
    }

    public void Integra()
    {
        _integrador.Integrar();
    }

}

public interface IIntegrador
{
    bool Integrar();
}

public class IntegradorEmailNovo : IIntegrador
{
    public bool Integrar()
    {
        return true;
    }
}

public class IntegradorApi : IIntegrador
{
    public bool Integrar()
    {
        return true;
    }
}

