static class FlorestaService
{
    private static readonly List<Macaco> _macacos = [];
    private static readonly List<Banana> _bananas = [];

    public static IReadOnlyList<Macaco> Macacos => _macacos;
    public static IReadOnlyList<Banana> Bananas => _bananas;
    

    public static void AdicionarMacaco(string nome)
    {
        Macaco NovoMacaco = new(nome);
        _macacos.Add(NovoMacaco);
    }

    public static void AdicionarBanana(string tipo, int energia)
    {
        Banana NovaBanana = new(tipo, energia);
        _bananas.Add(NovaBanana);
    }

    public static void RemoverBanana(int IndiceBanana)
    {
        _bananas.RemoveAt(IndiceBanana);
    }

}