class MacacoServices
{
    private readonly Floresta _floresta;

    public MacacoServices(Floresta floresta)
    {
        _floresta = floresta;
    }
    public void CriarMacaco(string nomeMacaco)
    {
        
        Macaco novoMacaco;
        
        novoMacaco = new Macaco(nomeMacaco);
        _floresta.AdicionarMacaco(novoMacaco);
    }

    public IReadOnlyList<Banana> ObterBananas(Macaco macaco)
    {
        Bolsa bolsa = macaco.BolsaVestida;
        return bolsa.Bananas;
    }

    public IReadOnlyList<Macaco> ObterTodosMacacos()
    {
        return _floresta.Macacos;
    }

    public Macaco SelecionarMacacoPorIndex(int index)
    {
        Macaco macaco = _floresta.Macacos[index];
        return macaco;
    }
}