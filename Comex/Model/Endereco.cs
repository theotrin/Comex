class Endereco
{
    public Endereco(string bairro, string cidade, string complemento, string estado, string rua, int numero)
    {
        Bairro = bairro;
        Cidade = cidade;
        Complemento = complemento;
        Estado = estado;
        Rua = rua;
        Numero = numero;
    }

    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Complemento { get; set; }
    public string Estado { get; set; }
    public string Rua { get; set; }
    public int Numero { get; set; }

    public void MostrarEndereco()
    {
        Console.WriteLine("Dados do endereço:\n");
        Console.WriteLine($"Bairro: {Bairro}\nCidade: {Cidade}\nComplemento: {Complemento}\nRia: {Rua}\nNumero: {Numero}");
    }

}