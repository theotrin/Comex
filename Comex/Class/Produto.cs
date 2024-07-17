class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    public Produto(string nome, string descricao, double precoUnitario, int quantidade)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public string Descricao { get; set; }
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public void DeatalharProduto()
    {
        Console.WriteLine("Detalhes do produto:\n");
        Console.WriteLine($"Nome: {Nome}\nDescrição: {Descricao}\n" +
            $"Preço: R${PrecoUnitario}\nQuantidade em estoque: {Quantidade}");
    }
}