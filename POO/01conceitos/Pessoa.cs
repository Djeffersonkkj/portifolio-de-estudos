class Pessoa
{
    //Atributos
    public string Nome;
    public int Idade;

    //Funções
    public void Apresentacao()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }
    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }
}