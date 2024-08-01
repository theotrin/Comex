namespace Comex.Menus;
using Comex.Model.Produto;
internal class MenuListarProdutos : Menu
{
    public override async void Executar(Dictionary<string, Produto> todosProdutos)
    {
        base.Executar(todosProdutos);

        Console.WriteLine("Que ordem você deseja ver os produtos?");
        Console.WriteLine("1 Por nome");
        Console.WriteLine("2 Por preço");
        string opcao = Console.ReadLine()!;

        if (opcao.Equals("1"))
        {
            Console.Clear();
            ExibirTituloDaOpcao("Lista de produtos cadastados por nome(A-Z)");

            var produtosPorNome = todosProdutos.OrderBy(pair => pair.Key)
                                                .ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var product in produtosPorNome)
            {
                Console.WriteLine($"{product.Key} - {product.Value.PrecoUnitario},00 R$");
            }
            EncerrarJanela();
        }

        if (opcao.Equals("2"))
        {
            Console.Clear();
            ExibirTituloDaOpcao("Lista de produtos cadastados por preço");

            var produtosOrdenadosAsc = todosProdutos.OrderBy(p => p.Value.PrecoUnitario);

            foreach (var product in produtosOrdenadosAsc)
            {
                Console.WriteLine($"{product.Key} - {product.Value.PrecoUnitario},00 R$");
            }
            EncerrarJanela();
        }
    }
}