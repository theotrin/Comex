namespace Comex.Model.Produto;

internal class Pedido
{
    public Cliente Cliente { get; set; }
    public DateTime Data { get; set; }
    public List<ItemPedido> Itens = new();
    public double Total { get; }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
    }

    public void AdcionarItem (ItemPedido item)
    {
        Itens.Add(item);
    }

    public void MostrarPedido()
    {
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"Lista de pedidos:\n");
        foreach(var item in Itens) item.MostrarPedidoItem();
    }
}
