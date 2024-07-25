namespace Comex.Model.Produto;
internal class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    public Produto()
    {
    }

    public Produto(string nome, string descricao, double precoUnitario, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
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
        Console.WriteLine($"Nome: {Nome}\nDescrição: {Descricao}\n" +
            $"Preço: R${PrecoUnitario}\nQuantidade em estoque: {Quantidade}");
    }
}