bool loop = true;
List<Macaco> Macacos = new List<Macaco>();
List<Banana> Bananas = new List<Banana>();

while (loop)
{
    string Opcao;

    Console.WriteLine(
    @"
                           ------------- Macacos e Bananas -------------
                    
    1 | Cadastrar Macaco
    2 | Cadastrar Banana

    3 | Pegar Banana
    4 | Comer Banana

    0 | Fechar Sistema
    ");
    Opcao = Console.ReadLine();
    switch (Opcao)
    {
        case "0":
            Console.Clear();
            Console.WriteLine("Sistema Fechado!");
            loop = false;
        break;

        case "1":
            string NomeMacaco;

            Console.Clear();
            Console.Write("Qual o nome do novo macaco? ");
            NomeMacaco = Console.ReadLine();
            Macaco NovoMacaco = new Macaco(NomeMacaco);
            Macacos.Add(NovoMacaco);

            Console.Clear();
            Console.WriteLine($"O macaco {NomeMacaco} chegou à floresta!");
        break;

        case "2":
            string TipoBanana;
            int EnergiaBanana;

            Console.Clear();
            Console.Write("Qual o tipo da nova banana? ");
            TipoBanana = Console.ReadLine();
            Console.Write("Quanta energia a banana dá? ");
            EnergiaBanana = int.Parse(Console.ReadLine());
            Banana NovaBanana = new Banana(TipoBanana, EnergiaBanana);
            Bananas.Add(NovaBanana);

            Console.Clear();
            Console.WriteLine($"Uma banana {TipoBanana} brotou na floresta!");
        break;

        case "3":
            int IndiceMacaco;
            int IndiceBanana;

            Console.Clear();
            Console.WriteLine("Macacos na floresta:\n");
            for (int macaco = 0; macaco < Macacos.Count; macaco++)
            {
                Console.WriteLine($"{macaco} | {Macacos[macaco].Nome}");
            }
            Console.Write("Qual o macaco que vai pegar a banana? ");
            IndiceMacaco = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Bananas nas bananeiras:\n");
            for (int banana = 0; banana < Bananas.Count; banana++)
            {
                Console.WriteLine($"{banana} | Banana {Bananas[banana].Tipo}");
            }
            Console.Write($"Qual banana o {Macacos[IndiceMacaco].Nome} vai pegar? ");
            IndiceBanana = int.Parse(Console.ReadLine());
            Macacos[IndiceMacaco].PegarBanana(Bananas[IndiceBanana]);

            Console.Clear();
            Console.WriteLine($"O macaco {Macacos[IndiceMacaco].Nome} pegou uma banana {Bananas[IndiceBanana].Tipo}");
            Bananas.RemoveAt(IndiceBanana);
        break;

        case "4":
            int IndiceMacaco2;
            int IndiceBanana2;

            Console.Clear();
            Console.WriteLine("Macacos na floresta:\n");
            for (int i = 0; i < Macacos.Count; i++)
            {
                Console.WriteLine($"{i} | {Macacos[i].Nome}");
            }
            Console.Write("Qual macaco vai comer a banana? ");
            IndiceMacaco2 = int.Parse(Console.ReadLine());

            Console.Clear();
            Macacos[IndiceMacaco2].ExibirBananas();
            Console.Write("Qual banana será comida? ");
            IndiceBanana2 = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"O macaco {Macacos[IndiceMacaco2].Nome} Comeu uma banana {Macacos[IndiceMacaco2].Bananas[IndiceBanana2].Tipo} e recuperou {Bananas[IndiceBanana2].Energia} em energia.");
            Macacos[IndiceMacaco2].ComerBanana(IndiceBanana2);
        break;


    }
}