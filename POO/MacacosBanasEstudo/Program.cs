Floresta floresta = new();
BananaServices bananaServices = new(floresta);
BolsaServices bolsaServices = new(floresta);
MacacoServices macacoServices = new(floresta);

MainController Controller = new(
    bananaServices,
    bolsaServices,
    macacoServices);
MacacoView macacoView = new(Controller);
BolsaView bolsaView = new(Controller);
BananaView bananaView = new(Controller);
MainView mainView = new(
    Controller, 
    macacoView, 
    bolsaView, 
    bananaView);

bool loop = true;

while (loop)
{
    string opcao;

    mainView.ExibirMenu();
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "0":
            Console.Clear();
            Console.WriteLine("Sistema Fechado!");
            loop = false;
            break;

        case "1":
            macacoView.ExibirMenu();
            string opcaoMacaco = Console.ReadLine();
            switch (opcaoMacaco)
            {
                case "0":
                    Console.Clear();
                    break;

                case "1":
                    macacoView.Cadastrar();
                    break;

                case "2":
                    mainView.ExibirMacacos();
                    break;

                case "3":
                    mainView.PegarBolsa();
                    break;

                case "4":
                    macacoView.SoltarBolsa();
                    break;

                case "5":
                    mainView.PegarBanana();
                    break;

                case "6":
                    mainView.ComerBanana();
                    break;

                case "7":
                    mainView.DarBanana();
                    break;

                case "8":
                    macacoView.RoubarBanana();
                    break;

                case "9":
                    macacoView.EnvenenarBanana();
                    break;

                case "10":
                    macacoView.Bater();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opçao inválida!");
                    break;
            }
            break;

        case "2":
            bananaView.CadastrarBanana();
            break;

        case "3":
            bolsaView.CadastrarBolsa();
            break;

        default:
            Console.Clear();
            Console.WriteLine("Opçao inválida!");
            break;
    }
}