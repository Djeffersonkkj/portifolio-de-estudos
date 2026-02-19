class Floresta
{
    private readonly List<Macaco> _macacos = [];
    private readonly List<Banana> _bananas = [];
    private readonly List<Bolsa> _bolsas = [];

    public IReadOnlyList<Macaco> Macacos => _macacos;
    public IReadOnlyList<Banana> Bananas => _bananas;
    public IReadOnlyList<Bolsa> Bolsas => _bolsas;
    

    public void AdicionarMacaco(Macaco macaco)
    {
        _macacos.Add(macaco);
    }

    public void RemoverMacaco(Macaco macaco)
    {
        _macacos.Remove(macaco);
    }

    public void AdicionarBanana(Banana banana)
    {
        _bananas.Add(banana);
    }

    public void RemoverBanana(Banana banana)
    {
        _bananas.Remove(banana);
    }

    public void AdicionarBolsa(Bolsa Bolsa)
    {
        _bolsas.Add(Bolsa);
    }

    public void ReceberBolsa(Bolsa bolsa)
    {
        _bolsas.Add(bolsa);
    }

    public void RemoverBolsa(Bolsa bolsa)
    {
        _bolsas.Remove(bolsa);
    }


}