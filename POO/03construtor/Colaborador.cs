class Colaborador : Pessoa
{
    private string _cargo;
    private decimal _salario;

    public Colaborador(string nome, int idade, string cargo, decimal salario)
    {
        Nome = nome;
        Idade = idade;
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();
    }

    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Salario: {_salario}");
    }
}