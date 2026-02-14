using System.ComponentModel;

class Macaco
{
    private readonly List<Banana> _bananas;
    public string Nome { get; private set; }
    public int Energia { get; private set; }

    public IReadOnlyList<Banana> Bananas => _bananas;

    public Macaco(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome não pode ser nulo ou conter apenas espaços.");
        }
        Nome = nome;
        Energia = 100;
        _bananas = [];
    }

    public void PegarBanana(Banana bananaPega)
    {
        ArgumentNullException.ThrowIfNull(bananaPega);

        _bananas.Add(bananaPega);
        Energia -= 1;
    }

    public void ComerBanana(int indiceBananaComida)
    {
        if (_bananas.Count == 0)
        {
            throw new InvalidOperationException("O macaco não possui bananas para comer.");
        } 
        Banana BananaComida = _bananas[indiceBananaComida];

        Energia += BananaComida.Energia;
        _bananas.RemoveAt(indiceBananaComida);
    }

    public void DarBanana( Macaco macacoDestinatario, int indexBananaDoada)
    {
        ArgumentNullException.ThrowIfNull(macacoDestinatario);

        Banana BananaDoada = _bananas[indexBananaDoada];

        macacoDestinatario._bananas.Add(BananaDoada);
        _bananas.RemoveAt(indexBananaDoada);
    }

    public override string ToString()
    {
        return $"Nome: {Nome} | Bananas: {_bananas.Count} | Energia: {Energia}";
    }
}