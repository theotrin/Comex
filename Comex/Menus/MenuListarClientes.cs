using Comex.Model.Produto;

namespace Comex.Menus;

internal class MenuListarClientes : Menu
{
    public MenuListarClientes(List<Cliente> clientes)
    {
        Clientes = clientes;
    }

    public List<Cliente> Clientes { get; set; }


    public override void Executar(Dictionary<string, Produto> todosProdutos)
    {
        base.Executar(todosProdutos);
        ExibirTituloDaOpcao("Todos os clientes");

        var clientesOrdenadosPorNome = Clientes.OrderBy(cliente => cliente.Nome);

        foreach(var cliente in clientesOrdenadosPorNome)
        {
            cliente.ApresentarCliente();
        }
        EncerrarJanela();
    }
}
