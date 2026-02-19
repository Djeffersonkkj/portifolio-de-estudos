class Chimpanze : Macaco
{
    public Chimpanze(string nome) : base(nome, 100.0m, 1.0m){}

    public void EnvenenarBanana(Macaco alvo)
    {
        decimal energiaGasta = 10.0m;
        Bolsa bolsaAlvo = alvo.BolsaVestida;
        int quantidadeBananasNaBolsa = bolsaAlvo.Bananas.Count;
        int sorteioBanana = Dado.RolarIndex(quantidadeBananasNaBolsa);
        Banana bananaEnvenenada = bolsaAlvo.Bananas[sorteioBanana];

        if (Energia <= energiaGasta)
        {
            throw new InvalidOperationException("Energia Insuficiente.");
        }

        bananaEnvenenada.Envenenar(15);
        GastarEnergia(energiaGasta);
    }

    public override string UsarHabilidadeEspecial(Macaco alvo)
    {
        EnvenenarBanana(alvo);
        if (alvo == this)
        {
            return $"O chimpanzé {Nome} envenenou a própria banana";
        }
        return $"O chimpanzé {Nome} envenenou uma banana de {alvo.Nome}";
    }
}