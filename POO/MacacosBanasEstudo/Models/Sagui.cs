class Sagui : Macaco
{
    public Sagui(string nome) : base(nome, 60.0m, 2.0m){}

    public void RoubarBolsa(Macaco vitima)
    {

        if (vitima == this)
        {
            throw new InvalidOperationException("Não pode roubar de si mesmo.");
        }

        if (vitima.BolsaVestida == null)
        {
            throw new InvalidOperationException("A vítima não tem bolsa");
        }

        decimal energiaGasta = 10.0m;

        if (Energia <= energiaGasta)
        {
            throw new InvalidOperationException("Energia Insuficiente.");
        }

        VestirBolsa(vitima.SoltarBolsa());
        GastarEnergia(energiaGasta);
    }
}