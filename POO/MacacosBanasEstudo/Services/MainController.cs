class MainController
{
    public void ExibirMenu()
    {
        Console.WriteLine(
            @"
                                ------------- Macacos e Bananas -------------
                            
            1 | Cadastrar Macaco
            2 | Cadastrar Banana

            3 | Pegar Banana
            4 | Comer Banana
            5 | Dar Bananaa

            0 | Fechar Sistema");
    }

    public void CadastrarMacaco()
    {
        string NomeMacaco;
        Console.Clear();
        Console.Write("Qual o nome do novo macaco? ");
        NomeMacaco = Console.ReadLine();

        FlorestaService.AdicionarMacaco(NomeMacaco);

        Console.Clear();
        Console.WriteLine($"O macaco {NomeMacaco} chegou à floresta!");
    }

    public void CadastrarBanana()
        {
            string TipoBanana;
            int EnergiaBanana;

            Console.Clear();
            Console.Write("Qual o tipo da nova banana? ");
            TipoBanana = Console.ReadLine();
            Console.Write("Quanta energia a banana dá? ");
            EnergiaBanana = int.Parse(Console.ReadLine());
            FlorestaService.AdicionarBanana(TipoBanana, EnergiaBanana);


            Console.Clear();
            Console.WriteLine($"Uma banana {TipoBanana} brotou na floresta!");
        }

    public void PegarBanana()
    {
        int IndiceMacacoPegador;
        int IndiceBananaPega;
        Macaco MacacoPegador;
        Banana BananaPega;

        Console.Clear();
        Console.WriteLine("Macacos na floresta:\n");
        for (int i = 0; i < FlorestaService.Macacos.Count; i++)
        {
            string MacacoDescricao = FlorestaService.Macacos[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
        Console.Write("Qual o macaco que vai pegar a banana? ");
        IndiceMacacoPegador = int.Parse(Console.ReadLine());
        MacacoPegador = FlorestaService.Macacos[IndiceMacacoPegador];

        Console.Clear();
        Console.WriteLine("Bananas nas bananeiras:\n");
        for (int i = 0; i < FlorestaService.Bananas.Count; i++)
        {
            string DescricaoBanana = FlorestaService.Bananas[i].ToString();
            Console.WriteLine($"[{i}] {DescricaoBanana}");
        }
        Console.Write($"Qual banana o {MacacoPegador.Nome} vai pegar? ");
        IndiceBananaPega = int.Parse(Console.ReadLine());
        BananaPega = FlorestaService.Bananas[IndiceBananaPega];

        Console.Clear();
        MacacoPegador.PegarBanana(BananaPega);
        Console.WriteLine($"O macaco {MacacoPegador.Nome} pegou uma banana {BananaPega.Tipo}");
        FlorestaService.RemoverBanana(IndiceBananaPega);
    }

    public void ComerBanana()
    {
        int IndiceMacacoComedor;
        int IndiceBananaComida;
        Macaco MacacoComedor;
        Banana BananaComida;

        Console.Clear();
        Console.WriteLine("Macacos na floresta:\n");
        for (int i = 0; i < FlorestaService.Macacos.Count; i++)
        {
            string MacacoDescricao = FlorestaService.Macacos[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
        Console.Write("Qual macaco vai comer a banana? ");
        IndiceMacacoComedor = int.Parse(Console.ReadLine());
        MacacoComedor = FlorestaService.Macacos[IndiceMacacoComedor];

        Console.Clear();
        Console.WriteLine($"Bananas do {MacacoComedor.Nome}:\n");
        for (int i = 0; i < MacacoComedor.Bananas.Count; i++)
        {
            String BananaDescricao = MacacoComedor.Bananas[i].ToString();
            Console.WriteLine($"[{i}]  {BananaDescricao}");
        };
        Console.Write("Qual banana será comida? ");
        IndiceBananaComida = int.Parse(Console.ReadLine());
        BananaComida = MacacoComedor.Bananas[IndiceBananaComida];

        Console.Clear();
        Console.WriteLine($"O macaco {MacacoComedor.Nome} Comeu uma banana {BananaComida.Tipo} e recuperou {BananaComida.Energia} em energia.");
        MacacoComedor.ComerBanana(IndiceBananaComida);
    }

    public void DarBanana()
    {
        int IndiceMacacoRemetente;
        int IndiceMacacoDestinatario;
        int IndiceBananaDoada;
        Macaco MacacoRemetente;
        Macaco MacacoDestinatario;

        Console.Clear();
        Console.WriteLine("Macacos na floresta:\n");
        for (int i = 0; i < FlorestaService.Macacos.Count; i++)
        {
            string MacacoDescricao = FlorestaService.Macacos[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
        Console.Write("Qual macaco vai dar a banana? ");
        IndiceMacacoRemetente = int.Parse(Console.ReadLine());
        MacacoRemetente = FlorestaService.Macacos[IndiceMacacoRemetente];

        Console.Clear();
        Console.WriteLine("Macacos na floresta:\n");
        for (int i = 0; i < FlorestaService.Macacos.Count; i++)
        {
            string MacacoDescricao = FlorestaService.Macacos[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
        Console.Write("Qual macaco vai receber a banana? ");
        IndiceMacacoDestinatario = int.Parse(Console.ReadLine());
        MacacoDestinatario = FlorestaService.Macacos[IndiceMacacoDestinatario];

        Console.Clear();
        Console.WriteLine($"Bananas do {MacacoRemetente.Nome}:\n");
        for (int i = 0; i < MacacoRemetente.Bananas.Count; i++)
        {
            String BananaDescricao = MacacoRemetente.Bananas[i].ToString();
            Console.WriteLine($"[{i}]  {BananaDescricao}");
        };
        ;
        Console.Write($"Qual banana o {MacacoRemetente.Nome} vai dar? ");
        IndiceBananaDoada = int.Parse(Console.ReadLine());
        Banana BananaDoada = MacacoRemetente.Bananas[IndiceBananaDoada];

        Console.Clear();
        MacacoRemetente.DarBanana(MacacoDestinatario, IndiceBananaDoada);
        Console.WriteLine($"O macaco {MacacoRemetente.Nome} deu uma banana {BananaDoada.Tipo} para {MacacoDestinatario}");
    }

}