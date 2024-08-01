using Comex.Model.Produto;

namespace Comex.Menus
{
    internal abstract class Menu
    {

        public virtual void Executar(Dictionary<string, Produto> todosProdutos)
        {
            
        }

        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

       public void EncerrarJanela()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }
    }
}
