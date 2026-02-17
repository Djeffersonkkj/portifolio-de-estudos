static class Floresta
{
    private static readonly List<Macaco> _macacos = [];
    private static readonly List<Banana> _bananas = [];
    private static readonly List<Bolsa> _bolsas = [];

    public static IReadOnlyList<Macaco> Macacos => _macacos;
    public static IReadOnlyList<Banana> Bananas => _bananas;
    public static IReadOnlyList<Bolsa> Bolsas => _bolsas;
    

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

    public static void AdicionarBolsa(string material, int limiteArmazenamento)
    {
        Bolsa NovaBolsa = new(material, limiteArmazenamento);
        _bolsas.Add(NovaBolsa);
    }

    public static void ReceberBolsa(Bolsa bolsa)
    {
        _bolsas.Add(bolsa);
    }

    public static void RemoverBolsa(int IndiceBolsa)
    {
        _bolsas.RemoveAt(IndiceBolsa);
    }


}