static class Dado
{
    private static readonly Random _randon = new Random();

    public static int Rolar(int lados)
    {
        int resultado = _randon.Next(1, lados + 1);
        return resultado;
    }
}