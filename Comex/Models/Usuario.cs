namespace Comex.Models;

internal class Usuario
{

    public string Nome { get; set; }
    public string CPF { get; set; }
    public List<Livro> LivrosEmprestados = new();
    public void EmprestarLivro(Livro livro)
    {

        if (livro == null)
        {
            Console.WriteLine("O livro não pode ser nulo.");
            return;
        }
        if (!livro.Emprestar())
        {
            Console.WriteLine("O livro não está disponível para empréstimo.");
            return;
        }
        else
        {
            if (livro.Emprestar())
            {
                LivrosEmprestados.Add(livro);
            }
            else
            {
                Console.WriteLine("Não foi possível emprestar o livro.");
                return;
            }
        }
    }

    public void DevolverLivro(Livro livro)
    {
        if (livro == null)
        {
            Console.WriteLine("O livro não pode ser nulo.");
            return;
        }
        if (LivrosEmprestados.Contains(livro))
        {
            livro.Devolver();
            LivrosEmprestados.Remove(livro);
        }
        else
        {
            Console.WriteLine("Este livro não está emprestado por este usuário.");
            return;
        }
    }
    public void ExibirHistoricoEmprestimos()
    {

        Console.WriteLine("Histórico de Empréstimos:");
        foreach (var livro in LivrosEmprestados)
        {
            Console.WriteLine($"Título: {livro.Titulo}");
        }
    }
}
