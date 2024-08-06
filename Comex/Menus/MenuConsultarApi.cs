using Comex.Filters;
using Comex.Model.Produto;

namespace Comex.Menus;

internal class MenuConsultarApi : Menu
{
    public override async Task Executar(Dictionary<string, Produto> todosProdutos)
    {
        try
        {
        ExibirTituloDaOpcao("Dados da API");
        Console.WriteLine("1 - Mostrar todos os produtos ordenados por nome");
        Console.WriteLine("2 - Mostrar todos os produtos ordenados por preço");

        Console.WriteLine("\nDigite a opção desejada: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch(opcaoEscolhidaNumerica)
            {     
                case 1:
                    await Task.FromResult(FiltrosApiExterna.ProdutosPorTitulo());
                    Thread.Sleep(3000);
                    break;

                case 2:
                    await Task.FromResult(FiltrosApiExterna.ProdutosPorPreco());
                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            EncerrarJanela();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
