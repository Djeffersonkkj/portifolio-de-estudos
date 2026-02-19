class Chimpanze : Macaco
{
    public Chimpanze(string nome) : base(nome, 100.0m, 1.0m){}

    public void EnvenenarBanana(Banana banana)
    {
        decimal energiaGasta = 10.0m;

        if (Energia <= energiaGasta)
        {
            throw new InvalidOperationException("Energia Insuficiente.");
        }

        banana.Envenenar(15);
        GastarEnergia(energiaGasta);
    }
}