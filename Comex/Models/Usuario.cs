namespace Comex.Models;

internal class Usuario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public List<Livro> LivrosEmprestados { get; set; }
    protected int MaxLivrosEmprestados = 3;
    public void EmprestarLivro(Livro livro)
    {
        
        if (livro == null)
        {
            throw new ArgumentNullException(nameof(livro), "O livro não pode ser nulo.");
        }
        if (LivrosEmprestados.Count >= MaxLivrosEmprestados)
        {
            throw new InvalidOperationException("Você não pode emprestar mais de três livros ao mesmo tempo.");
        }
        if (!livro.Emprestar())
        {
            throw new InvalidOperationException("O livro não está disponível para empréstimo.");
        }
        if (LivrosEmprestados.Contains(livro))
        {
            throw new InvalidOperationException("Você já possui este livro emprestado.");
        }
        if (livro.Emprestar())
        {
            LivrosEmprestados.Add(livro);
        }
        else
        {
            throw new InvalidOperationException("Não foi possível emprestar o livro.");
        }
    }

    public void DevolverLivro(Livro livro)
    {
        if (livro == null)
        {
            throw new ArgumentNullException(nameof(livro), "O livro não pode ser nulo.");
        }
        if (LivrosEmprestados.Contains(livro))
        {
            livro.Devolver();
            LivrosEmprestados.Remove(livro);
        }
        else
        {
            throw new InvalidOperationException("Este livro não está emprestado por este usuário.");
        }
    }
    public void ExibirHistoricoEmprestimos()
    {
        if (LivrosEmprestados.Count == 0)
        {
            Console.WriteLine("Nenhum livro emprestado.");
            return;
        }

        Console.WriteLine("Histórico de Empréstimos:");
        foreach (var livro in LivrosEmprestados)
        {
            Console.WriteLine($"Título: {livro.Titulo}");
        }
    }
}
