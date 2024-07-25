using Comex.Menus;
using Comex.Model.Produto;

string greetings = "Bem vindo ao Comex!\n";
Dictionary<string, Produto> produtos = new ();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCadastrarProduto());
opcoes.Add(2, new MenuListarProdutos());
opcoes.Add(0, new MenuEncerrar());


void ExibirMenu()
{
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");
    Console.WriteLine(greetings);

    Console.WriteLine("1 Criar Produto");
    Console.WriteLine("2 Listar Produtos");
    Console.WriteLine("0 Encerrar o programa");
    Console.Write("\nEscolha uma opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menu = opcoes[opcaoEscolhidaNumerica];
        menu.Executar(produtos);

        if(opcaoEscolhidaNumerica == 0) return;

        ExibirMenu();
    }
    else
    {
        Console.WriteLine("\nOpção inválida");
        Console.WriteLine("Voltando ao menu principal...");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
}

//ExibirMenu();

Livro coraline = new Livro("Coraline", "XXT66");

Console.WriteLine(coraline.Identificar);

//Endereco endereco01 = new Endereco("Jardim Adriana","Manaus", "Quadra 4", "Amazonas", "Jõao Braga", 16);
