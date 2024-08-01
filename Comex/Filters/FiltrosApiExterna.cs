using Comex.Menus;
using Comex.Model.Produto;
using System.Text.Json;

namespace Comex.Filters;

internal class FiltrosApiExterna
{
    private static readonly HttpClient cliente = new HttpClient();
    public static async Task ProdutosPorTitulo()
    {
        try
        {
            Console.Clear();
            string resposta = await (cliente.GetStringAsync("https://fakestoreapi.com/products"));
            var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);
            var produtosPorTitulo = produtos!.OrderBy(produto => produto.Nome).ToList();

            foreach (var produto in produtosPorTitulo)
            {
                produto.DetalharProduto();            }           
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }

    internal static async Task ProdutosPorPreco()
    {
        try
        {
            Console.Clear();
            string resposta = await (cliente.GetStringAsync("https://fakestoreapi.com/products"));
            var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);
            var produtosPorPreco = produtos!.OrderBy(produto => produto.PrecoUnitario).ToList();

            foreach (var produto in produtosPorPreco)
            {
                produto.DetalharProduto();
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
}
}

