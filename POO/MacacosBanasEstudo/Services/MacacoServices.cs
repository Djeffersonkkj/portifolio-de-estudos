class MacacoServices
{
    private readonly Floresta _floresta;

    public MacacoServices(Floresta floresta)
    {
        _floresta = floresta;
    }
    public void CriarChimpanze(string nome)
    {
        Chimpanze novoChimpanze = new Chimpanze(nome);
        _floresta.AdicionarMacaco(novoChimpanze);
    }

    public void CriarSagui(string nome)
    {
        Sagui novoSagui = new Sagui(nome);
        _floresta.AdicionarMacaco(novoSagui);
    }

    public void CriarGorila(string nome)
    {
        Gorila novoGorila = new Gorila(nome);
        _floresta.AdicionarMacaco(novoGorila);
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

    public IReadOnlyList<Sagui> ObterTodosSaguis()
    {
        IReadOnlyList<Macaco> macacos = _floresta.Macacos;
        IReadOnlyList<Sagui> saguis = [.. macacos.OfType<Sagui>()];
        return saguis;
    }

    public IReadOnlyList<Chimpanze> ObterTodosChimpanzes()
    {
        IReadOnlyList<Macaco> macacos = _floresta.Macacos;
        IReadOnlyList<Chimpanze> chimpanzes = [.. macacos.OfType<Chimpanze>()];
        return chimpanzes;
    }

    public IReadOnlyList<Gorila> ObterTodosGorilas()
    {
        IReadOnlyList<Macaco> macacos = _floresta.Macacos;
        IReadOnlyList<Gorila> gorilas = [.. macacos.OfType<Gorila>()];
        return gorilas;
    }

    public Macaco SelecionarMacacoPorIndex(int index)
    {
        Macaco macaco = _floresta.Macacos[index];
        return macaco;
    }

    public Sagui SelecionarSaguiPorIndex(int index)
    {
        IReadOnlyList<Sagui> saguis = ObterTodosSaguis();

        Sagui sagui = saguis[index];

        return sagui;
    }

    public Chimpanze SelecionarChimpanzePorIndex(int index)
    {
        IReadOnlyList<Chimpanze> chimpanzes = ObterTodosChimpanzes();

        Chimpanze chimpanze = chimpanzes[index];

        return chimpanze;
    }

    public Gorila SelecionarGorilaPorIndex(int index)
    {
        IReadOnlyList<Gorila> gorilas = ObterTodosGorilas();

        Gorila gorila = gorilas[index];

        return gorila;
    }
}