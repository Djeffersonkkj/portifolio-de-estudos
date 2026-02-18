class BananaView
{
    private readonly MainController _mainController;

    public BananaView(MainController mainController)
    {
        _mainController = mainController;
    }

    public void CadastrarBanana()
    {
        try
        {
            string tipoBanana;
            decimal energiaBanana;

            Console.Clear();
            Console.Write("Qual o tipo da nova banana? ");
            tipoBanana = Console.ReadLine();
            Console.Write("Quanta energia a banana dá? ");
            energiaBanana = decimal.Parse(Console.ReadLine());

            _mainController.BananaServices.CriarBanana(tipoBanana, energiaBanana);

            Console.Clear();
            Console.WriteLine($"Uma banana {tipoBanana} brotou na floresta!");
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void ListarBananas()
    {
        Console.Clear();
        IReadOnlyList<Banana> bananas = _mainController.BananaServices.ObterTodasBananas();

        Console.WriteLine("Bananas nas bananeiras:\n");
        for (int banana = 0; banana < bananas.Count; banana++)
        {
            string DescricaoBanana = bananas[banana].ToString();
            Console.WriteLine($"[{banana}] {DescricaoBanana}");
        }
    }

    public Banana SelecionarBananaFloresta(string acao)
    {
        int indexBanana;
        Banana bananaPega;

        Console.Write(acao);
        indexBanana = int.Parse(Console.ReadLine());
        bananaPega = _mainController.BananaServices.SelecionarBananaPorIndex(indexBanana);

        return bananaPega;
    }
}