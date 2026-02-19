class Chimpanze : Macaco
{
    public Chimpanze(string nome) : base(nome, 100.0m, 1.0m){}

    public void EnvenenarComida(Macaco alvo)
    {
        decimal energiaGasta = 10.0m;
        Bolsa bolsaAlvo = alvo.BolsaVestida;
        int quantidadeItensNaBolsa = bolsaAlvo.Itens.Count;
        int sorteioItens = Dado.RolarIndex(quantidadeItensNaBolsa);
        Iconsumivel comidaEnvenenada = bolsaAlvo.Itens[sorteioItens];

        if (Energia <= energiaGasta)
        {
            throw new InvalidOperationException("Energia Insuficiente.");
        }

        comidaEnvenenada.Envenenar(15);
        GastarEnergia(energiaGasta);
    }

    public override string UsarHabilidadeEspecial(Macaco alvo)
    {
        EnvenenarComida(alvo);
        if (alvo == this)
        {
            return $"O chimpanzé {Nome} envenenou a própria banana";
        }
        return $"O chimpanzé {Nome} envenenou uma banana de {alvo.Nome}";
    }
}