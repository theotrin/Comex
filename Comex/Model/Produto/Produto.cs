using System.Text.Json;
using System.Text.Json.Serialization;

namespace Comex.Model.Produto;
internal class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    public Produto()
    {
    }

    public Produto(string nome, string descricao, double precoUnitario, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        PrecoUnitario = precoUnitario;
        //Quantidade = Rating.Count;
    }

    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("description")]
    public string Descricao { get; set; }
    [JsonPropertyName("price")]
    public double PrecoUnitario { get; set; }
    [JsonPropertyName("rating")]
    public Rating Rating { get; set; }
    [JsonIgnore]
    public int Quantidade => Rating?.Count ?? 0;

    public void DetalharProduto()
    {
        Console.WriteLine("Detalhes do produto:\n");
        Console.WriteLine($"Nome: {Nome}" +
            $"\nDescrição: {Descricao}" +
            $"\nPreço: R${PrecoUnitario}" +
            $"\nQuantidade em estoque: {Quantidade}");
    }
}