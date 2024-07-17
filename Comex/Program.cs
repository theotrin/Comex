string greetings = "Bem vindo ao Comex!\n";
List<Produto> produtos = new List<Produto>(); 

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
    string opcao = Console.ReadLine();
    Console.WriteLine(opcao);

    switch (opcao)
    {
        case "1": CadastrarProduto();
            break;
        case "2": ListarProdutos();
            break; 
        case "0":
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPrograma feito por: Theo Trindade :D, thau thau");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"
                            ==(W{==========-      /===-
                              ||  (.--.)         /===-_---~~~~~~~~~------____
                              | \_,|**|,__      |===-~___                _,-' `
                 -==\\        `\ ' `--'   ),    `//~\\   ~~~~`---.___.-~~
             ______-==|        /`\_. .__/\ \    | |  \\           _-~`
       __--~~~  ,-/-==\\      (   | .  |~~~~|   | |   `\        ,'
    _-~       /'    |  \\     )__/==0==-\<>/   / /      \      /
  .'        /       |   \\      /~\___/~~\/  /' /        \   /'
 /  ____  /         |    \`\.__/-~~   \  |_/'  /          \/'
/-'~    ~~~~~---__  |     ~-/~         ( )   /'        _--~`
                  \_|      /        _) | ;  ),   __--~~
                    '~~--_/      _-~/- |/ \   '-~ \
                   {\__--_/}    / \\_>-|)<__\      \
                   /'   (_/  _-~  | |__>--<__|      |
                  |   _/) )-~     | |__>--<__|      |
                  / /~ ,_/       / /__>---<__/      |
                 o-o _//        /-~_>---<__-~      /
                 (^(~          /~_>---<__-      _-~
                ,/|           /__>--<__/     _-~
             ,//('(          |__>--<__|     /                  .----_
            ( ( '))          |__>--<__|    |                 /' _---_~\
         `-)) )) (           |__>--<__|    |           /'  /     ~\`\
        ,/,'//( (             \__>--<__\    \            /'  //        ||
      ,( ( ((, ))              ~-__>--<_~-_  ~--____---~' _/'/        /'
    `~/  )` ) ,/|                 ~-_~>--<_/-__       __-~ _/
  ._-~//( )/ )) `                    ~~-'_/_/ /~~~~~~~__--~
   ;'( ')/ ,)(                              ~~~~~~~~~~
  ' ') '( (/
    '   '  `
");
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
    string nome = Console.ReadLine()!;

    if(nome == "" || nome.Length < 1)
    {
        Console.WriteLine("Digite um nome válido para o produto\n");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
        Console.ReadKey();
        ExibirMenu();
    }

    Produto produto = new Produto(nome)!;

    produtos.Add(produto);

    Console.WriteLine("\nProduto adcionado com sucesso!");

    produto.DeatalharProduto();

    EncerrarJanela();
}

void ListarProdutos()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de produtos cadastados");

    foreach (var produto in produtos)
    {
        Console.WriteLine(produto.Nome);
    }

    EncerrarJanela();
}

void EncerrarJanela()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal...");
    Console.ForegroundColor = ConsoleColor.Gray;
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();



//Console.WriteLine($"Nome: {produto1.Nome} ");
Endereco endereco01 = new Endereco("Jardim Adriana","Manaus", "Quadra 4", "Amazonas", "Jõao Braga", 16);
