Floresta floresta = new();
BananaServices bananaServices = new(floresta);
BolsaServices bolsaServices = new(floresta);
MacacoServices macacoServices = new(floresta);
MainController Controller = new(
    bananaServices,
    bolsaServices,
    macacoServices);

bool loop = true;

while (loop)
{
    string opcao;

    Controller.ExibirMenu();
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "0":
            Console.Clear();
            Console.WriteLine("Sistema Fechado!");
            loop = false;
        break;

        case "1":
            Controller.CadastrarMacaco();
        break;

        case "2":
            Controller.CadastrarBanana();
        break;

        case "3":
            Controller.CadastrarBolsa();
        break;

        case "4":
            Controller.PegarBolsa();
        break;

        case "5":
            Controller.SoltarBolsa();
        break;

        case "6":
            Controller.PegarBanana();
        break;

        case "7":
            Controller.ComerBanana();
        break;

        case "8":
            Controller.DarBanana();
        break;
    }
}