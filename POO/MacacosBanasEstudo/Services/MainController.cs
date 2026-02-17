class MainController
{
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
        MacacoServices.CadastrarMacaco();
    }

    public void CadastrarBanana()
    {
        BananaServices.CadastrarBanana();
    }

    public void CadastrarBolsa()
    {
        BolsaServices.CadastrarBolsa();
    }

    public void PegarBolsa()
    {
        int IndiceMacacoPegador;
        int IndiceBolsaVestida;
        Macaco MacacoPegador;
        Bolsa BolsaVestida;


        Console.Clear();
        FlorestaServices.ExibirMacacos();
        Console.Write("Qual o macaco que vai pegar a bolsa? ");
        IndiceMacacoPegador = int.Parse(Console.ReadLine());
        MacacoPegador = Floresta.Macacos[IndiceMacacoPegador];

        Console.Clear();
        FlorestaServices.ExibirBolsas();
        Console.Write($"Qual bolsa o {MacacoPegador.Nome} vai pegar? ");
        IndiceBolsaVestida = int.Parse(Console.ReadLine());
        BolsaVestida = Floresta.Bolsas[IndiceBolsaVestida];

        Console.Clear();
        MacacoPegador.VestirBolsa(BolsaVestida);
        Console.WriteLine($"O macaco {MacacoPegador.Nome} pegou uma bolsa de {BolsaVestida.Material}");
        Floresta.RemoverBolsa(IndiceBolsaVestida);
    }

    public void SoltarBolsa()
    {
        Macaco macaco;

        Console.Clear();
        FlorestaServices.ExibirMacacos();
        Console.Write("Digite o index do macaco que vai soltar a bolsa: ");
        macaco = FlorestaServices.SeletorMacaco();

        Console.Clear();
        macaco.SoltarBolsa();
        Console.WriteLine($"O macaco {macaco.Nome} largou suma bolsa na floresta");
    }

    public void PegarBanana()
    {
        int IndiceMacacoPegador;
        int IndiceBananaPega;
        Macaco MacacoPegador;
        Banana BananaPega;

        Console.Clear();
        FlorestaServices.ExibirMacacos();
        Console.Write("Qual o macaco que vai pegar a banana? ");
        IndiceMacacoPegador = int.Parse(Console.ReadLine());
        MacacoPegador = Floresta.Macacos[IndiceMacacoPegador];

        Console.Clear();
        FlorestaServices.ExibirBananas();
        Console.Write($"Qual banana o {MacacoPegador.Nome} vai pegar? ");
        IndiceBananaPega = int.Parse(Console.ReadLine());
        BananaPega = Floresta.Bananas[IndiceBananaPega];

        Console.Clear();
        MacacoPegador.PegarBanana(BananaPega);
        Console.WriteLine($"O macaco {MacacoPegador.Nome} pegou uma banana {BananaPega.Tipo}");
        Floresta.RemoverBanana(IndiceBananaPega);
    }

    public void ComerBanana()
    {
        int indexBananaComida;
        Macaco macacoComedor;
        Bolsa bolsaDeBananas;
        Banana bananaComida;

        Console.Clear();
        FlorestaServices.ExibirMacacos();
        Console.WriteLine("Digite o index do macaco: ");
        macacoComedor = FlorestaServices.SeletorMacaco();
        bolsaDeBananas = macacoComedor.BolsaVestida;

        Console.Clear();
        MacacoServices.ExibirBananas(macacoComedor);
        Console.WriteLine("digite o index da banana que será comida: ");
        indexBananaComida = MacacoServices.SeletorBananaIndex(macacoComedor);
        bananaComida = bolsaDeBananas.Bananas[indexBananaComida];

        Console.Clear();
        Console.WriteLine($"O macaco {macacoComedor.Nome} Comeu uma banana {bananaComida.Tipo} e recuperou {bananaComida.Energia} em energia.");
        macacoComedor.ComerBanana(indexBananaComida);
    }

    public void DarBanana()
    {
        int indiceBananaDoada;
        Macaco macacoRemetente;
        Macaco macacoDestinatario;
        IReadOnlyList<Banana> bolsaDeBananas;

        Console.Clear();
        FlorestaServices.ExibirMacacos();
        Console.Write("Digite o index do macaco que vai dar a banana: ");
        macacoRemetente = FlorestaServices.SeletorMacaco();
        bolsaDeBananas = macacoRemetente.BolsaVestida.Bananas;

        Console.Clear();
        FlorestaServices.ExibirMacacos();
        Console.Write("Digite o index do macaco que vai receber a banana: ");
        macacoDestinatario = FlorestaServices.SeletorMacaco();

        Console.Clear();
        MacacoServices.ExibirBananas(macacoRemetente);
        Console.Write($"Qual banana o {macacoRemetente.Nome} vai dar? ");
        indiceBananaDoada = MacacoServices.SeletorBananaIndex(macacoRemetente);
        Banana BananaDoada = bolsaDeBananas[indiceBananaDoada];

        Console.Clear();
        macacoRemetente.DarBanana(macacoDestinatario, indiceBananaDoada);
        Console.WriteLine($"O macaco {macacoRemetente.Nome} deu uma banana {BananaDoada.Tipo} para {macacoDestinatario}");
    }

}