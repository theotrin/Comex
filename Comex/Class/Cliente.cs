﻿class Cliente
{
    public Cliente(string nome, string cpf, string email, string telefone, Endereco endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
    }

    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public void ApresentarCliente()
    {
        Console.WriteLine("Dados do Cliente: \n");

        Console.WriteLine($"Nome: {Nome}.\nCPF: {Cpf}.\nEmail: {Email}.\n" +
            $"Profissão: {Profissao}.\nTelefone: {Telefone}.\n");
        Endereco.MostrarEndereco();
    }
}