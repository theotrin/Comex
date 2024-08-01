using Comex.Menus;
using Comex.Model.Produto;
using System;
using System.Text.Json;


string greetings = "Bem vindo ao Comex!\n";
Dictionary<string, Produto> produtos = new();
produtos.Add("Café", new Produto("Café", "Café preto e forte", 5,50));
produtos.Add("Leite", new Produto("Leite", "Leite com vitaminas", 10, 20));
produtos.Add("Maçã", new Produto("Maçã", "Maçã fresca", 2, 30));
produtos.Add("Salada", new Produto("Salada", "Salada verde", 3, 50));

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCadastrarProduto());
opcoes.Add(2, new MenuListarProdutos());
opcoes.Add(3, new MenuConsultarApi());
opcoes.Add(0, new MenuEncerrar());


async Task ExibirMenu()
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
    Console.WriteLine("3 Consultar API");
    Console.WriteLine("0 Encerrar o programa");
    Console.Write("\nEscolha uma opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        if (opcaoEscolhidaNumerica > 0)
        {
            Menu menu = opcoes[opcaoEscolhidaNumerica];
            Console.Clear();
            menu.Executar(produtos);
            await ExibirMenu();
        }
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

await ExibirMenu();