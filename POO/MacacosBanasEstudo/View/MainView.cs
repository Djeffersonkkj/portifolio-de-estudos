using System.Security.AccessControl;

class MainView
{
    private readonly MainController _mainController;
    public MacacoView MacacoView { get; private set; }
    public BolsaView BolsaView { get; private set; }
    public BananaView BananaView { get; private set; }

    public MainView(
        MainController mainController,
        MacacoView macacoView,
        BolsaView bolsaView,
        BananaView bananaView)
    {
        _mainController = mainController;
        MacacoView = macacoView;
        BolsaView = bolsaView;
        BananaView = bananaView;
    }

    public void ExibirMenu()
    {
        Console.WriteLine(
            @"
                                ------------- Macacos e Bananas -------------
                            
            1 | Macaco
            2 | Cadastrar Banana
            3 | Cadastrar Bolsa

            0 | Fechar Sistema");
    }
    public void ExibirMacacos()
    {
        Console.Clear();
        IReadOnlyList<Macaco> macacos = _mainController.MacacoServices.ObterTodosMacacos();
        
        Console.WriteLine("Macacos na floresta:\n");
        for (int i = 0; i < macacos.Count; i++)
        {
            string MacacoDescricao = macacos[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
        Console.WriteLine();
        Console.Write("Enter para voltar...");
        Console.ReadKey();
        Console.Clear();
    }

    public void PegarBolsa()
    {
        try
        {
            Macaco macacoPegador;
            Bolsa bolsaVestida;


            MacacoView.ListarMacacos();
            macacoPegador = MacacoView.SelecionarMacaco("Qual macaco vai pegar a bolsa? ");

            BolsaView.ListarBolsas();
            bolsaVestida = BolsaView.SelecionarBolsa($"Qual bolsa o {macacoPegador.Nome} vai pegar? ");
            
            Console.Clear();
            macacoPegador.VestirBolsa(bolsaVestida);
            Console.WriteLine($"O macaco {macacoPegador.Nome} pegou uma bolsa de {bolsaVestida.Material}");
            _mainController.BolsaServices.RemoverBolsaFloresta(bolsaVestida);
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
            Macaco macacoPegador;
            Banana bananaPega;

            MacacoView.ListarMacacos();
            macacoPegador = MacacoView.SelecionarMacaco("Qual o macaco que vai pegar a banana? ");

            BananaView.ListarBananas();
            bananaPega = BananaView.SelecionarBananaFloresta($"Qual banana o {macacoPegador.Nome} vai pegar? ");

            Console.Clear();
            macacoPegador.PegarBanana(bananaPega);
            Console.WriteLine($"O macaco {macacoPegador.Nome} pegou uma banana {bananaPega.Tipo}");
            _mainController.BananaServices.RemoverBananaDaFloresta(bananaPega);
            
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
            
            Macaco macacoComedor;
            Banana bananaComida;

            MacacoView.ListarMacacos();
            macacoComedor = MacacoView.SelecionarMacaco("Qual macaco vai comer banana? ");
            
            MacacoView.ListarBananas(macacoComedor);
            bananaComida = MacacoView.SelecionarBanana(macacoComedor, "Qual banana será comida? ");

            Console.Clear();
            Console.WriteLine($"O macaco {macacoComedor.Nome} Comeu uma banana {bananaComida.Tipo} e recebeu {bananaComida.Energia} em energia.");
            macacoComedor.ComerBanana(bananaComida);
            if (macacoComedor.Energia <= 0)
            {
                Console.WriteLine($"O macaco {macacoComedor.Nome} comeu uma banana ruim e morreu.");
                _mainController.MacacoServices.MatarMacaco(macacoComedor);
            }
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
            Macaco macacoRemetente;
            Banana bananaDoada;
            Macaco macacoDestinatario;
            Bolsa bolsaDeBananas;

            MacacoView.ListarMacacos();
            macacoRemetente = MacacoView.SelecionarMacaco("Qual macaco vai dar a banana? ");
            bolsaDeBananas = macacoRemetente.BolsaVestida;

            MacacoView.ListarBananas(macacoRemetente);
            bananaDoada = MacacoView.SelecionarBanana(macacoRemetente, $"Qual banana o {macacoRemetente.Nome} vai dar? ");

            MacacoView.ListarMacacos();
            macacoDestinatario = MacacoView.SelecionarMacaco("Qual macaco vai receber a banana? ");

            Console.Clear();
            macacoRemetente.DarBanana(macacoDestinatario, bananaDoada);
            Console.WriteLine($"O macaco {macacoRemetente.Nome} deu uma banana {bananaDoada.Tipo} para {macacoDestinatario}");
        }
        catch (System.Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
        }
    }

    
}