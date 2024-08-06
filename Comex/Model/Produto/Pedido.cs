namespace Comex.Model.Produto;

internal class Pedido
{
    public Cliente Cliente { get; set; }
    public DateTime Data { get; set; }
    public List<ItemPedido> Itens = new();
    public double Total { get; }

    public void AdcionarItem (ItemPedido item)
    {
        Itens.Add(item);
    }
}
