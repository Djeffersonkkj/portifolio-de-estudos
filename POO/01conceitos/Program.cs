// Exemplo 01
Pessoa obj1 = new Pessoa();
obj1.Nome = "Will Is Meat";
obj1.Apresentacao();

//Exemplo 02
Pessoa obj2 = new();
obj2.Nome = "Lodoswaldo";
obj2.Apresentacao();

//Exemplo 03
Pessoa obj3 = new()
{
    Nome = "Thays Carla",
    Idade = 23
};
string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno);