class BolsaServices
{
    public static void CadastrarBolsa()
    {
        string Material;
        int ArmazenamentoLimite;

        Console.Clear();
        Console.Write("Qual o material da bolsa? ");
        Material = Console.ReadLine();
        Console.Write("Qual o limite da nova bolsa? ");
        ArmazenamentoLimite = int.Parse(Console.ReadLine());
        Floresta.AdicionarBolsa(Material, ArmazenamentoLimite);

        Console.Clear();
        Console.WriteLine($"Uma bolsa nova brotou na floresta!");
    }
}