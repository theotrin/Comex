string greetings = "Bem vindo ao Comex!\n";
List<string> produtos = new List<string>(); 

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
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1: CadastrarProduto();
            break;
        case 2: ListarProdutos();
            break; 
        case 0: Console.WriteLine("\nPrograma feito por: Theo Trindade :D, thau thau");
            break;
        default: 
            Console.WriteLine("Opção inválida! tente novamente");
            Thread.Sleep(3000);
            Console.Clear();
            ExibirMenu();
            break;

    }
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void CadastrarProduto()
{
    Console.Clear();
    ExibirTituloDaOpcao("Cadastrar novo produto");

    Console.Write("\nDigite o nome do novo produto: ");
    string novoProduto = Console.ReadLine()!;
    Console.WriteLine($"\nO produto: {novoProduto} cadastrado com sucesso!");
    produtos.Add(novoProduto);

    Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ListarProdutos()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de produtos cadastados");

    foreach (var produto in produtos)
    {
        Console.WriteLine(produto.ToString());
    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();

