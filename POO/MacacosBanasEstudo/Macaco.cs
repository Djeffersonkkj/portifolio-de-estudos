using System.ComponentModel;

class Macaco
{
    public string Nome { get; private set; }
    public List<Banana> Bananas { get; private set; }
    public int Energia { get; private set; }

    public Macaco(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome não pode ser nulo ou conter apenas espaços.");
        }
        Nome = nome;
        Energia = 100;
        Bananas = new List<Banana>();
    }

    public void PegarBanana(Banana bananaPega)
    {
        if (bananaPega.FoiComida)
        {
            throw new ArgumentException("Esta banana já foi comida.");
        }
        if (bananaPega.EstaEmPosse)
        {
            throw new ArgumentException("Esta banana já está em posse de outro macaco.");
        }
        ArgumentNullException.ThrowIfNull(bananaPega);

        Bananas.Add(bananaPega);
        Energia -= 1;
        bananaPega.PegaramBanana();
    }

    public void ComerBanana(int indiceBanana)
    {
        if (Bananas.Count == 0)
        {
            throw new InvalidOperationException("O macaco não possui bananas para comer.");
        } 

        Bananas[indiceBanana].BananaComida();
        Energia += Bananas[indiceBanana].Energia;
        Bananas.RemoveAt(indiceBanana);
    }

    public void DarBanana( Macaco macacoDestinatario)
    {
        ArgumentNullException.ThrowIfNull(macacoDestinatario);

        Console.WriteLine($"Escolha a banana que {Nome} deseja dar:\n");
        ExibirBananas();
        Console.Write("\nDigite o indice da banana: ");
        int bananaDoada = int.Parse(Console.ReadLine());

        Console.WriteLine($"O macaco {Nome} deu uma banana {Bananas[bananaDoada].Tipo} para {macacoDestinatario.Nome}");
        macacoDestinatario.Bananas.Add(Bananas[bananaDoada]);
        Bananas.RemoveAt(bananaDoada);
    }

    public void ExibirBananas()
    {
        if (Bananas.Count == 0)
        {
            Console.WriteLine($"O nacaco {Nome} não possui bananas.");
            return;
        }
        Console.WriteLine($"As bananas do macaco {Nome} são:\n");
        for (int indice = 0; indice < Bananas.Count; indice++)
        {
            Console.WriteLine($"{indice} | Banana {Bananas[indice].Tipo}");
        }
    }

    public override string ToString()
    {
        return $"Nome: {Nome} | Bananas: {Bananas.Count} | Energia: {Energia}";
    }
}