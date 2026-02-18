class Chimpanze : Macaco
{
    public Chimpanze(string nome) : base(nome, 100.0m, 1.0m){}

    public void EnvenenarBanana(Banana banana)
    {
        banana.Envenenar(15);
        GastarEnergia(10);
    }
}