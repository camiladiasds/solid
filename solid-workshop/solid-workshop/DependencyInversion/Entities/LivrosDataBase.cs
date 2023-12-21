namespace solid_workshop.DependencyInjection.Entities;

public class Livro
{
    public string Name { get; set; }

    public DateTime DataCadastro { get; set; }
}

public class LivrosDataBase
{
    public List<Livro> ObtemLivros()
    {
        return new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    { 
    }
}
