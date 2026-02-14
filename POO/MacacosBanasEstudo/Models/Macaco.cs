using System.ComponentModel;

class Macaco
{
    public Bolsa BolsaVestida { get; private set; }
    public string Nome { get; private set; }
    public int Energia { get; private set; }

    public Macaco(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome não pode ser nulo ou conter apenas espaços.");
        }
        Nome = nome;
        Energia = 100;
        BolsaVestida = null;
    }

    public void VestirBolsa(Bolsa bolsa)
    {
        ArgumentNullException.ThrowIfNull(bolsa);

        BolsaVestida = bolsa;
        Energia -= 2;
    }

    public void PegarBanana(Banana banana)
    {
        ArgumentNullException.ThrowIfNull(banana);

        BolsaVestida.ArmazenarBanana(banana);
        Energia -= 1;
    }

    public void ComerBanana(int indexBananaComida)
    {
        if (BolsaVestida.Bananas.Count == 0)
        {
            throw new InvalidOperationException("O macaco não possui bananas para comer.");
        } 
        Banana BananaComida = BolsaVestida.Bananas[indexBananaComida];

        Energia += BananaComida.Energia;
        BolsaVestida.RemoverBanana(indexBananaComida);
    }

    public void DarBanana( Macaco macacoDestinatario, int indexBananaDoada)
    {
        ArgumentNullException.ThrowIfNull(macacoDestinatario);

        Banana BananaDoada = BolsaVestida.Bananas[indexBananaDoada];

        macacoDestinatario.BolsaVestida.ArmazenarBanana(BananaDoada);
        BolsaVestida.RemoverBanana(indexBananaDoada);
    }

    public override string ToString()
    {
        int LimiteArmazenamento = BolsaVestida != null ? BolsaVestida.LimiteArmazenamento : 0;
        int QuantidadeBananas = BolsaVestida != null ? BolsaVestida.Bananas.Count : 0;

        return $"Nome: {Nome} | BolsaVestida: {QuantidadeBananas}/{LimiteArmazenamento} | Energia: {Energia}";
    }
}