using solid_workshop.DependencyInjection.Entities;

namespace solid_workshop.DependencyInjection;

public class Biblioteca
{
    public List<Livro> ObterLivros()
    {
        LivrosDataBase database = new LivrosDataBase();
        return database.ObtemLivros();
    }

    public void AdicionarLivro(Livro livroNovo)
    {
        LivrosDataBase database = new LivrosDataBase();

        livroNovo.DataCadastro = DateTime.Now;
        database.AdicionarLivro(livroNovo);
    }
}
