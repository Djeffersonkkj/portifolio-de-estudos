class Aluno
{
    private string _nome;
    private int _idade;
    private string _turma;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public int Idade
    {
        get { return _idade; }
        set { _idade = value; }
    }
    public string Turma
    {
        get { return _turma; }
        set { _turma = value; }
    }

    public string ApresentarSe()
    {
        return $"Olá, meu nome é {_nome}! Tenho {_idade} anos e estou na turma {_turma}";
    }
}