using Comex.Model.Produto;

namespace Comex.Menus;

internal class MenuListarPedidos : Menu
{
    public MenuListarPedidos(List<Pedido> pedidos)
    {
        Pedidos = pedidos;
    }
    public List<Pedido> Pedidos { get; set; }

   public override async Task Executar(Dictionary<string, Produto> todosProdutos)
    {
        base.Executar(todosProdutos);
        ExibirTituloDaOpcao("Todos os pedidos");

        foreach(var pedido in Pedidos)
        {
            pedido.MostrarPedido();
            Console.WriteLine("\n");
        }

        EncerrarJanela();
    }
    }
