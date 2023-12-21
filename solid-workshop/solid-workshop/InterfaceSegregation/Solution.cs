namespace solid_workshop.InterfaceSegregation;

public interface IAcomodadorDeCompras
{
    void Esvazia();

    void AdicionaItem(string item);
}

public interface IAcomodaCriaca
{
    void AcomodarCrianca(string crianca);
}

public class CarrinhoNovo : ICarrinhoDeCompra, IAcomodaCriaca
{
    public void AcomodarCrianca(string crianca)
    {
        //
    }

    public void AdicionaItem(string item)
    {
        //
    }

    public void Esvazia()
    {
        //
    }
}

public class CestaNova : IAcomodadorDeCompras
{
    public void AdicionaItem(string item)
    {
        throw new NotImplementedException();
    }

    public void Esvazia()
    {
        throw new NotImplementedException();
    }
}

