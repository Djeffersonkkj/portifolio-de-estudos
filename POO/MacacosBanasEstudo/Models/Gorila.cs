class Gorila : Macaco
{
    public Gorila(string nome) : base(nome, 200.0m, 0.5m){}

    public void Bater(Macaco vitima)
    {
        if (vitima == this)
        {
            throw new InvalidOperationException("Um macaco não pode bater em si mesmo.");
        }

        decimal sorteio = Dado.Rolar(100);

        if (sorteio >= 25 * vitima.Agilidade)
        {
            vitima.GastarEnergia(25.00m);     
        }
        GastarEnergia(12.5m);
    }
}