using Comex.Models;

var livro1 = new Livro { Titulo = "O Senhor dos Anéis" };
var livro2 = new Livro { Titulo = "Harry Potter e a Pedra Filosofal" };
var livro3 = new Livro { Titulo = "O Hobbit" };
var livro4 = new Livro { Titulo = "1984" };

List<Livro> livros = new List<Livro> { livro1, livro2, livro3, livro4 };

var usuario1 = new Usuario { Nome = "Alice", CPF = "12345678900" };
var usuario2 = new Usuario { Nome = "Bob", CPF = "09876543211" };

var usuarios = new List<Usuario> { usuario1, usuario2 };

usuario1.EmprestarLivro(livro1);
usuario1.EmprestarLivro(livro2);
usuario2.EmprestarLivro(livro3); 
usuario2.EmprestarLivro(livro4);

Console.WriteLine("\nHistórico de Empréstimos do usuário Alice:");
usuario1.ExibirHistoricoEmprestimos();

usuario1.DevolverLivro(livro1);

Console.WriteLine("\nHistórico de Empréstimos do usuário Alice após devolução:");
usuario1.ExibirHistoricoEmprestimos();

usuario1.EmprestarLivro(livro1);

Console.WriteLine("\nHistórico de Empréstimos do usuário Alice após reempréstimo:");
usuario1.ExibirHistoricoEmprestimos();