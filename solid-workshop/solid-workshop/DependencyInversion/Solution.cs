using solid_workshop.DependencyInjection.Entities;

namespace solid_workshop.DependencyInjection;

public class BibliotecaNova
{
    IDateTimeProvider _dateTimeProvider;

    ILivrosDataBase _livrosDataBase;

    public BibliotecaNova(
        IDateTimeProvider dateTimeProvider,
        ILivrosDataBase livrosDataBase) 
    {
        _dateTimeProvider = dateTimeProvider;
        _livrosDataBase = livrosDataBase;
    }

    public List<Livro> ObterLivros()
    {
        return _livrosDataBase.ObterLivros();
    }

    public void AdicionarLivro(Livro livro)
    {
        livro.DataCadastro = _dateTimeProvider.Now;
        _livrosDataBase.AdicionarLivro(livro);
    }
}

public interface IDateTimeProvider
{
    DateTime Now { get; }
}

public interface ILivrosDataBase
{
    List<Livro> ObterLivros();

    void AdicionarLivro(Livro livro);
}

