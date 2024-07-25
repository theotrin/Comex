using Comex.Interface;

namespace Comex.Model.Produto;

internal class Livro : Produto, IIdenficavel
{
    public string Lsbn { get; set; }
    public int TotalDePaginas { get; set; }
    public string Autor { get; set; }

    public Livro(string nome, string lsbn)
    {
        Nome = nome;
        Lsbn = lsbn;
    }

    public string Identificar()
    {
        return $"Nome: {Nome}, Lsbn: {Lsbn}";          
    }

}
