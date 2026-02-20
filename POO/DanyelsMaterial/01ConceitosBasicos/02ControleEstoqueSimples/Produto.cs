class Produto
{
    private string _nome;
    private decimal _preco;
    private int _quantidade;

    public string Nome
    {
        get { return _nome; }
        set {
                string mensagemSeErro = $"O {nameof(Nome)} não pode ser nulo ou conter apenas espaços";
                ArgumentException.ThrowIfNullOrWhiteSpace(value, mensagemSeErro);
                _nome = value; 
            }
    }
    public decimal Preco
    {
        get { return _preco; }
        set {
                string mensagemSeErro = $"O {nameof(Preco)} não pode ser zero ou negativo";
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, mensagemSeErro);
                _preco = value;
            }
    }
    public int Quantidade
    {
        get { return _quantidade; }
        set {
                string mensagemSeErro = $"O {nameof(Quantidade)} não pode negativo";
                ArgumentOutOfRangeException.ThrowIfNegative(value, mensagemSeErro);
                _quantidade = value; 
            }
    }

    public void AdicionarEstoque(int quantidade)
    {
        string mensagemSeErro = $"O {nameof(quantidade)} não pode ser zero ou negativo";
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantidade, mensagemSeErro);
        _quantidade += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        string mensagemSeErroZeroOuNegativo = $"O {nameof(quantidade)} não pode ser zero ou negativo";
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantidade, mensagemSeErroZeroOuNegativo);
        if (_quantidade - quantidade < 0)
        {
            string mensagemSeErroRemoverMaiorQueEstoque = $"A quantiade removida não pode ser maior que a guardada.";
            throw new InvalidOperationException(mensagemSeErroRemoverMaiorQueEstoque);
        }
        _quantidade -= quantidade;
    }

    public override string ToString()
    {
        return $"Nome: {_nome} | Preço: R$ {_preco} | Quantidade: {_quantidade}";
    }


}