namespace Comex.Model.Produto;
internal class Produto
{
    public Produto()
    {
    }

    public Produto(string nome, double precoUnitario, int quantidade)
    {
        Nome = nome;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public string Nome { get; protected set; }
    public string Descricao { get; set; }
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public void DetalharProduto()
    {
        Console.WriteLine("Detalhes do produto:\n");
        Console.WriteLine($"Nome: {Nome}\n" +
            $"Preço: R${PrecoUnitario}\nQuantidade em estoque: {Quantidade}");
    }
}