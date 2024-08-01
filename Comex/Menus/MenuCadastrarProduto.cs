namespace Comex.Menus;
using Comex.Model.Produto;

internal class MenuCadastrarProduto : Menu
{
    public override async void Executar(Dictionary<string, Produto> todosProdutos)
    {
        base.Executar(todosProdutos);

        ExibirTituloDaOpcao("Cadastrar novo produto");

        Console.Write("\nDigite o nome do novo produto: ");
        string nomeProduto = Console.ReadLine()!;

        Console.Write("\nDigite o preço unitario do novo produto: ");
        double preco = double.Parse(Console.ReadLine()!);

        Console.Write("\nDigite a descrição do novo produto: ");
        string descricao = Console.ReadLine()!;

        Console.Write("\nDigite a quantidade de estoque disponivel do produto: ");
        int quantidadeEstoque = int.Parse(Console.ReadLine()!);

        if (nomeProduto == "" || nomeProduto.Length < 1)
        {
            Console.WriteLine("Digite um nome válido para o produto\n");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }

        if (descricao == "" || descricao.Length < 1)
        {
            Console.WriteLine("Digite uma descrição válida para o produto\n");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }

        if (preco < 1)
        {
            Console.WriteLine("Digite um preço válido ou maior que 0 para o produto\n");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }

        if (quantidadeEstoque < 1)
        {
            Console.WriteLine("A quantidade disponivel para o produto precisa ser maior que 1\n");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            return;
        }

        Produto produto = new Produto(nomeProduto, descricao, preco, quantidadeEstoque);

        todosProdutos.Add(produto.Nome, produto);

        Console.WriteLine($"\nProduto {nomeProduto} adcionado com sucesso!");

        EncerrarJanela();
    }
}