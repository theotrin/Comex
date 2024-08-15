namespace Comex.Models;
internal class Biblioteca
{
    public List<Livro> Livros{ get; set; }
    public List<Usuario> Usuarios{ get; set; }

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }

    public void RemoverLivro(Livro livro)
    {
        Livros.Remove(livro);
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
    }

    public void ExibirLivrosDisponiveis()
    {
        Console.WriteLine("Lista de livros disponiveis:\n");
        foreach (var livro in Livros)
        {
            Console.WriteLine($"-{livro.Titulo}");
        }
    }
}
