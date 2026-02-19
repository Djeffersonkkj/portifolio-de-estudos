
//GERADO COM GEMINI
class InicializadorDados
{
    private readonly MainController _controller;

    public InicializadorDados(MainController controller)
    {
        _controller = controller;
    }

    public void Semear()
    {
        Console.WriteLine("Inicializando a floresta com dados de teste...");

        // 1. Criar Bananas
        _controller.BananaServices.CriarBanana("Nanica", 20); // Energia média
        _controller.BananaServices.CriarBanana("Prata", 15);  // Energia baixa
        _controller.BananaServices.CriarBanana("da Terra", 30);   // Energia alta
        _controller.BananaServices.CriarBanana("Ouro", 10); // Banana ruim (veneno em potencial)

        // 2. Criar Bolsas
        _controller.BolsaServices.CriarBolsa("Couro", 10);    // Cabe bastante
        _controller.BolsaServices.CriarBolsa("Palha", 3);     // Cabe pouco
        _controller.BolsaServices.CriarBolsa("Folha", 5);

        // 3. Criar Macacos (Um de cada tipo para testar as mecânicas específicas)
        
        // Chimpanzé (Pode envenenar bananas - opção 9)
        _controller.MacacoServices.CriarChimpanze("Cesar"); 
        
        // Gorila (Pode bater em outros - opção 10)
        _controller.MacacoServices.CriarGorila("Kong");     
        
        // Sagui (Pode roubar bolsas - opção 8)
        _controller.MacacoServices.CriarSagui("Abu");       

        Console.WriteLine("Dados carregados com sucesso!");
        // Pequena pausa para o usuário ver que carregou
        System.Threading.Thread.Sleep(1000); 
        Console.Clear();
    }
}