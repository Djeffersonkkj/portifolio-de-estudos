class MainController
{
    private readonly BananaServices _bananaServices;
    private readonly BolsaServices _bolsaServices;
    private readonly MacacoServices _macacoServices;

    public MainController(
        BananaServices bananaServices,
        BolsaServices bolsaServices,
        MacacoServices macacoServices)
    {
        _bananaServices = bananaServices;
        _bolsaServices = bolsaServices;
        _macacoServices = macacoServices;

    }

    public void ExibirMenu()
    {
        Console.WriteLine(
            @"
                                ------------- Macacos e Bananas -------------
                            
            1 | Cadastrar Macaco
            2 | Cadastrar Banana
            3 | Cadastrar Bolsa

            4 | Pegar Bolsa
            5 | Largar Bolsa
            6 | Pegar Banana
            7 | Comer Banana
            8 | Dar Bananaa

            0 | Fechar Sistema");
    }

    public void CadastrarMacaco()
    {
        try
        {
            string nomeMacaco;

            Console.Clear();
            Console.Write("Qual o nome do novo macaco? ");
            nomeMacaco = Console.ReadLine();
            _macacoServices.CriarMacaco(nomeMacaco);

            Console.Clear();
            Console.WriteLine($"O macaco {nomeMacaco} chegou à floresta!");     
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void CadastrarBanana()
    {
        try
        {
            string tipoBanana;
            int energiaBanana;

            Console.Clear();
            Console.Write("Qual o tipo da nova banana? ");
            tipoBanana = Console.ReadLine();
            Console.Write("Quanta energia a banana dá? ");
            energiaBanana = int.Parse(Console.ReadLine());

            _bananaServices.CriarBanana(tipoBanana, energiaBanana);

            Console.Clear();
            Console.WriteLine($"Uma banana {tipoBanana} brotou na floresta!");
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void CadastrarBolsa()
    {
            string material;
            int armazenamentoLimite;

            Console.Clear();
            Console.Write("Qual o material da bolsa? ");
            material = Console.ReadLine();
            Console.Write("Qual o limite da nova bolsa? ");
            armazenamentoLimite = int.Parse(Console.ReadLine());

            _bolsaServices.CriarBolsa(material, armazenamentoLimite);

            Console.Clear();
            Console.WriteLine($"Uma bolsa de {material} brotou na floresta!");
        try
        {
            
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void PegarBolsa()
    {
        try
        {
            
            int indexMacacoPegador;
            int indexBolsaVestida;
            Macaco macacoPegador;
            Bolsa bolsaVestida;


            Console.Clear();
            ListarMacacos();
            Console.Write("Qual o macaco que vai pegar a bolsa? ");
            indexMacacoPegador = int.Parse(Console.ReadLine());
            macacoPegador = _macacoServices.SelecionarMacacoPorIndex(indexMacacoPegador);

            Console.Clear();
            ListarBolsas();
            Console.Write($"Qual bolsa o {macacoPegador.Nome} vai pegar? ");
            indexBolsaVestida = int.Parse(Console.ReadLine());
            bolsaVestida = _bolsaServices.SelecionarBolsaPorIndex(indexBolsaVestida);

            Console.Clear();
            macacoPegador.VestirBolsa(bolsaVestida);
            Console.WriteLine($"O macaco {macacoPegador.Nome} pegou uma bolsa de {bolsaVestida.Material}");
            _bolsaServices.RemoverBolsaPorIndex(indexBolsaVestida);
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void SoltarBolsa()
    {
        try
        {
            int indexMacaco;
            Macaco macaco;
            Bolsa bolsaLargada;

            Console.Clear();
            ListarMacacos();
            Console.Write("Digite o index do macaco que vai soltar a bolsa: ");
            indexMacaco = int.Parse(Console.ReadLine());
            macaco = _macacoServices.SelecionarMacacoPorIndex(indexMacaco);

            Console.Clear();
            bolsaLargada = macaco.SoltarBolsa();
            _bolsaServices.DevolverBolsaParaFloresta(bolsaLargada);
            Console.WriteLine($"O macaco {macaco.Nome} largou sua bolsa na floresta");
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void PegarBanana()
    {
        try
        {
            int indexMacacoPegador;
            int IndiceBananaPega;
            Macaco MacacoPegador;
            Banana BananaPega;

            Console.Clear();
            ListarMacacos();
            Console.Write("Qual o macaco que vai pegar a banana? ");
            indexMacacoPegador = int.Parse(Console.ReadLine());
            MacacoPegador = _macacoServices.SelecionarMacacoPorIndex(indexMacacoPegador);

            Console.Clear();
            ListarBananas();
            Console.Write($"Qual banana o {MacacoPegador.Nome} vai pegar? ");
            IndiceBananaPega = int.Parse(Console.ReadLine());
            BananaPega = _bananaServices.SelecionarBananaPorIndex(IndiceBananaPega);

            Console.Clear();
            MacacoPegador.PegarBanana(BananaPega);
            Console.WriteLine($"O macaco {MacacoPegador.Nome} pegou uma banana {BananaPega.Tipo}");
            _bananaServices.RemoverBananaDaFloresta(IndiceBananaPega);
            
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void ComerBanana()
    {
        try
        {
            int indexBananaComida;
            int indexMacaco;
            Macaco macacoComedor;
            Bolsa bolsaDeBananas;
            Banana bananaComida;

            Console.Clear();
            ListarMacacos();
            Console.WriteLine("Digite o index do macaco: ");
            indexMacaco = int.Parse(Console.ReadLine());
            macacoComedor = _macacoServices.SelecionarMacacoPorIndex(indexMacaco);
            bolsaDeBananas = macacoComedor.BolsaVestida;

            Console.Clear();
            ListarBananasDoMacaco(macacoComedor);
            Console.WriteLine("digite o index da banana que será comida: ");
            indexBananaComida = int.Parse(Console.ReadLine());
            bananaComida = bolsaDeBananas.Bananas[indexBananaComida];

            Console.Clear();
            Console.WriteLine($"O macaco {macacoComedor.Nome} Comeu uma banana {bananaComida.Tipo} e recuperou {bananaComida.Energia} em energia.");
            macacoComedor.ComerBanana(indexBananaComida);
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void DarBanana()
    {
        try
        {
            
            int indiceBananaDoada;
            int indexRemetente;
            int indexDestinatario;
            Macaco macacoRemetente;
            Macaco macacoDestinatario;
            IReadOnlyList<Banana> bolsaDeBananas;

            Console.Clear();
            ListarMacacos();
            Console.Write("Digite o index do macaco que vai dar a banana: ");
            indexRemetente = int.Parse(Console.ReadLine());
            macacoRemetente = _macacoServices.SelecionarMacacoPorIndex(indexRemetente);
            bolsaDeBananas = macacoRemetente.BolsaVestida.Bananas;

            Console.Clear();
            ListarMacacos();
            Console.Write("Digite o index do macaco que vai receber a banana: ");
            indexDestinatario = int.Parse(Console.ReadLine());
            macacoDestinatario = _macacoServices.SelecionarMacacoPorIndex(indexDestinatario);

            Console.Clear();
            ListarBananasDoMacaco(macacoRemetente);
            Console.Write($"Qual banana o {macacoRemetente.Nome} vai dar? ");
            indiceBananaDoada = int.Parse(Console.ReadLine());
            Banana BananaDoada = bolsaDeBananas[indiceBananaDoada];

            Console.Clear();
            macacoRemetente.DarBanana(macacoDestinatario, indiceBananaDoada);
            Console.WriteLine($"O macaco {macacoRemetente.Nome} deu uma banana {BananaDoada.Tipo} para {macacoDestinatario}");
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    private void ListarMacacos()
    {
        IReadOnlyList<Macaco> macacos = _macacoServices.ObterTodosMacacos();
        
        Console.WriteLine("Macacos na floresta:\n");
        for (int i = 0; i < macacos.Count; i++)
        {
            string MacacoDescricao = macacos[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
    }

    private void ListarBolsas()
    {
        IReadOnlyList<Bolsa> bolsas = _bolsaServices.ObterTodasBolsas();

        Console.WriteLine("Bolsas no chão:\n");
        for (int i = 0; i < bolsas.Count; i++)
        {
            string DescricaoBolsa = bolsas[i].ToString();
            Console.WriteLine($"[{i}] {DescricaoBolsa}");
        }
    }

    private void ListarBananas()
    {
        IReadOnlyList<Banana> bananas = _bananaServices.ObterTodasBananas();

        Console.WriteLine("Bananas nas bananeiras:\n");
        for (int banana = 0; banana < bananas.Count; banana++)
        {
            string DescricaoBanana = bananas[banana].ToString();
            Console.WriteLine($"[{banana}] {DescricaoBanana}");
        }
    }

    private void ListarBananasDoMacaco(Macaco macaco)
    {
        IReadOnlyList<Banana> bananasNaBolsa = _macacoServices.ObterBananas(macaco);

        Console.WriteLine($"Bananas do {macaco.Nome}:\n");
        for (int i = 0; i < bananasNaBolsa.Count; i++)
        {
            String bananaDescricao = bananasNaBolsa[i].ToString();
            Console.WriteLine($"[{i}]  {bananaDescricao}");
        };
    }

}