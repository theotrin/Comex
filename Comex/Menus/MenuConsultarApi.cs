using Comex.Model.Produto;
using System.Text.Json;

namespace Comex.Menus;

internal class MenuConsultarApi : Menu
{
    public override async void Executar(Dictionary<string, Produto> todosProdutos)
    {   
        try
        {
            HttpClient cliente = new HttpClient();
            base.Executar(todosProdutos);
            string resposta = await cliente.GetStringAsync("https://fakestoreapi.com/products");

            var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;

            produtos[0].DetalharProduto();
            EncerrarJanela();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
