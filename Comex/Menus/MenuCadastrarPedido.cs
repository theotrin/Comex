using Comex.Model.Produto;

namespace Comex.Menus;

internal class MenuCadastrarPedido : Menu
{
    public MenuCadastrarPedido(Dictionary<string, Cliente> clientes,List<Pedido> pedidos)
    {
        Clientes = clientes;
        Pedidos = pedidos;
    }

    protected List<Pedido> Pedidos { get; set; }
    protected Dictionary<string, Cliente> Clientes { get; set; }

    public override async Task Executar(Dictionary<string, Produto> todosProdutos)
    {
        base.Executar(todosProdutos);
        ExibirTituloDaOpcao("Cadastrar novo pedido");

        try
        {
            Console.Write("Qual o nome do cliente que fez o pedido?: ");
            string nomeCliente = Console.ReadLine()!;
            Cliente cliente = Clientes[nomeCliente];

            Pedido pedidoAtual = new(cliente);
            Console.Write("Que produto você gostaria de adcionar ao carrinho?: ");
            string produtoNome = Console.ReadLine()!;

            var produto = todosProdutos[produtoNome];
            Console.Write($"Qual a quantidade de {produtoNome} que você deseja?");
            int produtoQuantidade = int.Parse(Console.ReadLine()!);

            ItemPedido pedido = new(todosProdutos[produtoNome], produtoQuantidade);
            pedidoAtual.AdcionarItem(pedido);

            Pedidos.Add(pedidoAtual);
            Console.WriteLine($"{produtoNome} adcionado com sucesso!\n");
            Console.WriteLine($"Gostaria de adcionar outro pedido ao carrinho? s/n");
            var opcao = Console.ReadKey();

            switch (opcao.Key)
            {
                case ConsoleKey.S:
                    Console.Clear();
                    await Executar(todosProdutos);
                    break;
                case ConsoleKey.N:
                    EncerrarJanela();
                    break;
                default:
                    Console.WriteLine("somente opções s(sim) e n(não) são válidas!");
                    break;
            }


        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("\n(Error 404) Informação encontrada no sistema...");
            EncerrarJanela();
        }
    }     
}
