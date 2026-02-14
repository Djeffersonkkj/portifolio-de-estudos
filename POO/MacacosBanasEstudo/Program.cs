MainController Controller = new();
bool loop = true;

while (loop)
{
    string Opcao;

    Controller.ExibirMenu();
    Opcao = Console.ReadLine();
    switch (Opcao)
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
            Controller.PegarBanana();
        break;

        case "6":
            Controller.ComerBanana();
        break;

        case "7":
            Controller.DarBanana();
        break;
    }
}