class BananaServices
{
    private readonly Floresta _floresta;

    public BananaServices(Floresta floresta)
    {
        _floresta = floresta;
    }
    public void CriarBanana(string tipoBanana, int energiaBanana)
    {

        Banana novaBanana;

        novaBanana = new Banana(tipoBanana, energiaBanana);
        _floresta.AdicionarBanana(novaBanana);
    }

    public IReadOnlyList<Banana> ObterTodasBananas()
    {
        return _floresta.Bananas;
    }

    public Banana SelecionarBananaPorIndex(int index)
    {
        Banana banana = _floresta.Bananas[index];
        return banana;
    }

    public void RemoverBananaDaFloresta(int banana)
    {
        _floresta.RemoverBanana(banana);
    }

}