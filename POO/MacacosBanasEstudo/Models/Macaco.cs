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
        if (BolsaVestida != null)
        {
            throw new InvalidOperationException("Não é possível vestir mais de uma bolsa.");
        }
        BolsaVestida = bolsa;
        Energia -= 2;
    }

    public void PegarBanana(Banana banana)
    {
        BolsaVestida.ArmazenarBanana(banana);
        Energia -= 1;
    }

    public void ComerBanana(int indexBananaComida)
    {
        IReadOnlyList<Banana> bananasNaBolsa = BolsaVestida.Bananas;

        if (bananasNaBolsa.Count == 0)
        {
            throw new InvalidOperationException("O macaco não possui bananas para comer.");
        } 

        Banana BananaComida = bananasNaBolsa[indexBananaComida];

        Energia += BananaComida.Energia;
        BolsaVestida.RemoverBanana(indexBananaComida);
    }

    public void DarBanana( Macaco Destinatario, int indexBananaDoada)
    {
        Banana BananaDoada = BolsaVestida.Bananas[indexBananaDoada];

        Destinatario.BolsaVestida.ArmazenarBanana(BananaDoada);
        BolsaVestida.RemoverBanana(indexBananaDoada);
    }

    public void SoltarBolsa()
    {
        if (BolsaVestida == null)
        {
            throw new InvalidOperationException("É necessário estar vestindo uma bolsa para soltar.");
        }

        Floresta.ReceberBolsa(BolsaVestida);
        BolsaVestida = null;
    }

    public override string ToString()
    {
        int LimiteArmazenamento = BolsaVestida != null ? BolsaVestida.LimiteArmazenamento : 0;
        int QuantidadeBananas = BolsaVestida != null ? BolsaVestida.Bananas.Count : 0;

        return $"Nome: {Nome} | BolsaVestida: {QuantidadeBananas}/{LimiteArmazenamento} | Energia: {Energia}";
    }
}