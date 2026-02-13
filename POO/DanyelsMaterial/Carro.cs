using System.Runtime.CompilerServices;

class Carro
{
    private string _marca;
    private string _modelo;
    private int _ano;
    private string _cor;
    private int _velocidade;

    public Carro()
    {
        _marca = "";
        _modelo = "";
        _ano = 0;
        _cor = "";
        _velocidade = 0;
    }

    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }
    public string Modelo
    {
        get {return _modelo;}
        set {_modelo = value;}
    }
    public int Ano
    {
        get {return _ano;}
        set {_ano = value;}
    }
    public string Cor
    {
        get {return _cor;}
        set {_cor = value;}
    }

    public string Acelerar(int valor)
    {
        if (valor > 0)
        {
            _velocidade += valor;
            return $"Você está à {_velocidade}km/h";
        }
        return "Aceleração inválida";
    }
    public string Desacelerar(int valor)
    {
        if (valor > 0 && valor <= _velocidade)
        {
            _velocidade -= valor;
            return $"Você desacelerou para {_velocidade}km/h";
        }
        return "Desaceleração inválida";
    }
}