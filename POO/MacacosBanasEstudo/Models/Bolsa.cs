class Bolsa
{  
    private static int _proximoId = 1;
    private readonly List<Banana> _bananas = [];
    public int Id { get; private set; }
    public string Material { get; private set; }
    public int LimiteArmazenamento { get; private set; }
    public IReadOnlyList<Banana> Bananas => _bananas;

    public Bolsa(string material, int limiteArmazenamento)
    {
        Id = _proximoId++;
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
        return $"Id: {Id} | Material: {Material} | Armazenamento: {LimiteArmazenamento}";
    }

}