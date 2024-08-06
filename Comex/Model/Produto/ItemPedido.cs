namespace Comex.Model.Produto;
internal class ItemPedido
{
    public int Quantidade { get; set; }
    public double PrecoUnitario { get; set; }
    public double SubTotal {get {return PrecoUnitario * Quantidade;}}

    private Produto Produto = new();


}
