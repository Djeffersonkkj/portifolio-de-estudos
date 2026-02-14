class Banana
{
    public string Tipo { get; private set; }
    public int Energia { get; private set; }
    public bool EstaEmPosse {get; private set; }
    public bool FoiComida { get; private set; }

    public Banana(string tipo, int energia = 0)
    {
        if (string.IsNullOrWhiteSpace(tipo))
        {
            throw new ArgumentException("O tipo não pode ser nulo ou conter apenas espaços.");
        }
        if (energia < 0)
        {
            throw new ArgumentException("Uma banana não pode ter energia negativa.");
        }
        EstaEmPosse = false;
        FoiComida = false;
        Tipo = tipo;
        Energia += energia;
    }

    public void PegaramBanana()
    {
        EstaEmPosse = true;
    }

    public void BananaComida()
    {
        FoiComida = true;
    }
}