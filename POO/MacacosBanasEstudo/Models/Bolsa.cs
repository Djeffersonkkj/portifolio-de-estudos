class Bolsa
{  
    private readonly List<Banana> _bananas = [];
    public string Material { get; private set; }
    public int LimiteArmazenamento { get; private set; }
    public IReadOnlyList<Banana> Bananas => _bananas;

    public Bolsa(string material, int limiteArmazenamento)
    {
        Material = material;
        LimiteArmazenamento = limiteArmazenamento;
        _bananas = [];
    }

    public void ArmazenarBanana(Banana banana)
    {
        if (_bananas.Count == LimiteArmazenamento)
        {
            throw new InvalidOperationException("Limite de armazenamento atingido.");
        }
        _bananas.Add(banana);
    }

    public void RemoverBanana(int IndexBanana)
    {
        _bananas.RemoveAt(IndexBanana);
    }

    public override string ToString()
    {
        return $"Material: {Material} | Armazenamento: {Bananas.Count}/{LimiteArmazenamento}";
    }

}