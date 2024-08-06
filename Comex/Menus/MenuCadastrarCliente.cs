using Comex.Model.Produto;

namespace Comex.Menus;

internal class MenuCadastrarCliente : Menu
{
    public MenuCadastrarCliente(List<Cliente> todosClientes)
    {
        Clientes = todosClientes;
    }

    public List<Cliente> Clientes { get; set; }

    public override void Executar(Dictionary<string, Produto> todosProdutos)
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

        Clientes.Add(cliente);

        Console.WriteLine($"Cliente: {nome} cadastrado com sucesso!");

        EncerrarJanela();
    }
}
