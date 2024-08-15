namespace Comex.Models;

internal class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public DateTime DataPublicacao { get; set; }
    public  bool EstaEmprestado { get; set; }

    public Boolean Emprestar()
    {
        if (EstaEmprestado)
        {
            Console.WriteLine("Este livro não esta disponivel :/");
            return false;
        }
        EstaEmprestado = true;
        Console.WriteLine($"Livro: {Titulo} emprestado com sucesso!");
        return true;
    }
    public void Devolver()
    {
        if (!EstaEmprestado)
        {
        Console.WriteLine($"O Livro: {Titulo} não esta emprestado e portanto não precisa ser devolvido :)");
            return;
        }
        Console.WriteLine($"Obrigado por devolver: {Titulo}, volte sempre!");
        EstaEmprestado = false;
    }
    public void ExibirInformacoes()
    {
        string estoque = EstaEmprestado ? "Não" : "Sim";
        Console.WriteLine($"Titulo: {Titulo} \n" +
            $"Autor: {Autor}\n" +
            $"Data de publicação: {DataPublicacao}\n" +
            $"Esta em estoque: {estoque}");

    }
}
