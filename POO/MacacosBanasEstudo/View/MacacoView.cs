class MacacoView
{
    private readonly MainController _mainController;

    public MacacoView(MainController mainController)
    {
        _mainController = mainController;
    }

    public void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine(
            @"
                                -------------      Macacos      -------------
                            
            1  | Cadastrar Macaco
            2  | Ver Macacos

            3  | Pegar Bolsa
            4  | Largar Bolsa
            5  | Pegar Banana
            6  | Comer Banana
            7  | Dar Banana

            8  | Roubar Bolsa
            9  | Envenenar Banana
            10 | Bater em um macaco

            0  | voltar");
    }

    public void Cadastrar()
    {
        try
        {
            string nomeMacaco;

            Console.Clear();
            Console.Write("Qual o nome do novo macaco? ");
            nomeMacaco = Console.ReadLine();

            Console.Clear();
            Console.Write(
                @"
                        
                1 | Chimpanzé
                2 | Gorila
                3 | Sagui

                Selecione a ESPECIE do macaco: ");

            string opcaoEspecie = Console.ReadLine();

            switch (opcaoEspecie)
            {
                case "1":
                    Console.Clear();
                    _mainController.MacacoServices.CriarChimpanze(nomeMacaco);
                    Console.WriteLine($"O macaco {nomeMacaco} chegou à floresta!");
                    break;

                case "2":
                    Console.Clear();
                    _mainController.MacacoServices.CriarGorila(nomeMacaco);
                    Console.WriteLine($"O macaco {nomeMacaco} chegou à floresta!");
                    break;

                case "3":
                    Console.Clear();
                    _mainController.MacacoServices.CriarSagui(nomeMacaco);
                    Console.WriteLine($"O macaco {nomeMacaco} chegou à floresta!");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void ListarMacacos()
    {
        Console.Clear();
        IReadOnlyList<Macaco> macacos = _mainController.MacacoServices.ObterTodosMacacos();
        
        Console.WriteLine("Macacos na floresta:\n");
        for (int i = 0; i < macacos.Count; i++)
        {
            string MacacoDescricao = macacos[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
    }

    public void ListarSaguis()
    {
        Console.Clear();
        IReadOnlyList<Sagui> saguis = _mainController.MacacoServices.ObterTodosSaguis();
        
        Console.WriteLine("Saguis na floresta:\n");
        for (int i = 0; i < saguis.Count; i++)
        {
            string MacacoDescricao = saguis[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
    }

    public void ListarChimpanze()
    {
        Console.Clear();
        IReadOnlyList<Chimpanze> chimpanzes = _mainController.MacacoServices.ObterTodosChimpanzes();
        
        Console.WriteLine("Chimpanzes na floresta:\n");
        for (int i = 0; i < chimpanzes.Count; i++)
        {
            string MacacoDescricao = chimpanzes[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
    }

    public void ListarGorila()
    {
        Console.Clear();
        IReadOnlyList<Gorila> gorilas = _mainController.MacacoServices.ObterTodosGorilas();
        
        Console.WriteLine("Gorilas na floresta:\n");
        for (int i = 0; i < gorilas.Count; i++)
        {
            string MacacoDescricao = gorilas[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
    }

    public Macaco SelecionarMacaco(string acao)
    {
        int indexMacaco;
        Macaco macaco;

        Console.Write(acao);
        indexMacaco = int.Parse(Console.ReadLine());
        macaco = _mainController.MacacoServices.SelecionarMacacoPorIndex(indexMacaco);

        return macaco;
    }

    public Sagui SelecionarSagui(string acao)
    {
        int indexSagui;
        Sagui sagui;

        Console.Write(acao);
        indexSagui = int.Parse(Console.ReadLine());
        sagui = _mainController.MacacoServices.SelecionarSaguiPorIndex(indexSagui);

        return sagui;
    }

    public Chimpanze SelecionarChimpanze(string acao)
    {
        int indexChimpanze;
        Chimpanze Chimpanze;

        Console.Write(acao);
        indexChimpanze = int.Parse(Console.ReadLine());
        Chimpanze = _mainController.MacacoServices.SelecionarChimpanzePorIndex(indexChimpanze);

        return Chimpanze;
    }

    public Gorila SelecionarGorila(string acao)
    {
        int indexGorila;
        Gorila gorila;

        Console.Write(acao);
        indexGorila = int.Parse(Console.ReadLine());
        gorila = _mainController.MacacoServices.SelecionarGorilaPorIndex(indexGorila);

        return gorila;
    }

    public void SoltarBolsa()
    {
        try
        {
            Macaco macaco;
            Bolsa bolsaLargada;

            ListarMacacos();
            macaco = SelecionarMacaco("Qual macaco vai largar a bolsa? ");

            Console.Clear();
            bolsaLargada = macaco.SoltarBolsa();
            _mainController.BolsaServices.DevolverBolsaParaFloresta(bolsaLargada);
            Console.WriteLine($"O macaco {macaco.Nome} largou sua bolsa na floresta");
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public Banana SelecionarBanana(Macaco macaco, string acao)
    {
        int indexBanana;
        Bolsa bolsaDeBananas;
        Banana banana;

        bolsaDeBananas = macaco.BolsaVestida;

        ListarBananas(macaco);
        Console.WriteLine(acao);
        indexBanana = int.Parse(Console.ReadLine());
        banana = bolsaDeBananas.Bananas[indexBanana];

        return banana;
    }

    public void ListarBananas(Macaco macaco)
    {
        Console.Clear();

        IReadOnlyList<Banana> bananasNaBolsa = _mainController.MacacoServices.ObterBananas(macaco);

        Console.WriteLine($"Bananas do {macaco.Nome}:\n");
        for (int i = 0; i < bananasNaBolsa.Count; i++)
        {
            String bananaDescricao = bananasNaBolsa[i].ToString();
            Console.WriteLine($"[{i}]  {bananaDescricao}");
        };
    }

    public void RoubarBolsa()
    {
        try
        {

            Sagui ladrao;
            Macaco vitima;

            ListarSaguis();
            ladrao = SelecionarSagui("Qual sagui vai roubar um macaco? ");

            ListarMacacos();
            vitima = SelecionarMacaco($"Qual será a vítima de {ladrao.Nome}? ");

            Console.Clear();
            ladrao.RoubarBolsa(vitima);
            Console.WriteLine($"O macaco {ladrao.Nome} roubou {vitima.Nome}");

        }
        catch (System.Exception ex)
        {
            
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void EnvenenarBanana()
    {
        try
        {
            Chimpanze chimpanze;
            Banana banana;

            ListarChimpanze();
            chimpanze = SelecionarChimpanze("Qual chimpanze vai envenenar uma banana? ");

            ListarBananas(chimpanze);
            banana = SelecionarBanana(chimpanze, "Qual banana será envenenada?");

            Console.Clear();
            chimpanze.EnvenenarBanana(banana);
            Console.WriteLine($"O macaco {chimpanze.Nome} envenenou uma banana");
        }
        catch (System.Exception ex)
        {
            
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    public void Bater()
    {
        try
        {
            Gorila gorila;
            Macaco vitima;
            decimal energiaInicialVitima;

            ListarGorila();
            gorila = SelecionarGorila("Qual gorila vai bater? ");

            ListarMacacos();
            vitima = SelecionarMacaco("Qual macaco vai apanhar? ");
            energiaInicialVitima = vitima.Energia;

            Console.Clear();
            gorila.Bater(vitima);
            if (energiaInicialVitima == vitima.Energia)
            {
                Console.WriteLine($"O macaco {gorila.Nome} tentou bater em {vitima.Nome} e falhou.");
            }
            else if (energiaInicialVitima != vitima.Energia)
            {
                 Console.WriteLine($"O macaco {gorila.Nome} conseguiu bater em {vitima.Nome}.");
            }
            if (vitima.Energia <= 0)
            {
                Console.WriteLine($"O macaco {vitima.Nome} foi Morto");
                _mainController.MacacoServices.MatarMacaco(vitima);
            }
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

}