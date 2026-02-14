class Banana
{
    public string Tipo { get; private set; }
    public int Energia { get; private set; }

    public Banana(string tipo, int energia)
    {
        if (string.IsNullOrWhiteSpace(tipo))
        {
            throw new ArgumentException("O tipo não pode ser nulo ou conter apenas espaços.");
        }
        if (energia < 0)
        {
            throw new ArgumentException("Uma banana não pode ter energia negativa.");
        }
        Tipo = tipo;
        Energia = energia;
    }

    public override string ToString()
    {
        return $"Tipo: Banana {Tipo} | Energia: {Energia}";
    }
}