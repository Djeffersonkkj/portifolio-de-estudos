class MacacoServices
{
    public static void CadastrarMacaco()
    {
        string NomeMacaco;
        Console.Clear();
        Console.Write("Qual o nome do novo macaco? ");
        NomeMacaco = Console.ReadLine();

        Floresta.AdicionarMacaco(NomeMacaco);

        Console.Clear();
        Console.WriteLine($"O macaco {NomeMacaco} chegou à floresta!");
    }

    public static void ExibirBananas(Macaco macaco)
    {
        Bolsa bolsaDeBananas = macaco.BolsaVestida;
        IReadOnlyList<Banana> bananasNaBolsa = bolsaDeBananas.Bananas;

        Console.WriteLine($"Bananas do {macaco.Nome}:\n");
        for (int i = 0; i < bananasNaBolsa.Count; i++)
        {
            String BananaDescricao = bananasNaBolsa[i].ToString();
            Console.WriteLine($"[{i}]  {BananaDescricao}");
        };
    }

    public static int SeletorBananaIndex(Macaco macacoComedor)
    {
        int indiceBanana;
        indiceBanana = int.Parse(Console.ReadLine());
        
        return indiceBanana;
    }
}