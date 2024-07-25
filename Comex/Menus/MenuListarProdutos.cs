namespace Comex.Menus;
using Comex.Model.Produto;
internal class MenuListarProdutos : Menu
{
    public override void Executar(Dictionary<string, Produto> todosProdutos)
    {
        base.Executar(todosProdutos);

        ExibirTituloDaOpcao("Lista de produtos cadastados");

        foreach (var produto in todosProdutos.Values)
        {
            Console.WriteLine(produto.Nome);
        }

        EncerrarJanela();
    }
}
