class FlorestaServices
{
    public static void ExibirMacacos()
    {
        Console.WriteLine("Macacos na floresta:\n");
        for (int i = 0; i < Floresta.Macacos.Count; i++)
        {
            string MacacoDescricao = Floresta.Macacos[i].ToString();
            Console.WriteLine($"[{i}] {MacacoDescricao}");
        }
    }

    public static void ExibirBolsas()
    {
        Console.WriteLine("Bolsas no chão:\n");
        for (int i = 0; i < Floresta.Bolsas.Count; i++)
        {
            string DescricaoBolsa = Floresta.Bolsas[i].ToString();
            Console.WriteLine($"[{i}] {DescricaoBolsa}");
        }
    }

    public static void ExibirBananas()
    {
        Console.WriteLine("Bananas nas bananeiras:\n");
        for (int banana = 0; banana < Floresta.Bananas.Count; banana++)
        {
            string DescricaoBanana = Floresta.Bananas[banana].ToString();
            Console.WriteLine($"[{banana}] {DescricaoBanana}");
        }
    }

    public static Macaco SeletorMacaco()
    {
        int indexMacaco;
        
        indexMacaco = int.Parse(Console.ReadLine());

        return Floresta.Macacos[indexMacaco];
    }

}