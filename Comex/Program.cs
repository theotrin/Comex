using Comex.Models;

var livro1 = new Livro { Titulo = "O Senhor dos Anéis" };
var livro2 = new Livro { Titulo = "Harry Potter e a Pedra Filosofal" };
var livro3 = new Livro { Titulo = "O Hobbit" };
var livro4 = new Livro { Titulo = "1984" };

// Adicionar livros a uma lista de livros disponíveis
var livros = new List<Livro> { livro1, livro2, livro3, livro4 };

// Criar alguns usuários
var usuario1 = new Usuario { Nome = "Alice", CPF = "12345678900" };
var usuario2 = new Usuario { Nome = "Bob", CPF = "09876543211" };

// Adicionar usuários a uma lista de usuários
var usuarios = new List<Usuario> { usuario1, usuario2 };

// Adicionar livros à lista de livros disponíveis (simulando a adição ao sistema)
livros.ForEach(l => Console.WriteLine($"Livro adicionado: {l.Titulo}"));

// Registrar usuários
usuarios.ForEach(u => Console.WriteLine($"Usuário registrado: {u.Nome}"));

// Emprestar livros
usuario1.EmprestarLivro(livro1);
usuario1.EmprestarLivro(livro2);
usuario2.EmprestarLivro(livro3); 
usuario2.EmprestarLivro(livro4);

// Mostrar histórico de empréstimos do usuário1
Console.WriteLine("\nHistórico de Empréstimos do usuário Alice:");
usuario1.ExibirHistoricoEmprestimos();

// Devolver livro
usuario1.DevolverLivro(livro1);

// Mostrar histórico de empréstimos do usuário1 após devolução
Console.WriteLine("\nHistórico de Empréstimos do usuário Alice após devolução:");
usuario1.ExibirHistoricoEmprestimos();

// Tentar emprestar novamente o livro devolvido
usuario1.EmprestarLivro(livro1);

// Mostrar histórico de empréstimos do usuário1 após reempréstimo
Console.WriteLine("\nHistórico de Empréstimos do usuário Alice após reempréstimo:");
usuario1.ExibirHistoricoEmprestimos();