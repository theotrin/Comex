using Comex.Model.Produto;
namespace Comex.Menus;

internal class MenuEncerrar : Menu
{
    public override void Executar(Dictionary<string, Produto> todosProdutos)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nPrograma feito por: Theo Trindade :D, thau thau");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\nComputador Hackeado a partir daqui...");
    }
}
