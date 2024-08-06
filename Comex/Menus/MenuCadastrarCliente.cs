using Comex.Model.Produto;

namespace Comex.Menus;

internal class MenuCadastrarCliente : Menu
{
    public MenuCadastrarCliente(Dictionary<string, Cliente> todosClientes)
    {
        Clientes = todosClientes;
    }

    public Dictionary<string, Cliente> Clientes { get; set; }

    public override async Task Executar(Dictionary<string, Produto> todosProdutos)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Cadastrar novo cliente!");

        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine()!;

        Console.Write("CPF do cliente: ");
        string cpf = Console.ReadLine()!;

        Console.Write("E-mail do cliente: ");
        string email = Console.ReadLine()!;

        Console.Write("Telefone para contato: ");
        string telefone = Console.ReadLine()!;

        Cliente cliente = new(nome,cpf,email, telefone);

        Clientes.Add(nome,cliente);

        Console.WriteLine($"Cliente: {nome} cadastrado com sucesso!");

        EncerrarJanela();
    }
}
