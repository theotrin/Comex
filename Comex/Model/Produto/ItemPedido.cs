namespace Comex.Model.Produto;
internal class ItemPedido
{

    public ItemPedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = Produto.PrecoUnitario;
    }

    public int Quantidade { get; set; }
    public double PrecoUnitario { get; set; }
    public double SubTotal {get {return PrecoUnitario * Quantidade;}}

    private Produto Produto = new();

    public void MostrarPedidoItem()
    {
        Console.WriteLine($"Produto: {Produto.Nome}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Preço: {PrecoUnitario}");
        Console.WriteLine($"Total: {SubTotal}");
    }
}
