class BananaServices
{
    public static void CadastrarBanana()
    {
        string TipoBanana;
        int EnergiaBanana;

        Console.Clear();
        Console.Write("Qual o tipo da nova banana? ");
        TipoBanana = Console.ReadLine();
        Console.Write("Quanta energia a banana dá? ");
        EnergiaBanana = int.Parse(Console.ReadLine());
        Floresta.AdicionarBanana(TipoBanana, EnergiaBanana);


        Console.Clear();
        Console.WriteLine($"Uma banana {TipoBanana} brotou na floresta!");
    }


}