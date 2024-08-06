using Comex.Model.Produto;

namespace Comex.Menus;

internal class MenuListarClientes : Menu
{
    public MenuListarClientes(Dictionary<string, Cliente> clientes)
    {
        Clientes = clientes;
    }

    public Dictionary<string, Cliente> Clientes { get; set; }


    public override async Task Executar(Dictionary<string, Produto> todosProdutos)
    {
        base.Executar(todosProdutos);
        ExibirTituloDaOpcao("Todos os clientes");

        var clientesOrdenadosPorNome = Clientes.OrderBy(cliente => cliente.Value.Nome);

        foreach(var cliente in clientesOrdenadosPorNome)
        {
            cliente.Value.ApresentarCliente();
        }
        EncerrarJanela();
    }
}
