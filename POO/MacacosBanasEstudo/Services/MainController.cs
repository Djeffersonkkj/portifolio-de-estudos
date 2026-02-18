using System.Security.Cryptography;

class MainController
{
    public BananaServices BananaServices { get; private set; }
    public BolsaServices BolsaServices { get; private set; }
    public MacacoServices MacacoServices { get; private set; }

    public MainController(
        BananaServices bananaServices,
        BolsaServices bolsaServices,
        MacacoServices macacoServices)
    {
        BananaServices = bananaServices;
        BolsaServices = bolsaServices;
        MacacoServices = macacoServices;

    }
}