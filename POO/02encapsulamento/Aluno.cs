class Aluno // como fazer um construtor primario -- deixa pra ver depois
{
    // private string _nome;
    // public string Nome
    // {
    //     get{ return _nome; }
    //     set{ _nome = value; }
    // }
    public string Nome { get;} //modificadores de acesso get e set 
    public decimal Media { get; private set;}

    //construtor 
    public Aluno (string nome, List<decimal> notas)
    {
        Nome = nome;
        CalcularMedia(notas);
    }

    private void CalcularMedia(List<decimal> notas) // métodos para definição de propriedades da prorpria classe
    {
        if (notas is null || notas.Count != 3)
            throw new InvalidOperationException("É necessário 3 notas para calcular a média do aluno"); // tratamento de excessões
            // estudar como implementar uma classe de notification para notificar o usuario ao inves de exception

        Media = notas.Sum() / notas.Count;
    }

    public override string ToString() => $"O Aluno: {Nome}, obteve a média: {Media}";
}