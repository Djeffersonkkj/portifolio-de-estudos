using System.ComponentModel;

class Macaco
{
    public string Nome { get; private set; }
    public Bolsa BolsaVestida { get; private set; }
    public decimal Energia { get; protected set; }
    public decimal Agilidade { get; protected set; }
    protected decimal _limiteEnergia;

    public Macaco(string nome, decimal limiteEnergia, decimal agilidade)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome não pode ser nulo ou conter apenas espaços.");
        }
        Nome = nome;
        BolsaVestida = null;
        Energia = limiteEnergia;
        Agilidade = agilidade;
        _limiteEnergia = limiteEnergia;
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

    public void ComerBanana(Banana banana)
    {
        IReadOnlyList<Banana> bananasNaBolsa = BolsaVestida.Bananas;

        if (bananasNaBolsa.Count == 0)
        {
            throw new InvalidOperationException("O macaco não possui bananas para comer.");
        } 
        if (Energia == _limiteEnergia)
        {
            throw new InvalidOperationException("Limite de energia atingido");
        }

        Energia = Math.Min(Energia + banana.Energia, _limiteEnergia);
        BolsaVestida.RemoverBanana(banana);
    }

    public void DarBanana( Macaco destinatario, Banana banana)
    {
        Bolsa bolsaDestinatario = destinatario.BolsaVestida;

        bolsaDestinatario.ArmazenarBanana(banana);
        BolsaVestida.RemoverBanana(banana);
    }

    public Bolsa SoltarBolsa()
    {
        if (BolsaVestida == null)
        {
            throw new InvalidOperationException("É necessário estar vestindo uma bolsa para soltar.");
        }

        Bolsa bolsaLargada = BolsaVestida;
        BolsaVestida = null;

        return bolsaLargada;
    }

    public void GastarEnergia(decimal energiaGasta)
    {
        Energia -= energiaGasta;
    }

    public override string ToString()
    {
        int limiteArmazenamento = BolsaVestida != null ? BolsaVestida.LimiteArmazenamento : 0;
        int quantidadeBananas = BolsaVestida != null ? BolsaVestida.Bananas.Count : 0;

        return $"Nome: {Nome} | BolsaVestida: {quantidadeBananas}/{limiteArmazenamento} | Energia: {Energia}";
    }
}