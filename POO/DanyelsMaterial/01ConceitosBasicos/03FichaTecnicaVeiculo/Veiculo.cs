class Veiculo
{
    private string _marca;
    private string _modelo;
    private int _ano;
    private int _velocidadeAtual = 0;

    public string Marca
    {
        get { return _marca; }
        set { _marca = value.ToUpper(); }
    }
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    public int Ano
    {
        get{ return _ano; }
        set
        {
            if (value < 1900 || value > DateTime.Now.Year)
            {
                string mensagemSeErro = "O valor precisa estar entre 1900 e o ano atual.";
                throw new ArgumentOutOfRangeException(mensagemSeErro);
            }
            _ano = value;
        }
    }
    public int VelocidadeAtual
    {
        get {return _velocidadeAtual;}
    }


    public void Acelerar(int incremento)
    {
        if (incremento <= 0)
        {
            string mensagemSeErro = "O incremento deve ser positivo!";
            throw new ArgumentOutOfRangeException(mensagemSeErro);
        }
        if (incremento + _velocidadeAtual > 200)
        {
            string mensagemSeErro = "A velocidade não pode exceder 200km/h";
            throw new InvalidOperationException(mensagemSeErro);
        }
        _velocidadeAtual += incremento;
    }

    public void Frear(int decremento)
    {
        if (decremento <= 0)
        {
            string mensagemSeErro = "O decremento não pode ser menor ou igual a 0!";
            throw new ArgumentOutOfRangeException(mensagemSeErro);
        }
        if (decremento - _velocidadeAtual < 0)
        {
            string mensagemSeErro = "O veículo não pode ficar a menos que 0km/h";
            throw new InvalidOperationException(mensagemSeErro);
        }
        _velocidadeAtual -= decremento;
    }

    public string ObterFichaTecnica()
    {
        return $"Marca: {_marca} | Modelo: {_modelo} | Ano: {_ano} | Velocidade Atual: {_velocidadeAtual}";
    }

    public bool EstaEmMovimento()
    {
        if (_velocidadeAtual > 0)
        {
            return true;
        }
        return false;
    }
}