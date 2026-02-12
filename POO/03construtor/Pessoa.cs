class Pessoa
{
    protected string Nome;
    protected int Idade;

    protected void ApresentarPessoa()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }
};